using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
	public class IncidenciasRequest
	{
		public int IncidenciaId { get; set; }

		public int? IdBus { get; set; }

		public int? IdViaje { get; set; }

		public string? Descripcion { get; set; }

		public DateOnly? Fecha { get; set; }

		public DateTime? FechaRegistro { get; set; }
	}
}
