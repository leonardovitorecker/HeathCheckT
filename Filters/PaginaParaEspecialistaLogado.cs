using HeathCheck1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;

namespace HeathCheck1.Filters
{
    public class PaginaParaEspecialistaLogado : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            string sessaoEspecialista = context.HttpContext.Session.GetString("sessaoEspecialistaLogado");

            if (string.IsNullOrEmpty(sessaoEspecialista))
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary { { "controller", "Login" }, { "action", "Index" } });
            }
            else
            {
                EspecialistaModel especialista = JsonConvert.DeserializeObject<EspecialistaModel>(sessaoEspecialista);

                if (especialista == null)
                {
                    context.Result = new RedirectToRouteResult(new RouteValueDictionary { { "controller", "Login" }, { "action", "Index" } });
                }
            }

            base.OnActionExecuting(context);
        }
    }
}
