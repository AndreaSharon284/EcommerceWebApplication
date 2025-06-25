using Microsoft.AspNetCore.Mvc;

namespace eCommerceApp.Host.Controllers;

public class Productcontroller : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}