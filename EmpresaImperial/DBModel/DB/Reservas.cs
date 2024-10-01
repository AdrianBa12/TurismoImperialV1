using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Reservas
{
    public int IdReserva { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdRuta { get; set; }

    public DateTime? FechaReserva { get; set; }

    public string? EstadoReserva { get; set; }

    public int? NumeroAsientos { get; set; }

    public decimal? PrecioTotal { get; set; }

    public string? CodigoBoleto { get; set; }

    public virtual ICollection<Boletos> Boletos { get; set; } = new List<Boletos>();

    public virtual ICollection<Descuentos> Descuentos { get; set; } = new List<Descuentos>();

    public virtual ICollection<Facturacion> Facturacions { get; set; } = new List<Facturacion>();

    public virtual ICollection<HistorialCambios> HistorialCambios { get; set; } = new List<HistorialCambios>();

    public virtual Rutas? IdRutaNavigation { get; set; }

    public virtual Usuarios? IdUsuarioNavigation { get; set; }

    public virtual ICollection<Pagos> Pagos { get; set; } = new List<Pagos>();

    public virtual ICollection<Reembolsos> Reembolsos { get; set; } = new List<Reembolsos>();
}
