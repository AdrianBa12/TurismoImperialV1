using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Ciudad
{
    public int IdCiudad { get; set; }

    public string? Codigo { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<RutasBuses> RutasBuseCiudadDestinos { get; set; } = new List<RutasBuses>();

    public virtual ICollection<RutasBuses> RutasBuseCiudadOrigens { get; set; } = new List<RutasBuses>();

    public virtual ICollection<Terminal> Terminals { get; set; } = new List<Terminal>();
}
