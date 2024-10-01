using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Comprobantes
{
    public int IdComprobante { get; set; }

    public int? IdCliente { get; set; }

    public string? NumeroComprobante { get; set; }

    public string? TipoComprobante { get; set; }

    public DateTime? FechaEmision { get; set; }

    public decimal? MontoTotal { get; set; }

    public int? IdPago { get; set; }

    public virtual Cliente? IdClienteNavigation { get; set; }

    public virtual Pagos? IdPagoNavigation { get; set; }
}
