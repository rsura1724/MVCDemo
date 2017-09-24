using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace MVCDemo.Common
{
    public class TrackExecTime : ActionFilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            
            // throw new NotImplementedException();
            string msg = filterContext.Exception.Message + HttpContext.Current.ApplicationInstance.Request.UserAgent;
            LogTime(msg);
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //base.OnActionExecuting(filterContext);
            string msg = "\n" + filterContext.ActionDescriptor.ControllerDescriptor.ControllerName + " ::" + filterContext.ActionDescriptor.ActionName + "::on executing----" + DateTime.Now.ToString() + "\n";
            LogTime(msg);
            
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            // base.OnActionExecuted(filterContext);
            string msg =  filterContext.ActionDescriptor.ControllerDescriptor.ControllerName + " ::" + filterContext.ActionDescriptor.ActionName + "::on executed----" + DateTime.Now.ToString() + "\n";
            LogTime(msg);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            // base.OnResultExecuting(filterContext);
            string msg = filterContext.RouteData.Values["controller"].ToString() + " ::" + filterContext.RouteData.Values["action"].ToString() + "::on result executing----" + DateTime.Now.ToString() + "\n";
            LogTime(msg);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            // base.OnResultExecuted(filterContext);
            string msg = filterContext.RouteData.Values["controller"].ToString() + " ::" + filterContext.RouteData.Values["action"].ToString() + "::on result executed----" + DateTime.Now.ToString() + "\n";
            LogTime(msg);
        }

        private void LogTime(string data)
        {
            File.AppendAllText(HttpContext.Current.Server.MapPath("~/Output/OutputFile.txt"),data);
        }
    }
}