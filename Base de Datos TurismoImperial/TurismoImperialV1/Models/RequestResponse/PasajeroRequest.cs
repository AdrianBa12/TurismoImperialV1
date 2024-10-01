using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
	public class PasajeroRequest
	{
		public int IdPasajero { get; set; }

		public string? IdTipoDocumento { get; set; }

		public string? NumeroDocumento { get; set; }

		public string? Nombres { get; set; }

		public string? ApellidoPaterno { get; set; }

		public string? ApellidoMaterno { get; set; }

		public DateOnly? FechaNacimiento { get; set; }

		public string? Nacionalidad { get; set; }

		public string? Genero { get; set; }

		public DateTime? FechaRegistro { get; set; }
	}
}
