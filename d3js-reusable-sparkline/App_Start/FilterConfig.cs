using System.Web;
using System.Web.Mvc;

namespace d3js_reusable_sparkline
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}