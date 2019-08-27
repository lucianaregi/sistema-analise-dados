using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace SistemaAnaliseDados.Services
{
    public class ProcessFilesService
    {
        public void WriteFile()
        {
            string fileName = AppDomain.CurrentDomain.BaseDirectory + @"Data\Out\relatorio.txt";
            ClientService client = new ClientService();
            SellerService seller = new SellerService();
            SaleService sale = new SaleService();
            var saleInfo = sale.SaleInfo();

            try
            {
                   
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                using (StreamWriter sw = File.CreateText(fileName))
                {
                    sw.WriteLine("Novo arquivo criado: {0}", DateTime.Now.ToString());
                    sw.WriteLine("Quantidade de clientes: {0}", client.ClientInfo().Count);
                    sw.WriteLine("Qunatidade de vendedores: {0}", seller.SellerInfo().Count);
                    sw.WriteLine("ID venda mais cara: {0}", saleInfo.OrderByDescending(x => x.SumSales).Select(y => y.OrderId).First());
                    sw.WriteLine("Pior vendedor: {0}", saleInfo.OrderBy(x => x.SumSales).Select(y => y.SellerName).First());
                }

                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

    }
}