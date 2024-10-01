using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Opiniones
{
    public int IdOpinion { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdRutas { get; set; }

    public string? Comentarios { get; set; }

    public int? Calificacion { get; set; }

    public DateTime? FechaOpinion { get; set; }

    public virtual Rutas? IdRutasNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
