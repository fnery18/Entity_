﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo02.MVC.Web.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Default()
        {
            return View();
        }
        public ActionResult NotFound()
        {
            return View();
        }
    }
}