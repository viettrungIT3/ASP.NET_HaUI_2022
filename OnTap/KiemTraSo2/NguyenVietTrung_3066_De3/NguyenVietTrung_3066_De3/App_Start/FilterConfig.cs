using System.Web;
using System.Web.Mvc;

namespace NguyenVietTrung_3066_De3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
