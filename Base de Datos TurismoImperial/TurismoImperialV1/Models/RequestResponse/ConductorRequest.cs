using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
	public class ConductorRequest
	{
		public int IdConductor { get; set; }

		public string? Nombre { get; set; }

		public string? Apellidos { get; set; }

		public string? NumeroLicencia { get; set; }

		public DateOnly? FechaNacimiento { get; set; }

		public string? Telefono { get; set; }

		public DateOnly? FechaContratacion { get; set; }

		public string? EstadoConductor { get; set; }

		public int? IdVehiculo { get; set; }

		public DateTime? FechaRegistro { get; set; }
	}
}
