﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyCom.Api.Controllers
{
    public class ProductController : Controller
    {
      
      
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        // GET: Product
        public ActionResult GetProducts()
        {
            return View();
        }
    }
}