using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Vehiculo
{
    public int IdVehiculo { get; set; }

    public string? Matricula { get; set; }

    public string? MarcaModelo { get; set; }

    public int? NumeroAsientos { get; set; }

    public string? EstadoVehiculo { get; set; }

    public virtual ICollection<Conductor> Conductors { get; set; } = new List<Conductor>();
}
