using SistemaAnaliseDados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaAnaliseDados.Services
{
    public class SaleService
    {
        public List<SaleModel> SaleInfo()
        {
            List<SaleModel> saleList = new List<SaleModel>();
            List<SaleOrderItemModel> items = new List<SaleOrderItemModel>();
            var fileSales = GetFilesDirectoryService.SaleFiles();
            foreach (var sale in fileSales)
            {
                String[] saleData = sale.ToString().Split(new string[] { "ç", "[", "]"}, StringSplitOptions.None);
                String[] saleItens = saleData[3].ToString().Split(new string[] { ","}, StringSplitOptions.None);
               
                saleList.Add(new SaleModel
                {
                    

                });
            }

            return saleList;
        }
    }
}