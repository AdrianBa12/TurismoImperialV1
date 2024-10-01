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
	public class RutasBussines : IRutasBussines
	{
		#region Declaracion de vcariables generales
		public readonly IRutasRepository _IRutasRepository = null;
		public readonly IMapper _Mapper;

		public RutasBussines()
		{
		}
		#endregion

		#region constructor 
		public RutasBussines(IMapper mapper)
		{
			_Mapper = mapper;
			_IRutasRepository = new RutasRepository();
		}
		#endregion

		public RutasResponse Create(RutasRequest entity)
		{
			Rutas au = _Mapper.Map<Rutas>(entity);
			au = _IRutasRepository.Create(au);
			RutasResponse res = _Mapper.Map<RutasResponse>(au);
			return res;
		}

		public List<RutasResponse> CreateMultiple(List<RutasRequest> request)
		{
			List<Rutas> au = _Mapper.Map<List<Rutas>>(request);
			au = _IRutasRepository.InsertMultiple(au);
			List<RutasResponse> res = _Mapper.Map<List<RutasResponse>>(au);
			return res;
		}

		public int Delete(object id)
		{
			return _IRutasRepository.Delete(id);
		}

		public int deleteMultipleItems(List<RutasRequest> request)
		{
			List<Rutas> au = _Mapper.Map<List<Rutas>>(request);
			int cantidad = _IRutasRepository.DeleteMultipleItems(au);
			return cantidad;
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		public List<RutasResponse> getAll()
		{
			List<Rutas> lsl = _IRutasRepository.GetAll();
			List<RutasResponse> res = _Mapper.Map<List<RutasResponse>>(lsl);
			return res;
		}

		public List<RutasResponse> getAutoComplete(string query)
		{
			throw new NotImplementedException();
		}

		public RutasResponse getById(object id)
		{
			Rutas au = _IRutasRepository.GetById(id);
			RutasResponse res = _Mapper.Map<RutasResponse>(au);
			return res;
		}

		public RutasResponse Update(RutasRequest entity)
		{
			Rutas au = _Mapper.Map<Rutas>(entity);
			au = _IRutasRepository.Update(au);
			RutasResponse res = _Mapper.Map<RutasResponse>(au);
			return res;
		}

		public List<RutasResponse> UpdateMultiple(List<RutasRequest> request)
		{
			List<Rutas> au = _Mapper.Map<List<Rutas>>(request);
			au = _IRutasRepository.UpdateMultiple(au);
			List<RutasResponse> res = _Mapper.Map<List<RutasResponse>>(au);
			return res;
		}
	}
}
