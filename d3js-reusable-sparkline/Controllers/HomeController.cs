using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace d3js_reusable_sparkline.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Returning some dummy data here. Replace with your collection
        /// </summary>
        public JsonResult ChartData()
        {
            var list = new List<object>();

            list.Add(new { Date = DateTime.Parse("Dec 18, 2013"), Close = 1084.75 });
            list.Add(new { Date = DateTime.Parse("Dec 17, 2013"), Close = 1069.86 });
            list.Add(new { Date = DateTime.Parse("Dec 16, 2013"), Close = 1072.98 });
            list.Add(new { Date = DateTime.Parse("Dec 13, 2013"), Close = 1060.79 });
            list.Add(new { Date = DateTime.Parse("Dec 12, 2013"), Close = 1069.96 });
            list.Add(new { Date = DateTime.Parse("Dec 11, 2013"), Close = 1077.29 });
            list.Add(new { Date = DateTime.Parse("Dec 10, 2013"), Close = 1084.66 });
            list.Add(new { Date = DateTime.Parse("Dec 9, 2013"), Close = 1078.14 });
            list.Add(new { Date = DateTime.Parse("Dec 6, 2013"), Close = 1069.87 });
            list.Add(new { Date = DateTime.Parse("Dec 5, 2013"), Close = 1057.34 });
            list.Add(new { Date = DateTime.Parse("Dec 4, 2013"), Close = 1058.18 });
            list.Add(new { Date = DateTime.Parse("Dec 3, 2013"), Close = 1053.26 });
            list.Add(new { Date = DateTime.Parse("Dec 2, 2013"), Close = 1054.48 });
            list.Add(new { Date = DateTime.Parse("Nov 29, 2013"), Close = 1059.59 });
            list.Add(new { Date = DateTime.Parse("Nov 27, 2013"), Close = 1063.11 });
            list.Add(new { Date = DateTime.Parse("Nov 26, 2013"), Close = 1058.41 });

            return Json(list, JsonRequestBehavior.AllowGet);
        }

    }
}
