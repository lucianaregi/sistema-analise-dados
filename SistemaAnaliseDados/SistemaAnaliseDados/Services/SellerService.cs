using SistemaAnaliseDados.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace SistemaAnaliseDados.Services
{
    public class SellerService
    {
        public List<SellerModel> SellerInfo()
        {
            List<SellerModel> sellerList = new List<SellerModel>();
            var fileSellers = GetFilesDirectoryService.SellerFiles();
            foreach (var seller in fileSellers)
            {
                String[] sellerData = seller.ToString().Split(new string[] { "ç" }, StringSplitOptions.None);

                sellerList.Add(new SellerModel
                {
                   SellerName = sellerData[2].ToString(),
                   CPF = sellerData[1].ToString(),
                   Salary = float.Parse(sellerData[3], CultureInfo.InvariantCulture.NumberFormat)

                });
            }

            return sellerList;
        }
       
    }
}