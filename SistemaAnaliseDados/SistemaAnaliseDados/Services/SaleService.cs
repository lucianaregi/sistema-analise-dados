using SistemaAnaliseDados.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
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
                var saleItens = GetItems(saleData[3].ToString().Split(new string[] { ","}, StringSplitOptions.None));
                var sum = SumItems(saleItens);
                saleList.Add(new SaleModel
                {
                    OrderId = int.Parse(saleData[1]),
                    SellerName = saleData[5],
                    SaleItems = saleItens,
                    SumSales = sum
                });
            }

            return saleList;
        }

        private List<SaleOrderItemModel> GetItems( String[] saleItems)
        {
            List<SaleOrderItemModel> items = new List<SaleOrderItemModel>();
            foreach (var item in saleItems)
            {
                var saleItem = item.Split(new string[] { "-"}, StringSplitOptions.None);

                items.Add( new SaleOrderItemModel{
                    SaleOrderItemId = int.Parse(saleItem[0]),
                    Qty = Int32.Parse(saleItem[1]),
                    Price = float.Parse(saleItem[2], CultureInfo.InvariantCulture.NumberFormat),
                });
            }
            return items;

        }

        private float SumItems(List<SaleOrderItemModel> orderItem)
        {
            float sum = 0;
            foreach (var item in orderItem)
            {
                sum += item.Qty * item.Price;
            }

            return sum;
        }
    }
}