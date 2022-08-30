using Microsoft.AspNetCore.Mvc.Filters;

namespace ActionFilterExample.CustomFilters.ActionFilters
{
    public class AddDebugInfoToResponse : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            context.HttpContext.Response.Headers.Add("DebugInfo", context.ActionDescriptor.DisplayName);
            context.HttpContext.Response.Headers.ToList().ForEach(x => Console.WriteLine(x.Key + ". " + x.Value));
            base.OnActionExecuted(context);
        }

    }
}
