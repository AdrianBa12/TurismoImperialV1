using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Incidencias
{
    public int IncidenciaId { get; set; }

    public int? BusId { get; set; }

    public int? ViajeId { get; set; }

    public string? Descripcion { get; set; }

    public DateOnly? Fecha { get; set; }

    public DateTime FechaRegistro { get; set; }

    public virtual Buses? Bus { get; set; }

    public virtual Viajes? Viaje { get; set; }
}
