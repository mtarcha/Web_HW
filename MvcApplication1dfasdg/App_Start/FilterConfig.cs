using System.Web;
using System.Web.Mvc;

namespace MvcApplication1dfasdg
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}