using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
	public class ComprobantesRequest
	{
		public int IdComprobante { get; set; }

		public int? IdCliente { get; set; }

		public string? NumeroComprobante { get; set; }

		public string? TipoComprobante { get; set; }

		public DateTime? FechaEmision { get; set; }

		public decimal? MontoTotal { get; set; }

		public int? IdPago { get; set; }
	}
}
