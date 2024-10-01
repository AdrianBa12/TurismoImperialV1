using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Facturacion
{
    public int FacturaId { get; set; }

    public int? ReservaId { get; set; }

    public DateOnly? FechaFactura { get; set; }

    public decimal? MontoTotal { get; set; }

    public DateTime FechaRegistro { get; set; }

    public virtual Reservas? Reserva { get; set; }
}
