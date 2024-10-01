using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IBussines;
using Bussines;

using Models.RequestResponse;

using AutoMapper;
namespace API.Controllers
{
	[Route("[controller]")]
	[ApiController]
	//Autorización
	public class UsuarioController : ControllerBase
	{
		#region Declaracion de vcariables generales
		public readonly IUsuarioBussines? _IUsuarioBussines = null;
		public readonly IMapper _Mapper;
		#endregion

		#region constructor 
		public UsuarioController(IMapper mapper)
		{
			_Mapper = mapper;
			_IUsuarioBussines = new UsuarioBussines(_Mapper);
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
			List<UsuarioResponse> lsl = _IUsuarioBussines.getAll();
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
			UsuarioResponse res = _IUsuarioBussines.getById(id);
			return Ok(res);
		}

		/// <summary>
		/// Inserta un nuevo registro
		/// </summary>
		/// <param name="request">Registro a insertar</param>
		/// <returns>Retorna el registro insertado</returns>
		[HttpPost]
		public IActionResult Create([FromBody] UsuarioRequest request)
		{
			UsuarioResponse res = _IUsuarioBussines.Create(request);
			return Ok(res);
		}

		/// <summary>
		/// Actualiza un registro
		/// </summary>
		/// <param name="entity">registro a actualizar</param>
		/// <returns>retorna el registro Actualiza</returns>
		[HttpPut]
		public IActionResult Update([FromBody] UsuarioRequest request)
		{
			UsuarioResponse res = _IUsuarioBussines.Update(request);
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
			int res = _IUsuarioBussines.Delete(id);
			return Ok(res);
		}
		#endregion
	}
}
