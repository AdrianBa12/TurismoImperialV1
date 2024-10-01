using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Promociones
{
    public int IdPromocion { get; set; }

    public string? CodigoDescuento { get; set; }

    public string? Descripcion { get; set; }

    public decimal? MontoDescuento { get; set; }

    public DateOnly? FechaInicio { get; set; }

    public DateOnly? FechaFin { get; set; }

    public virtual ICollection<Descuentos> Descuentos { get; set; } = new List<Descuentos>();
}
