﻿using Microsoft.AspNet.Identity;
using System.Runtime.Remoting.Contexts;
using System.Security.Claims;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashCollectorProject.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System.Threading.Tasks;

namespace TrashCollectorProject.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext context;

      
        public ActionResult Index()
        {

            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}