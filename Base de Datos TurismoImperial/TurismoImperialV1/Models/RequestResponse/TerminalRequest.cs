using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
	public class TerminalRequest
	{
		public int IdTerminal { get; set; }

		public string? Nombre { get; set; }

		public int? IdCiudad { get; set; }

		public string? Direccion { get; set; }

		public string? Telefono { get; set; }

		public DateOnly? CreatedAt { get; set; }
	}
}
