using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Buses
{
    public int BusId { get; set; }

    public string? NumeroBus { get; set; }

    public int? Capacidad { get; set; }

    public string? Estado { get; set; }

    public DateTime FechaRegistro { get; set; }

    public virtual ICollection<Incidencias> Incidencia { get; set; } = new List<Incidencias>();

    public virtual ICollection<MantenimientoBuses> MantenimientoBuses { get; set; } = new List<MantenimientoBuses>();

    public virtual ICollection<RevisionesBuses> RevisionesBuses { get; set; } = new List<RevisionesBuses>();

    public virtual ICollection<Viajes> Viajes { get; set; } = new List<Viajes>();
}
