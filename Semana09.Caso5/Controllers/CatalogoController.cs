using Microsoft.AspNetCore.Mvc;
using Semana09.Caso5.Services;

namespace Semana09.Caso5.Controllers;

public class CatalogoController : Controller
{
    private readonly ICatalogoService _catalogo;

    public CatalogoController(ICatalogoService catalogo)
    {
        _catalogo = catalogo;
    }

    public IActionResult Index()
    {
        return View(_catalogo.ObtenerTodos());
    }
}
