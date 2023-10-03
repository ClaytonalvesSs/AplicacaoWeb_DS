using System.Web;
using System.Web.Mvc;

namespace Aplicacao_web_ds_eve
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
