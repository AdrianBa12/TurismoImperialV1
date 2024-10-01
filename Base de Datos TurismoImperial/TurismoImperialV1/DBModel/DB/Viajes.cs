using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Viajes
{
    public int IdViajes { get; set; }

    public string? Servicio { get; set; }

    public decimal? PrecioMinimo { get; set; }

    public int? IdBus { get; set; }

    public string? NumeroAsientos { get; set; }

    public int? IdConductor { get; set; }

    public int? IdRutas { get; set; }

    public DateTime? FechaSalida { get; set; }

    public DateTime? FechaLlegada { get; set; }

    public virtual Buses? IdBusNavigation { get; set; }

    public virtual Conductor? IdConductorNavigation { get; set; }

    public virtual Rutas? IdRutasNavigation { get; set; }

    public virtual ICollection<Incidencias> Incidencia { get; set; } = new List<Incidencias>();
}
