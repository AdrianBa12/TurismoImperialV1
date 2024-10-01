using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class ResumenCarrito
{
    public int IdResumenCarrito { get; set; }

    public decimal? PrecioTotalPen { get; set; }

    public decimal? PrecioTotalUsd { get; set; }
}
