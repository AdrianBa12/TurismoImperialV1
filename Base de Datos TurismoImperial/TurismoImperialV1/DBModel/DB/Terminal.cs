using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Terminal
{
    public int IdTerminal { get; set; }

    public string? Nombre { get; set; }

    public int? IdCiudad { get; set; }

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public DateOnly? CreatedAt { get; set; }

    public virtual ICollection<Caja> Cajas { get; set; } = new List<Caja>();

    public virtual ICollection<DetallesViaje> DetallesViajeTerminalLlegada { get; set; } = new List<DetallesViaje>();

    public virtual ICollection<DetallesViaje> DetallesViajeTerminalSalida { get; set; } = new List<DetallesViaje>();

    public virtual Ciudad? IdCiudadNavigation { get; set; }
}
