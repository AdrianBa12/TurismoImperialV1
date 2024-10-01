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
	public class ResumenCarritoController : ControllerBase
	{
		#region Declaracion de vcariables generales
		public readonly IResumenCarritoBussines _IResumenCarritoBussines = null;
		public readonly IMapper _Mapper;
		#endregion

		#region constructor 
		public ResumenCarritoController(IMapper mapper)
		{
			_Mapper = mapper;
			_IResumenCarritoBussines = new ResumenCarritoBussines(_Mapper);
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
			List<ResumenCarritoResponse> lsl = _IResumenCarritoBussines.getAll();
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
			ResumenCarritoResponse res = _IResumenCarritoBussines.getById(id);
			return Ok(res);
		}

		/// <summary>
		/// Inserta un nuevo registro
		/// </summary>
		/// <param name="request">Registro a insertar</param>
		/// <returns>Retorna el registro insertado</returns>
		[HttpPost]
		public IActionResult Create([FromBody] ResumenCarritoRequest request)
		{
			ResumenCarritoResponse res = _IResumenCarritoBussines.Create(request);
			return Ok(res);
		}

		/// <summary>
		/// Actualiza un registro
		/// </summary>
		/// <param name="entity">registro a actualizar</param>
		/// <returns>retorna el registro Actualiza</returns>
		[HttpPut]
		public IActionResult Update([FromBody] ResumenCarritoRequest request)
		{
			ResumenCarritoResponse res = _IResumenCarritoBussines.Update(request);
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
			int res = _IResumenCarritoBussines.Delete(id);
			return Ok(res);
		}
		#endregion
	}
}
