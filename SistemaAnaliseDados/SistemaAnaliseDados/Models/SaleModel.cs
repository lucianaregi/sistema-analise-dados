using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaAnaliseDados.Models
{
    public class SaleModel
    {
        public int OrderId { get; set; }
        public string SellerName { get; set; }
        public ICollection<SaleOrderItemModel> SaleItems { get; set; }
    }
}