using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Empleados
{
    public int IdEmpleados { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public int? IdAgencia { get; set; }

    public int? IdRol { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual Roles? IdRolNavigation { get; set; }
}
