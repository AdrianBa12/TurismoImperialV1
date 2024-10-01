using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Boletos
{
    public int IdBoleto { get; set; }

    public int? IdReserva { get; set; }

    public int? IdAsiento { get; set; }

    public string? CodigoBoleto { get; set; }

    public DateTime? FechaEmision { get; set; }

    public virtual Reservas? IdReservaNavigation { get; set; }
}
