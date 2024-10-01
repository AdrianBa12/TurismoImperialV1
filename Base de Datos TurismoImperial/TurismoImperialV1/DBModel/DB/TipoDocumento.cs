using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class TipoDocumento
{
    public string IdTipoDocumento { get; set; } = null!;

    public string? NombreDocumento { get; set; }

    public int? LongitudDocumento { get; set; }

    public string? RegexValidacion { get; set; }

    public string? OperadorId { get; set; }

    public virtual ICollection<Pasajero> Pasajeros { get; set; } = new List<Pasajero>();
}
