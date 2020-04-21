using System.Web.Mvc;

namespace AgendaOnline.MVC.Filtros
{
    public class AutorizacaoFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            object Usuario = filterContext.HttpContext.Session["UsuarioLogado"];
            if (Usuario == null)
            {
                filterContext.Result = new RedirectToRouteResult(
                    new System.Web.Routing.RouteValueDictionary(
                        new { Controller = "Login", action = "Index" }
                        )
                    );
            }
        }
    }
}