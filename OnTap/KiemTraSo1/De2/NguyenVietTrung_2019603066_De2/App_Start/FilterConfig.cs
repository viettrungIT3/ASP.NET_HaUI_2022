using System.Web;
using System.Web.Mvc;

namespace NguyenVietTrung_2019603066_De2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
