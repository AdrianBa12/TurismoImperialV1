using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Rutas
{
    public int IdRutas { get; set; }

    public string? CiudadOrigen { get; set; }

    public string? CiudadId { get; set; }

    public string? CiudadSeoId { get; set; }

    public string? CiudadDestino { get; set; }

    public string? DestinoId { get; set; }

    public string? DestinoSeoId { get; set; }

    public virtual ICollection<Buses> Buses { get; set; } = new List<Buses>();

    public virtual ICollection<Opiniones> Opiniones { get; set; } = new List<Opiniones>();

    public virtual ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();

    public virtual ICollection<Viajes> Viajes { get; set; } = new List<Viajes>();
}
