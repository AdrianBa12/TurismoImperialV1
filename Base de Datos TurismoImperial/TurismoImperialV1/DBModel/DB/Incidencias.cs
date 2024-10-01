using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Incidencias
{
    public int IncidenciaId { get; set; }

    public int? IdBus { get; set; }

    public int? IdViaje { get; set; }

    public string? Descripcion { get; set; }

    public DateOnly? Fecha { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual Buses? IdBusNavigation { get; set; }

    public virtual Viajes? IdViajeNavigation { get; set; }
}
