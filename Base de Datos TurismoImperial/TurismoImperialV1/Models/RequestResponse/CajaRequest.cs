using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
	public class CajaRequest
	{
		public int IdCaja { get; set; }

		public DateOnly? Fecha { get; set; }

		public bool? Estado { get; set; }

		public decimal? MontoApertura { get; set; }

		public decimal? CierreOptimo { get; set; }

		public decimal? CierreReal { get; set; }

		public string? Codigo { get; set; }

		public string? Observaciones { get; set; }

		public decimal? Gastos { get; set; }

		public int? IdAgencia { get; set; }

		public int? IdTerminal { get; set; }

		public DateTime? FechaCreacion { get; set; }
	}
}
