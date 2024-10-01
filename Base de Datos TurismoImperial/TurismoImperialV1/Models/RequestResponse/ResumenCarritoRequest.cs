using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestResponse
{
	public class ResumenCarritoRequest
	{
		public int IdResumenCarrito { get; set; }

		public decimal? PrecioTotalPen { get; set; }

		public decimal? PrecioTotalUsd { get; set; }
	}
}
