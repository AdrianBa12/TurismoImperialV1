using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Roles
{
    public int IdRoles { get; set; }

    public string? NombreRol { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<Empleados> Empleados { get; set; } = new List<Empleados>();
}
