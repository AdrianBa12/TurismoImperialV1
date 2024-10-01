using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
	public class VehiculoResponse
	{
		public int IdVehiculo { get; set; }

		public string? Matricula { get; set; }

		public string? MarcaModelo { get; set; }

		public int? NumeroAsientos { get; set; }

		public string? EstadoVehiculo { get; set; }
	}
}
