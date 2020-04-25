using System.Web;
using System.Web.Mvc;

namespace NUJ_Oyo_State
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
