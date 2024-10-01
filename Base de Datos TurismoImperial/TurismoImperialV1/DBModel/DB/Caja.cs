using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Caja
{
    public int IdCaja { get; set; }

    public DateOnly? Fecha { get; set; }

    public bool? Estado { get; set; }

    public decimal? MontoApertura { get; set; }

    public decimal? CierreOptimo { get; set; }

    public decimal? CierreReal { get; set; }

    public string? Codigo { get; set; }

    public string? Observaciones { get; set; }

    public decimal? Gastos { get; set; }

    public int? IdAgencia { get; set; }

    public int? IdTerminal { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public virtual Agencia? IdAgenciaNavigation { get; set; }

    public virtual Terminal? IdTerminalNavigation { get; set; }
}
