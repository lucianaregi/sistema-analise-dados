using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaAnaliseDados.Models
{
    public class ClientModel
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string BussinesArea { get; set; }
        public string CNPJ { get; set; }
      
    }
}