using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
	public class EstadoReservaResponse
	{
		public string IdEstadoReserva { get; set; } = null!;

		public string? Descripcion { get; set; }
	}
}
