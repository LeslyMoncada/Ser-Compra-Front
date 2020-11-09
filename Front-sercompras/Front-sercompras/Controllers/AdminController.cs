using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Front_sercompras.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Inicioadmin()
        {
            return View();
        }
        public ActionResult Gproveedores()
        {
            return View();
        }
        public ActionResult Gfuncionarios()
        {
            return View();
        }
    }
}