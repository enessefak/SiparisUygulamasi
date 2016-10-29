using System.Web.Mvc;

namespace Siparis.MVC.Areas.Siparis
{
    public class SiparisAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Siparis";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Siparis_default",
                "Siparis/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}