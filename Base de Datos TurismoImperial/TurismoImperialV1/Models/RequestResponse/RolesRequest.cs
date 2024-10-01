using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
	public class RolesRequest
	{
		public int IdRoles { get; set; }

		public string? NombreRol { get; set; }

		public DateTime? FechaRegistro { get; set; }
	}
}
