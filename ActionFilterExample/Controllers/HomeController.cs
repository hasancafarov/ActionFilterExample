using ActionFilterExample.CustomFilters;
using ActionFilterExample.CustomFilters.ActionFilters;
using ActionFilterExample.CustomFilters.AuthorizationFilters;
using Microsoft.AspNetCore.Mvc;

namespace ActionFilterExample.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        [HttpGet]
        [AddDebugInfoToResponse()]
        [LogStats()]
        [HttpsOnly()]
        public String Index()
        {
            return "ok";
        }
    }
}
