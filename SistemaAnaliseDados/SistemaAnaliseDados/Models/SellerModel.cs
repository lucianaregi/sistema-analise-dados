using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaAnaliseDados.Models
{
    public class SellerModel
    {
        public int SellerId { get; set; }
        public string SellerName { get; set; }
        public string CPF { get; set; }
        public float Salary { get; set; }
        //enum identificador
    }
}