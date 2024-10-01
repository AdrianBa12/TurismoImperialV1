using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
	public class DetallesViajeResponse
	{
		public int IdDetallesViaje { get; set; }

		public int? IdRutasBuses { get; set; }

		public TimeOnly? PrimeraSalida { get; set; }

		public TimeOnly? UltimaSalida { get; set; }

		public decimal? PrecioMinimo { get; set; }

		public decimal? PrecioPromedio { get; set; }

		public TimeOnly? DuracionMinima { get; set; }

		public TimeOnly? DuracionPromedio { get; set; }

		public int? TerminalSalidaId { get; set; }

		public int? TerminalLlegadaId { get; set; }
	}
}
