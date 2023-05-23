using Microsoft.AspNetCore.Mvc;

namespace DazzlingStore.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/homeadmin")]
    public class HomeAdminController : Controller
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
