using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Estaciones
{
    public int EstacionId { get; set; }

    public string? Nombre { get; set; }

    public string? Direccion { get; set; }

    public string? Ciudad { get; set; }

    public virtual ICollection<Itinerarios> Itinerarios { get; set; } = new List<Itinerarios>();

    public virtual ICollection<Rutas> RutaIdEstacionDestinoNavigations { get; set; } = new List<Rutas>();

    public virtual ICollection<Rutas> RutaIdEstacionOrigenNavigations { get; set; } = new List<Rutas>();
}
