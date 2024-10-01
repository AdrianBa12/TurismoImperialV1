using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
	public class EmpleadosResponse
	{
		public int IdEmpleados { get; set; }

		public string? Nombre { get; set; }

		public string? Apellido { get; set; }

		public int? IdAgencia { get; set; }

		public int? IdRol { get; set; }

		public DateTime? FechaRegistro { get; set; }
	}
}
