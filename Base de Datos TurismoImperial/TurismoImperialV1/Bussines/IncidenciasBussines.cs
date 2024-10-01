using AutoMapper;
using DBModel.DB;
using IBussines;
using IRepository;
using Models.RequestResponse;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines
{
	public class IncidenciasBussines : IIncidenciasBussines
	{
		#region Declaracion de vcariables generales
		public readonly IIncidenciasRepository _IIncidenciasRepository = null;
		public readonly IMapper _Mapper;

		public IncidenciasBussines()
		{
		}
		#endregion

		#region constructor 
		public IncidenciasBussines(IMapper mapper)
		{
			_Mapper = mapper;
			_IIncidenciasRepository = new IncidenciasRepository();
		}
		#endregion

		public IncidenciasResponse Create(IncidenciasRequest entity)
		{
			Incidencias au = _Mapper.Map<Incidencias>(entity);
			au = _IIncidenciasRepository.Create(au);
			IncidenciasResponse res = _Mapper.Map<IncidenciasResponse>(au);
			return res;
		}

		public List<IncidenciasResponse> CreateMultiple(List<IncidenciasRequest> request)
		{
			List<Incidencias> au = _Mapper.Map<List<Incidencias>>(request);
			au = _IIncidenciasRepository.InsertMultiple(au);
			List<IncidenciasResponse> res = _Mapper.Map<List<IncidenciasResponse>>(au);
			return res;
		}

		public int Delete(object id)
		{
			return _IIncidenciasRepository.Delete(id);
		}

		public int deleteMultipleItems(List<IncidenciasRequest> request)
		{
			List<Incidencias> au = _Mapper.Map<List<Incidencias>>(request);
			int cantidad = _IIncidenciasRepository.DeleteMultipleItems(au);
			return cantidad;
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		public List<IncidenciasResponse> getAll()
		{
			List<Incidencias> lsl = _IIncidenciasRepository.GetAll();
			List<IncidenciasResponse> res = _Mapper.Map<List<IncidenciasResponse>>(lsl);
			return res;
		}

		public List<IncidenciasResponse> getAutoComplete(string query)
		{
			throw new NotImplementedException();
		}

		public IncidenciasResponse getById(object id)
		{
			Incidencias au = _IIncidenciasRepository.GetById(id);
			IncidenciasResponse res = _Mapper.Map<IncidenciasResponse>(au);
			return res;
		}

		public IncidenciasResponse Update(IncidenciasRequest entity)
		{
			Incidencias au = _Mapper.Map<Incidencias>(entity);
			au = _IIncidenciasRepository.Update(au);
			IncidenciasResponse res = _Mapper.Map<IncidenciasResponse>(au);
			return res;
		}

		public List<IncidenciasResponse> UpdateMultiple(List<IncidenciasRequest> request)
		{
			List<Incidencias> au = _Mapper.Map<List<Incidencias>>(request);
			au = _IIncidenciasRepository.UpdateMultiple(au);
			List<IncidenciasResponse> res = _Mapper.Map<List<IncidenciasResponse>>(au);
			return res;
		}
	}
}
