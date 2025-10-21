using System.Web;
using System.Web.Mvc;

namespace Asp_Dot_Net_Online_store_Project
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
