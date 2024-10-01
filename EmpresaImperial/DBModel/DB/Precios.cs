using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Precios
{
    public int PrecioId { get; set; }

    public int? RutaId { get; set; }

    public string? Clase { get; set; }

    public decimal? Monto { get; set; }

    public DateOnly? FechaVigencia { get; set; }

    public virtual Rutas? Ruta { get; set; }
}
