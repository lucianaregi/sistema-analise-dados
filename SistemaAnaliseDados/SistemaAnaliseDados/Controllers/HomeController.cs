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
            ViewBag.QtdyFile = GetFilesDirectoryService.CountFiles();
            return View();
        }
    }
}