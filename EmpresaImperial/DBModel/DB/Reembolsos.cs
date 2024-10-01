using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Reembolsos
{
    public int ReembolsoId { get; set; }

    public int? ReservaId { get; set; }

    public decimal? Monto { get; set; }

    public DateOnly? FechaReembolso { get; set; }

    public DateTime FechaRegistro { get; set; }

    public virtual Reservas? Reserva { get; set; }
}
