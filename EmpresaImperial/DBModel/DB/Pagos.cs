using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Pagos
{
    public int IdTransaccion { get; set; }

    public int? IdReserva { get; set; }

    public string? MetodoPago { get; set; }

    public DateTime? FechaPago { get; set; }

    public string? EstadoPago { get; set; }

    public decimal? MontoPagado { get; set; }

    public virtual Reservas? IdReservaNavigation { get; set; }
}
