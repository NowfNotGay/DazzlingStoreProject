using Microsoft.AspNetCore.Mvc;

namespace DazzlingStore.Controllers
{
    //[Route("~/")]

    [Route("login")]
    public class LoginController : Controller
    {
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
