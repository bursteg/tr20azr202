using System.Web;
using System.Web.Mvc;

namespace TR20.AZR202.TeamCityDemo
{
  public class FilterConfig
  {
    public static void RegisterGlobalFilters(GlobalFilterCollection filters)
    {
      filters.Add(new HandleErrorAttribute());
    }
  }
}
