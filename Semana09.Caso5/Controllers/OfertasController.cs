using Microsoft.AspNetCore.Mvc;
using Semana09.Caso5.Services;

namespace Semana09.Caso5.Controllers;

public class OfertasController : Controller
{
    private readonly ICatalogoService _catalogo;

    public OfertasController(ICatalogoService catalogo)
    {
        _catalogo = catalogo;
    }

    public IActionResult Index()
    {
        return View(_catalogo.ObtenerOfertas());
    }
}
