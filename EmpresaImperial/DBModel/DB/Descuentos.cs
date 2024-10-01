using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Descuentos
{
    public int DescuentoId { get; set; }

    public int? PromocionId { get; set; }

    public int? ReservaId { get; set; }

    public decimal? MontoDescuento { get; set; }

    public DateTime FechaRegistro { get; set; }

    public virtual Promociones? Promocion { get; set; }

    public virtual Reservas? Reserva { get; set; }
}
