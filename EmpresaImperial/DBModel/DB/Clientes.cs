using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Clientes
{
    public int ClienteId { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Email { get; set; }

    public string? Telefono { get; set; }

    public string? DocumentoId { get; set; }

    public DateTime FechaRegistro { get; set; }
}
