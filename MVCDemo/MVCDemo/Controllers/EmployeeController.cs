using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            List<Employee> emp = new List<Employee>()
            {
                new Employee{ID = 1, FirstName = "Rohith", LastName = "Sura", City= "Coppell"}

            };
            emp.Add(new Employee { ID = 2, FirstName = "Sandeep", LastName = "Nalla", City = "Coppell" });
            
            return View(emp);
        }
    }
}