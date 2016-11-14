using System.Web;
using System.Web.Mvc;

namespace DivideAndWalkTheDog.WEB
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
