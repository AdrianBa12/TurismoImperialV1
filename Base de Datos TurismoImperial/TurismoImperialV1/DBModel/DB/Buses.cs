using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Buses
{
    public int IdBuses { get; set; }

    public string? Servicio { get; set; }

    public decimal? PrecioMinimo { get; set; }

    public decimal? PrecioPromedio { get; set; }

    public int? NumeroAsientos { get; set; }

    public int? IdConductor { get; set; }

    public int? IdRutas { get; set; }

    public DateTime? FechaSalida { get; set; }

    public DateTime? FechaLlegada { get; set; }

    public virtual Conductor? IdConductorNavigation { get; set; }

    public virtual Rutas? IdRutasNavigation { get; set; }

    public virtual ICollection<Incidencias> Incidencia { get; set; } = new List<Incidencias>();

    public virtual ICollection<MantenimientoBuses> MantenimientoBuses { get; set; } = new List<MantenimientoBuses>();

    public virtual ICollection<RevisionesBuses> RevisionesBuses { get; set; } = new List<RevisionesBuses>();

    public virtual ICollection<Viajes> Viajes { get; set; } = new List<Viajes>();
}
