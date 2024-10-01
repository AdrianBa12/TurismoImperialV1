using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class MetodosPago
{
    public int IdMetodoPago { get; set; }

    public string? NombreMetodo { get; set; }

    public string? Descripcion { get; set; }
}
