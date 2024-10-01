using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
	public class ReservaRequest
	{
		public int IdReserva { get; set; }

		public int? IdUsuario { get; set; }

		public int? IdRutas { get; set; }

		public DateTime? FechaReserva { get; set; }

		public string? EstadoReservaId { get; set; }

		public int? NumeroAsientos { get; set; }

		public decimal? PrecioTotal { get; set; }

		public string? CodigoBoleto { get; set; }
	}
}
