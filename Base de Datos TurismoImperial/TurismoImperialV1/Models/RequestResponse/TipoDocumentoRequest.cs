using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
	public class TipoDocumentoRequest
	{
		public string IdTipoDocumento { get; set; } = null!;

		public string? NombreDocumento { get; set; }

		public int? LongitudDocumento { get; set; }

		public string? RegexValidacion { get; set; }

		public string? OperadorId { get; set; }
	}
}
