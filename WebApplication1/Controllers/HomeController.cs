using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Student stud = new Student();
            stud.Id = 1;
            stud.Name = "MHS";
            stud.Desc = "Morbi";
            return View(stud);
        }

        public ActionResult About()
        {
            return View();
        }

        public string Test1()
        {
            return "Hello From Here";
        }

        public string Test2(string name)
        {
            // Pass URL like "http://localhost:50373/Home/test2?name=mhs"
            return "Hello From " + name;
        }

        public string Test3(int? name)
        {
            // int? is used to nullable value if we don't pass any value in url it don't give error
            return "Hello From " + name;
        }
    }
}