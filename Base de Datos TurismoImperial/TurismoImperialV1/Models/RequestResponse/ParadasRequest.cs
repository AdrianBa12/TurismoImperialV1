using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
	public class ParadasRequest
	{
		public int IdParadas { get; set; }

		public int? IdViaje { get; set; }

		public string? Direccion { get; set; }

		public string? NombreCiudad { get; set; }

		public DateOnly? Fecha { get; set; }
	}
}
