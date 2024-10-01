using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Agencia
{
    public int IdAgencia { get; set; }

    public string? Codigo { get; set; }

    public string? Nombre { get; set; }

    public string? Direccion { get; set; }

    public bool? Estado { get; set; }

    public DateOnly? CreatedAt { get; set; }

    public virtual ICollection<Caja> Cajas { get; set; } = new List<Caja>();
}
