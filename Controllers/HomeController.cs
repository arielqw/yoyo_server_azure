using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YoYoServerWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            long testCalc = Power(2, 2);
            for(var i=0; i<4; i++)
            {
                testCalc = Power(2, testCalc);
            }
            ViewBag.Title = string.Format("Home Page: {0}", testCalc);

            return View();
        }

        public static long Power(long A, long n)
        {
            long result = 1;    // if n==0,A^n==1

            if (n > 0)
            {
                do
                {
                    result *= A;
                    n--;
                } while (n > 0);
            }
            return result;
        }
    }
}
