using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLNLD.Models;
namespace QLNLD.Controllers
{
    public class InfoController : Controller
    {
        private Model1 modelDB=new Model1();
        // GET: Info
        public ActionResult Index()
        {
           
            return PartialView();
        }
    }
}