using KyTucXaDHBK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KyTucXaDHBK.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/
        DataContext datacontext = new DataContext();
        public ActionResult Index()
        {
            datacontext.BaoVangs.ToList();
            return View("Test");
        }

    }
}
