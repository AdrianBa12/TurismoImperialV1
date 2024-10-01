using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
	public class OpinionesResponse
	{
		public int IdOpinion { get; set; }

		public int? IdUsuario { get; set; }

		public int? IdRutas { get; set; }

		public string? Comentarios { get; set; }

		public int? Calificacion { get; set; }

		public DateTime? FechaOpinion { get; set; }
	}
}
