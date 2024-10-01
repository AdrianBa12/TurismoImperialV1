using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Empleados
{
    public int EmpleadoId { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public int? RolId { get; set; }

    public DateTime FechaRegistro { get; set; }

    public virtual Roles? Rol { get; set; }
}
