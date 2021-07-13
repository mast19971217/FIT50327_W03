using System.Web;
using System.Web.Mvc;

namespace FIT50327_MyModalFirst
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
