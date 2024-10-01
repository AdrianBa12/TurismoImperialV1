using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
    public class EstadoPagoRequest
    {
		public string IdEstadoPago { get; set; } = null!;

		public string? Descripcion { get; set; }
	}
}
