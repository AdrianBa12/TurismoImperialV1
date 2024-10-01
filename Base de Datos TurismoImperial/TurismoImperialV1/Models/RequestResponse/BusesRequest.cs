using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
	public class BusesRequest
	{
		public int IdBuses { get; set; }

		public string? Servicio { get; set; }

		public decimal? PrecioMinimo { get; set; }

		public decimal? PrecioPromedio { get; set; }

		public int? NumeroAsientos { get; set; }

		public int? IdConductor { get; set; }

		public int? IdRutas { get; set; }

		public DateTime? FechaSalida { get; set; }

		public DateTime? FechaLlegada { get; set; }
	}
}
