using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
	public class AsientoRequest
	{
		public string IdAsiento { get; set; } = null!;

		public string? NumeroAsiento { get; set; }

		public string? Tarifa { get; set; }

		public int? Nivel { get; set; }

		public int? NumeroPiso { get; set; }

		public decimal? PrecioPen { get; set; }

		public string? ScheduleId { get; set; }

		public string? TipoAsiento { get; set; }

		public bool? Desactivado { get; set; }

		public string? AsientoReservadoId { get; set; }
	}
}
