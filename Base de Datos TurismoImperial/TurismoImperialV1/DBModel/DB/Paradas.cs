using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Paradas
{
    public int IdParadas { get; set; }

    public int? IdViaje { get; set; }

    public string? Direccion { get; set; }

    public string? NombreCiudad { get; set; }

    public DateOnly? Fecha { get; set; }
}
