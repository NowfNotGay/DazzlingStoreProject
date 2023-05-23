using Microsoft.AspNetCore.Mvc;

namespace DazzlingStore.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/categories")]
    public class CategoriesController : Controller
    {
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("createcategory")]
        public IActionResult CreateCategory()
        {
            return View();
        }
    }
}
