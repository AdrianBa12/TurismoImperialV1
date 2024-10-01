using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
	public class EstadoPagoResponse
	{
		public string IdEstadoPago { get; set; } = null!;

		public string? Descripcion { get; set; }
	}
}
