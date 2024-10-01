using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Username
{
    public int IdUsername { get; set; }

    public string Nombres { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string Usuario { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Contraseña { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }
}
