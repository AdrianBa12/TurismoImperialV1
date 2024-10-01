using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Conductores
{
    public int IdConductor { get; set; }

    public string? Nombre { get; set; }

    public string? Apellidos { get; set; }

    public string? NumeroLicencia { get; set; }

    public DateOnly? FechaNacimiento { get; set; }

    public string? Telefono { get; set; }

    public DateOnly? FechaContratacion { get; set; }

    public string? EstadoConductor { get; set; }

    public int? IdVehiculo { get; set; }

    public DateTime FechaRegistro { get; set; }

    public virtual Vehiculos? IdVehiculoNavigation { get; set; }

    public virtual ICollection<Viajes> Viajes { get; set; } = new List<Viajes>();
}
