using SistemaAnaliseDados.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaAnaliseDados.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ClientService client = new ClientService();
            SellerService seller = new SellerService();
            SaleService sale = new SaleService();
            var saleInfo = sale.SaleInfo();
            var clientCount = client.ClientInfo().Count;
            var sellerInfo = seller.SellerInfo().Count;

            return View();
        }
    }
}