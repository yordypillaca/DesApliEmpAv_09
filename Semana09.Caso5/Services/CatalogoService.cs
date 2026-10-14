using Semana09.Caso5.Models;

namespace Semana09.Caso5.Services;

public class CatalogoService : ICatalogoService
{
    private readonly List<Producto> _productos =
    [
        new() { Id = 1, Nombre = "Audífonos", Descripcion = "Inalámbricos con cancelación de ruido", Precio = 189.90m, EnOferta = true, PrecioOferta = 149.90m },
        new() { Id = 2, Nombre = "Teclado", Descripcion = "Mecánico, distribución en español", Precio = 129.00m, EnOferta = false },
        new() { Id = 3, Nombre = "Mouse", Descripcion = "Ergonómico, 6 botones", Precio = 59.90m, EnOferta = true, PrecioOferta = 39.90m },
        new() { Id = 4, Nombre = "Monitor 24\"", Descripcion = "Full HD, 75 Hz", Precio = 499.00m, EnOferta = false },
        new() { Id = 5, Nombre = "Webcam", Descripcion = "1080p con micrófono", Precio = 99.00m, EnOferta = true, PrecioOferta = 79.00m },
        new() { Id = 6, Nombre = "Mochila", Descripcion = "Para laptop de hasta 15 pulgadas", Precio = 89.50m, EnOferta = false }
    ];

    public IReadOnlyList<Producto> ObtenerTodos() => _productos;

    public IReadOnlyList<Producto> ObtenerOfertas() =>
        _productos.Where(p => p.EnOferta).ToList();
}
