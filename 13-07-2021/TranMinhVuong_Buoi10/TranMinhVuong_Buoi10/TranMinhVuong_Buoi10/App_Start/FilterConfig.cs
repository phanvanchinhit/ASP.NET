using System.Web;
using System.Web.Mvc;

namespace TranMinhVuong_Buoi10
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
