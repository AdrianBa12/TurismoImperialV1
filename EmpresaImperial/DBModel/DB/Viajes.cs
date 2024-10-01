using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Viajes
{
    public int ViajeId { get; set; }

    public int? BusId { get; set; }

    public int? ConductorId { get; set; }

    public int? RutaId { get; set; }

    public DateTime? FechaSalida { get; set; }

    public DateTime? FechaLlegada { get; set; }

    public virtual Buses? Bus { get; set; }

    public virtual Conductores? Conductor { get; set; }

    public virtual ICollection<Horarios> Horarios { get; set; } = new List<Horarios>();

    public virtual ICollection<Incidencias> Incidencia { get; set; } = new List<Incidencias>();

    public virtual Rutas? Ruta { get; set; }
}
