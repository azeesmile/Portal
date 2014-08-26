using System.Web.Mvc;

namespace Portal.Areas.FrontEnd
{
    public class FrontEndAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "FrontEnd";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "FrontEnd_default",
                "FrontEnd/{controller}/{action}/{id}",
                new { controller="Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "Portal.Areas.FrontEnd.Controllers" }
            );
        }
    }
}