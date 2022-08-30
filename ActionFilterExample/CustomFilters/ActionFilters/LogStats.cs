using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace ActionFilterExample.CustomFilters.ActionFilters
{
    public class LogStats : ActionFilterAttribute
    {
        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var stopwatch = Stopwatch.StartNew();

            var actionExecutedContext = await next();

            stopwatch.Stop();

            actionExecutedContext.HttpContext.Response.Headers.Add("Stats", stopwatch.Elapsed.ToString());
        }
    }

}
