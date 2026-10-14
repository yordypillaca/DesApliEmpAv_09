using Semana09.Caso5.Models;

namespace Semana09.Caso5.Services;

public interface ICatalogoService
{
    IReadOnlyList<Producto> ObtenerTodos();
    IReadOnlyList<Producto> ObtenerOfertas();
}
