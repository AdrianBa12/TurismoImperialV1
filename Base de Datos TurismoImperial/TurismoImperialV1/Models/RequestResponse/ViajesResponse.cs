using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
	public class ViajesResponse
	{
		public int IdViajes { get; set; }

		public string? Servicio { get; set; }

		public decimal? PrecioMinimo { get; set; }

		public int? IdBus { get; set; }

		public string? NumeroAsientos { get; set; }

		public int? IdConductor { get; set; }

		public int? IdRutas { get; set; }

		public DateTime? FechaSalida { get; set; }

		public DateTime? FechaLlegada { get; set; }
	}
}
