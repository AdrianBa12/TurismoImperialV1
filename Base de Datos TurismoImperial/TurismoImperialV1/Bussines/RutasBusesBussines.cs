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
	public class RutasBusesBussines : IRutasBusesBussines
	{
		#region Declaracion de vcariables generales
		public readonly IRutasBusesRepository _IRutasBusesRepository = null;
		public readonly IMapper _Mapper;

		public RutasBusesBussines()
		{
		}
		#endregion

		#region constructor 
		public RutasBusesBussines(IMapper mapper)
		{
			_Mapper = mapper;
			_IRutasBusesRepository = new RutasBusesRepository();
		}
		#endregion

		public RutasBusesResponse Create(RutasBusesRequest entity)
		{
			RutasBuses au = _Mapper.Map<RutasBuses>(entity);
			au = _IRutasBusesRepository.Create(au);
			RutasBusesResponse res = _Mapper.Map<RutasBusesResponse>(au);
			return res;
		}

		public List<RutasBusesResponse> CreateMultiple(List<RutasBusesRequest> request)
		{
			List<RutasBuses> au = _Mapper.Map<List<RutasBuses>>(request);
			au = _IRutasBusesRepository.InsertMultiple(au);
			List<RutasBusesResponse> res = _Mapper.Map<List<RutasBusesResponse>>(au);
			return res;
		}

		public int Delete(object id)
		{
			return _IRutasBusesRepository.Delete(id);
		}

		public int deleteMultipleItems(List<RutasBusesRequest> request)
		{
			List<RutasBuses> au = _Mapper.Map<List<RutasBuses>>(request);
			int cantidad = _IRutasBusesRepository.DeleteMultipleItems(au);
			return cantidad;
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		public List<RutasBusesResponse> getAll()
		{
			List<RutasBuses> lsl = _IRutasBusesRepository.GetAll();
			List<RutasBusesResponse> res = _Mapper.Map<List<RutasBusesResponse>>(lsl);
			return res;
		}

		public List<RutasBusesResponse> getAutoComplete(string query)
		{
			throw new NotImplementedException();
		}

		public RutasBusesResponse getById(object id)
		{
			RutasBuses au = _IRutasBusesRepository.GetById(id);
			RutasBusesResponse res = _Mapper.Map<RutasBusesResponse>(au);
			return res;
		}

		public RutasBusesResponse Update(RutasBusesRequest entity)
		{
			RutasBuses au = _Mapper.Map<RutasBuses>(entity);
			au = _IRutasBusesRepository.Update(au);
			RutasBusesResponse res = _Mapper.Map<RutasBusesResponse>(au);
			return res;
		}

		public List<RutasBusesResponse> UpdateMultiple(List<RutasBusesRequest> request)
		{
			List<RutasBuses> au = _Mapper.Map<List<RutasBuses>>(request);
			au = _IRutasBusesRepository.UpdateMultiple(au);
			List<RutasBusesResponse> res = _Mapper.Map<List<RutasBusesResponse>>(au);
			return res;
		}
	}
}
