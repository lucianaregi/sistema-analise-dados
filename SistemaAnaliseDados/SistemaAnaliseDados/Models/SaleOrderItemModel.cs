﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaAnaliseDados.Models
{
    public class SaleOrderItemModel
    {
        public int SaleOrderItemId { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }
    }
}