using Microsoft.AspNetCore.Mvc;

namespace DazzlingStore.Controllers
{
    //[Route("~/")]

    [Route("login")]
    public class LoginController : Controller
    {
        [Route("")]
        [Route("login")]
        public IActionResult Login()
        {
            return View();
        }

        [Route("register")]
        public IActionResult Register()
        {
            return View();
        }
    }
}
