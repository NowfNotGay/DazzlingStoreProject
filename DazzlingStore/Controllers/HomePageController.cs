using Microsoft.AspNetCore.Mvc;

namespace DazzlingStore.Controllers
{
    [Route("homepage")]
    public class HomePageController : Controller
    {
        [Route("~/")]
        [Route("")]
        [Route("index")]

        public IActionResult Index()
        {
            return View();
        }
    }
}
