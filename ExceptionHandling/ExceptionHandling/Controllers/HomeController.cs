using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static ExceptionHandling.MvcApplication;

namespace ExceptionHandling.Controllers
{
    [MyExceptionHandler]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string msg = null;
            ViewBag.Message = msg.Length; // this will throw an exception
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [HandleError]
        [HandleError(ExceptionType = typeof(NullReferenceException), View = "~/Views/shared/Handleerrorattribute.cshtml")]
        public ActionResult Contact()
        {
            string msg = null;
            ViewBag.Message = msg.Length; // this will throw an exception

            return View();
        }   
        
        
        public ActionResult Contact2()
        {
            string msg = null;
            ViewBag.Message = msg.Length; // this will throw an exception

            return View();
        }

        //protected override void OnException(ExceptionContext filterContext)
        //{
        //    filterContext.ExceptionHandled = true;

        //    //Log the error!!

        //    //Redirect to action
        //    //filterContext.Result = RedirectToAction("Error", "InternalError");

        //    // OR return specific view
        //    filterContext.Result = new ViewResult
        //    {
        //        ViewName = "~/Views/shared/ControllerOnException .cshtml"
        //    };
        //}
    }
}