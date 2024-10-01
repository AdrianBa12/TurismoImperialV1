using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Usuarios
{
    public int IdUsuario { get; set; }

    public string? Nombre { get; set; }

    public string? Apellidos { get; set; }

    public string? CorreoElectronico { get; set; }

    public string? Contrasena { get; set; }

    public string? Telefono { get; set; }

    public string? Direccion { get; set; }

    public string? TipoUsuario { get; set; }

    public DateTime FechaRegistro { get; set; }

    public virtual ICollection<Opiniones> Opiniones { get; set; } = new List<Opiniones>();

    public virtual ICollection<Reservas> Reservas { get; set; } = new List<Reservas>();

    public virtual ICollection<Roles> IdRols { get; set; } = new List<Roles>();
}
