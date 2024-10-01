using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Asiento
{
    public string IdAsiento { get; set; } = null!;

    public string? NumeroAsiento { get; set; }

    public string? Tarifa { get; set; }

    public int? Nivel { get; set; }

    public int? NumeroPiso { get; set; }

    public decimal? PrecioPen { get; set; }

    public string? ScheduleId { get; set; }

    public string? TipoAsiento { get; set; }

    public bool? Desactivado { get; set; }

    public string? AsientoReservadoId { get; set; }
}
