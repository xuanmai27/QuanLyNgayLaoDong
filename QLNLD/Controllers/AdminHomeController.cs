﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLNLD.Controllers
{
    public class AdminHomeController : Controller
    {
        // GET: AdminHome
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult QuanLy() {
            return View();
        }
        public ActionResult SinhVien()
        {
            return View();
        }
        public ActionResult EditQuanLy()
        {
            return View();  
        }
        public ActionResult EditSinhVien()
        {
            return View();
        }

    }
}