using PagedList;
using paging.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace paging.Controllers
{
    public class HomeController : Controller
    {
        private TestDBEntities dbcontext = new TestDBEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetData(int? page)
        {
            
            var emps = from s in dbcontext.tblEmps orderby s.id select s;

            int pageSize = 5;
            int pageNumber = (page ?? 1);
            return View(emps.ToPagedList(pageNumber, pageSize));
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