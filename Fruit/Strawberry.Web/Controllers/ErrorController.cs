using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Strawberry.Web.Controllers
{
    public class ErrorController : Controller
    {
        //
        // GET: /Error/PageNotFound
        public ActionResult PageNotFound()
        {
            return View();
        }
	}
}