using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Reserva
{
    public int IdReserva { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdRutas { get; set; }

    public DateTime? FechaReserva { get; set; }

    public string? EstadoReservaId { get; set; }

    public int? NumeroAsientos { get; set; }

    public decimal? PrecioTotal { get; set; }

    public string? CodigoBoleto { get; set; }

    public virtual EstadoReserva? EstadoReserva { get; set; }

    public virtual Rutas? IdRutasNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }

    public virtual ICollection<Pagos> Pagos { get; set; } = new List<Pagos>();
}
