using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
	public class RevisionesBusesRequest
	{
		public int IdRevicionesBuses { get; set; }

		public int? IdBus { get; set; }

		public DateOnly? FechaRevision { get; set; }

		public string? Descripcion { get; set; }

		public DateTime? FechaRegistro { get; set; }
	}
}
