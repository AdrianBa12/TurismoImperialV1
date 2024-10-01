using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
	public class RutasBusesRequest
	{
		public int IdRutasBuses { get; set; }

		public int? CiudadOrigenId { get; set; }

		public string? Origen { get; set; }

		public int? CiudadDestinoId { get; set; }

		public string? Destino { get; set; }

		public int? TotalBusesDiarios { get; set; }

		public string? DuracionMin { get; set; }

		public TimeOnly? PrimeraHoraSalida { get; set; }

		public TimeOnly? UltimaHoraSalida { get; set; }

		public decimal? PrecioMinimo { get; set; }

		public decimal? PrecioPromedio { get; set; }

		public string? DuracionPromedio { get; set; }

		public int? DistanciaKm { get; set; }

		public string? TerminalSaliente { get; set; }

		public string? TerminalEntrante { get; set; }

		public bool? Popular { get; set; }

		
	}
}
