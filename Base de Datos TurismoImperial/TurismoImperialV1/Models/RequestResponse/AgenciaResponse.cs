using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
	public class AgenciaResponse
	{
		public int IdAgencia { get; set; }

		public string? Codigo { get; set; }

		public string? Nombre { get; set; }

		public string? Direccion { get; set; }

		public bool? Estado { get; set; }

		public DateOnly? CreatedAt { get; set; }
	}
}
