using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class RevisionesBuses
{
    public int IdRevicionesBuses { get; set; }

    public int? IdBus { get; set; }

    public DateOnly? FechaRevision { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual Buses? IdBusNavigation { get; set; }
}
