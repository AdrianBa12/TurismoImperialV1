using AutoMapper;
using Bussines;
using IBussines;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.RequestResponse;

namespace API.Controllers
{
	[Route("[controller]")]
	[ApiController]

	//[Authorize]
	public class DetallesViajeController : ControllerBase
	{
		#region Declaracion de vcariables generales
		public readonly IDetallesViajeBussines _IDetallesViajeBussines = null;
		public readonly IMapper _Mapper;
		#endregion

		#region constructor 
		public DetallesViajeController(IMapper mapper)
		{
			_Mapper = mapper;
			_IDetallesViajeBussines = new DetallesViajeBussines(_Mapper);
		}
		#endregion

		#region crud methods
		/// <summary>
		/// Retorna todos los registros
		/// </summary>
		/// <returns>Retorna todos los registros</returns>
		[HttpGet]
		public IActionResult GetAll()
		{
			List<DetallesViajeResponse> lsl = _IDetallesViajeBussines.getAll();
			return Ok(lsl);
		}

		/// <summary>
		/// retorna el registro por Primary key
		/// </summary>
		/// <param name="id">PK</param>
		/// <returns>retorna el registro</returns>
		[HttpGet("{id}")]
		public IActionResult GetById(int id)
		{
			DetallesViajeResponse res = _IDetallesViajeBussines.getById(id);
			return Ok(res);
		}

		/// <summary>
		/// Inserta un nuevo registro
		/// </summary>
		/// <param name="request">Registro a insertar</param>
		/// <returns>Retorna el registro insertado</returns>
		[HttpPost]
		public IActionResult Create([FromBody] DetallesViajeRequest request)
		{
			DetallesViajeResponse res = _IDetallesViajeBussines.Create(request);
			return Ok(res);
		}

		/// <summary>
		/// Actualiza un registro
		/// </summary>
		/// <param name="entity">registro a actualizar</param>
		/// <returns>retorna el registro Actualiza</returns>
		[HttpPut]
		public IActionResult Update([FromBody] DetallesViajeRequest request)
		{
			DetallesViajeResponse res = _IDetallesViajeBussines.Update(request);
			return Ok(res);
		}

		/// <summary>
		/// Elimina un registro
		/// </summary>
		/// <param name="id">Valor del PK</param>
		/// <returns>Cantidad de registros afectados</returns>
		[HttpDelete("{id}")]
		public IActionResult delete(int id)
		{
			int res = _IDetallesViajeBussines.Delete(id);
			return Ok(res);
		}
		#endregion
	}
}
