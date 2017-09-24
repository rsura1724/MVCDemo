using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Common;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: One
        [TrackExecTime]
        public string Index()
        {
            return " Index action invoked ";
        }
        public string AnAction()
        {
            throw new Exception(" Some kind Of exception");
        }
    }
}