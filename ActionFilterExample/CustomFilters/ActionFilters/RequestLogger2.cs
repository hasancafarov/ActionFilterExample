using Microsoft.AspNetCore.Mvc.Filters;

namespace ActionFilterExample.CustomFilters.ActionFilters
{
    public class RequestLogger2 : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine($"Action executed. Response.StatusCode={context.HttpContext.Response.StatusCode}");
            base.OnActionExecuted(context);
        }
        public override void OnResultExecuted(ResultExecutedContext context)
        {
            Console.WriteLine($"Result executed. Response.StatusCode={context.HttpContext.Response.StatusCode}");
            base.OnResultExecuted(context);
        }

        /*When an action method is executed, it returns a result object (such as BadRequestResult). 
         * The framework has to execute this result in order to populate the HttpContext.Response. 
         * This is done after OnActionExecuted. That’s why if you try to check HttpContext.Response in OnActionExecuted, it won’t have the correct values.

*/
    }
}
