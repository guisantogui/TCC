using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Front_End.Controllers
{
    public class ProfessionalController : Controller
    {
        //
        // GET: /Professional/
        public ActionResult Index()
        {
            return View();
        }

        //Evento de teste
        public ActionResult Sum(int nro1, int nro2)
        {
            var value = nro1 + nro2;

            ViewBag.SumResult = value;

            return View();
        }
	}
}