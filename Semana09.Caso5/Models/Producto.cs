namespace Semana09.Caso5.Models;

public class Producto
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Descripcion { get; set; } = string.Empty;
    public decimal Precio { get; set; }
    public bool EnOferta { get; set; }
    public decimal? PrecioOferta { get; set; }
}
