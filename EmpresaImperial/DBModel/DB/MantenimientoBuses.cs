using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class MantenimientoBuses
{
    public int MantenimientoId { get; set; }

    public int? BusId { get; set; }

    public DateOnly? FechaMantenimiento { get; set; }

    public string? Descripcion { get; set; }

    public DateTime FechaRegistro { get; set; }

    public virtual Buses? Bus { get; set; }
}
