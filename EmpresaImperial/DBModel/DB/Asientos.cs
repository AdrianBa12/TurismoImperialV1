using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Asientos
{
    public int IdAsiento { get; set; }

    public int? IdVehiculo { get; set; }

    public int? NumeroAsiento { get; set; }

    public string? EstadoAsiento { get; set; }

    public virtual Vehiculos? IdVehiculoNavigation { get; set; }
}
