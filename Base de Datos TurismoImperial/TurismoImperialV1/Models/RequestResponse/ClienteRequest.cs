﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
	public class ClienteRequest
	{
		public int IdCliente { get; set; }

		public string? Nombres { get; set; }

		public string? Apellidos { get; set; }

		public string? TipoDocumento { get; set; }

		public string? NumeroDocumento { get; set; }

		public string? RazonSocial { get; set; }

		public string? Email { get; set; }

		public string? Telefono { get; set; }

		public int? Edad { get; set; }

		public string? Direccion { get; set; }

		public bool? Estado { get; set; }

		public DateTime? FechaCreacion { get; set; }
	}
}
