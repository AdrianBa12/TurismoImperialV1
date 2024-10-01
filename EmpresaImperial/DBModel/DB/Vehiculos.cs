using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Vehiculos
{
    public int IdVehiculo { get; set; }

    public string? Matricula { get; set; }

    public string? MarcaModelo { get; set; }

    public string? TipoVehiculo { get; set; }

    public int? NumeroAsientos { get; set; }

    public string? EstadoVehiculo { get; set; }

    public virtual ICollection<Asientos> Asientos { get; set; } = new List<Asientos>();

    public virtual ICollection<Conductores> Conductores { get; set; } = new List<Conductores>();

    public virtual ICollection<HistorialMantenimiento> HistorialMantenimientos { get; set; } = new List<HistorialMantenimiento>();
}
