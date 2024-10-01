using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
	public class RutasResponse
	{
		public int IdRutas { get; set; }

		public string? CiudadOrigen { get; set; }

		public string? CiudadId { get; set; }

		public string? CiudadSeoId { get; set; }

		public string? CiudadDestino { get; set; }

		public string? DestinoId { get; set; }

		public string? DestinoSeoId { get; set; }
	}
}
