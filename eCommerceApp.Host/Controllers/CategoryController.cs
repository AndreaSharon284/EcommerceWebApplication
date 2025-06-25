using Microsoft.AspNetCore.Mvc;

namespace eCommerceApp.Host.Controllers;

public class CategoryController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}