using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class RevisionesBuses
{
    public int RevisionId { get; set; }

    public int? BusId { get; set; }

    public DateOnly? FechaRevision { get; set; }

    public string? Descripcion { get; set; }

    public DateTime FechaRegistro { get; set; }

    public virtual Buses? Bus { get; set; }
}
