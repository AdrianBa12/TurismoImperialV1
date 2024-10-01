using System;
using System.Collections.Generic;

namespace DBModel.DB;

public partial class Horarios
{
    public int HorarioId { get; set; }

    public int? ViajeId { get; set; }

    public TimeOnly? HorarioSalida { get; set; }

    public TimeOnly? HorarioLlegada { get; set; }

    public virtual Viajes? Viaje { get; set; }
}
