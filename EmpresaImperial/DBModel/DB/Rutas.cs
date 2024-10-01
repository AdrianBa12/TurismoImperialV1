using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Rutas
{
    public int IdRuta { get; set; }

    public int? IdEstacionOrigen { get; set; }

    public int? IdEstacionDestino { get; set; }

    public TimeOnly? DuracionEstimada { get; set; }

    public decimal? PrecioBase { get; set; }

    public TimeOnly? HorarioSalida { get; set; }

    public TimeOnly? HorarioLlegada { get; set; }

    public int? DisponibilidadAsientos { get; set; }

    public virtual Estaciones? IdEstacionDestinoNavigation { get; set; }

    public virtual Estaciones? IdEstacionOrigenNavigation { get; set; }

    public virtual ICollection<Itinerarios> Itinerarios { get; set; } = new List<Itinerarios>();

    public virtual ICollection<Opiniones> Opiniones { get; set; } = new List<Opiniones>();

    public virtual ICollection<Precios> Precios { get; set; } = new List<Precios>();

    public virtual ICollection<Reservas> Reservas { get; set; } = new List<Reservas>();

    public virtual ICollection<Viajes> Viajes { get; set; } = new List<Viajes>();
}
