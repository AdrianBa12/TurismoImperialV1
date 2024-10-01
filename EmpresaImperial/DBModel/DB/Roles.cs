using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Roles
{
    public int IdRol { get; set; }

    public string? NombreRol { get; set; }

    public virtual ICollection<Administradores> Administradores { get; set; } = new List<Administradores>();

    public virtual ICollection<Empleados> Empleados { get; set; } = new List<Empleados>();

    public virtual ICollection<Usuarios> IdUsuarios { get; set; } = new List<Usuarios>();
}
