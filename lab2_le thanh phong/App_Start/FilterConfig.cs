using System.Web;
using System.Web.Mvc;

namespace lab2_le_thanh_phong
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
