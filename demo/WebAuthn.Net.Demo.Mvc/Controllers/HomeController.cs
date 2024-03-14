using Microsoft.AspNetCore.Mvc;

namespace WebAuthn.Mvc.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return RedirectToAction("Index", "Passwordless");
    }
}
