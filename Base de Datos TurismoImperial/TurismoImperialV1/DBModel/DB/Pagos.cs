using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Pagos
{
    public int IdPagos { get; set; }

    public int? IdReserva { get; set; }

    public string? MetodoPagoId { get; set; }

    public DateTime? FechaPago { get; set; }

    public string? EstadoPagoId { get; set; }

    public decimal? MontoPagado { get; set; }

    public virtual ICollection<Comprobantes> Comprobantes { get; set; } = new List<Comprobantes>();

    public virtual EstadoPago? EstadoPago { get; set; }

    public virtual Reserva? IdReservaNavigation { get; set; }

    public virtual MetodoPago? MetodoPago { get; set; }
}
