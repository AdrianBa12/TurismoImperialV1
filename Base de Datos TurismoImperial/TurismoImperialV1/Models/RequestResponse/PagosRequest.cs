using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
	public class PagosRequest
	{
		public int IdPagos { get; set; }

		public int? IdReserva { get; set; }

		public string? MetodoPagoId { get; set; }

		public DateTime? FechaPago { get; set; }

		public string? EstadoPagoId { get; set; }

		public decimal? MontoPagado { get; set; }
	}
}
