using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class DetallesViaje
{
    public int IdDetallesViaje { get; set; }

    public int? IdRutasBuses { get; set; }

    public TimeOnly? PrimeraSalida { get; set; }

    public TimeOnly? UltimaSalida { get; set; }

    public decimal? PrecioMinimo { get; set; }

    public decimal? PrecioPromedio { get; set; }

    public TimeOnly? DuracionMinima { get; set; }

    public TimeOnly? DuracionPromedio { get; set; }

    public int? TerminalSalidaId { get; set; }

    public int? TerminalLlegadaId { get; set; }

    public virtual RutasBuses? IdRutasBusesNavigation { get; set; }

    public virtual Terminal? TerminalLlegada { get; set; }

    public virtual Terminal? TerminalSalida { get; set; }
}
