using Volo.Abp.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    // ¼Ì³ÐAbpController
    public class HomeController : AbpController
    {
        public IActionResult Index()
        {
            return Content("Hello World");
        }
    }
}