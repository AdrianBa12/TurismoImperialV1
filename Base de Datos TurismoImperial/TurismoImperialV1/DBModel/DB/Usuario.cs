using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string? Username { get; set; }

    public string? Contraseña { get; set; }

    public string? Cargo { get; set; }

    public int? IdPersona { get; set; }

    public virtual Persona? IdPersonaNavigation { get; set; }

    public virtual ICollection<Opiniones> Opiniones { get; set; } = new List<Opiniones>();

    public virtual ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
}
