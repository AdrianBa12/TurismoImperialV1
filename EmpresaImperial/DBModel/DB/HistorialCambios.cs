using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class HistorialCambios
{
    public int IdCambio { get; set; }

    public int? IdReserva { get; set; }

    public string? CambioDescripcion { get; set; }

    public DateTime? FechaCambio { get; set; }

    public virtual Reservas? IdReservaNavigation { get; set; }
}
