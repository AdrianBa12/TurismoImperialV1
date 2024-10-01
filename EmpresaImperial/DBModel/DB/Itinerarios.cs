using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Itinerarios
{
    public int IdItinerario { get; set; }

    public int? IdRuta { get; set; }

    public int? IdEstacion { get; set; }

    public TimeOnly? HoraLlegada { get; set; }

    public TimeOnly? HoraSalida { get; set; }

    public int? OrdenParada { get; set; }

    public virtual Estaciones? IdEstacionNavigation { get; set; }

    public virtual Rutas? IdRutaNavigation { get; set; }
}
