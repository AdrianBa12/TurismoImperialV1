using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class EstadoReserva
{
    public string IdEstadoReserva { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
}
