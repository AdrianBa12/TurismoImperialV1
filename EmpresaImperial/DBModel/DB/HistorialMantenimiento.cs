using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class HistorialMantenimiento
{
    public int IdMantenimiento { get; set; }

    public int? IdVehiculo { get; set; }

    public string? Descripcion { get; set; }

    public DateOnly? FechaMantenimiento { get; set; }

    public decimal? Costo { get; set; }

    public virtual Vehiculos? IdVehiculoNavigation { get; set; }
}
