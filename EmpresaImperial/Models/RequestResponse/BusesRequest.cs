using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
	public class BusesRequest
	{
		public int BusId { get; set; }

		public string? NumeroBus { get; set; }

		public int? Capacidad { get; set; }

		public string? Estado { get; set; }

		public DateTime FechaRegistro { get; set; }
	}
}
