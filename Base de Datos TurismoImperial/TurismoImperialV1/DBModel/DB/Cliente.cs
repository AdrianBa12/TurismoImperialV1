using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string? Nombres { get; set; }

    public string? Apellidos { get; set; }

    public string? TipoDocumento { get; set; }

    public string? NumeroDocumento { get; set; }

    public string? RazonSocial { get; set; }

    public string? Email { get; set; }

    public string? Telefono { get; set; }

    public int? Edad { get; set; }

    public string? Direccion { get; set; }

    public bool? Estado { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public virtual ICollection<Comprobantes> Comprobantes { get; set; } = new List<Comprobantes>();
}
