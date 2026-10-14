using Microsoft.AspNetCore.Mvc;

namespace Semana09.Caso5.Controllers;

public class AdminController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
