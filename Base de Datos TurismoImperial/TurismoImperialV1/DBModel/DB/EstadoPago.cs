using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class EstadoPago
{
    public string IdEstadoPago { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual ICollection<Pagos> Pagos { get; set; } = new List<Pagos>();
}
