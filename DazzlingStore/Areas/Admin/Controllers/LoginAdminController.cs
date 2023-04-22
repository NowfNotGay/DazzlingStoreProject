using Microsoft.AspNetCore.Mvc;

namespace DazzlingStore.Areas.Admin.Controllers;
[Area("admin")]
[Route("admin/login")]
public class LoginAdminController : Controller
{
    [Route("")]
    [Route("login")]
    public IActionResult Login()
    {
        return View();
    }
}
