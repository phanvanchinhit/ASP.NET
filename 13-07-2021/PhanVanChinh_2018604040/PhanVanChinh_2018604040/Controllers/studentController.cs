using PhanVanChinh_2018604040.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhanVanChinh_2018604040.Controllers
{
    public class studentController : Controller
    {
        // GET: student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Regis(Student s)
        {
            return View(s);
        }

        public ActionResult Regis2(FormCollection f)
        {
            Student s = new Student();
            s.Name = f["name"];
            s.Gender = f["gender"];
            s.Email = f["email"];
            s.Addr = f["addr"];

            string temp = "";

            if (f["Java core"] == "true,false")
                temp = "Java core";
            if (f["SQL server"] == "true,false")
                temp += " " + "SQL Server";
            if (f["PHP"] == "true,false")
                temp += " " + "PHP";

            s.Subjects = temp;

            s.Username = f["username"];
            s.Password = f["password"];
            s.Comment = f["comment"];
            return View(s);
        }
    }
}