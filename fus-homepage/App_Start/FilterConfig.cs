using System.Web;
using System.Web.Mvc;

namespace fus_homepage {
  public class FilterConfig {
    public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
      filters.Add(new HandleErrorAttribute());
    }
  }
}
