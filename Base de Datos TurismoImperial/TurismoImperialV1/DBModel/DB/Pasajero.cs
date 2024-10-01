using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Pasajero
{
    public int IdPasajero { get; set; }

    public string? IdTipoDocumento { get; set; }

    public string? NumeroDocumento { get; set; }

    public string? Nombres { get; set; }

    public string? ApellidoPaterno { get; set; }

    public string? ApellidoMaterno { get; set; }

    public DateOnly? FechaNacimiento { get; set; }

    public string? Nacionalidad { get; set; }

    public string? Genero { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual TipoDocumento? IdTipoDocumentoNavigation { get; set; }
}
