using Microsoft.AspNetCore.Mvc.Filters;

namespace ActionFilterExample.CustomFilters.ActionFilters
{
    public class RequestLogger : ActionFilterAttribute
    {
        public readonly string Id = Guid.NewGuid().ToString();
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine($"Id={Id} Request {context.HttpContext.Request.Method} {context.HttpContext.Request.Path} routed to {context.Controller.GetType().Name}");

            base.OnActionExecuting(context);
        }
        /*Notice the id is the same for two POST requests, but it’s different from id shown for the GET requests. 
         * This is because one instance is created per registration ([RequestLogger] was registered on the GET and POST methods, hence two instances).*/
    }
}
