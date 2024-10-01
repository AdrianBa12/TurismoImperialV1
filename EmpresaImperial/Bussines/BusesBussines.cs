using AutoMapper;
using IBussines;
using IRepository;
using Repository;
using DBModel.DB;
using Models.RequestResponse;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines
{
    public class BusesBussines : IBusesBussines

    {
		#region Declaracion de vcariables generales
		public readonly IBusesRepository _IBusesRepository = null;
		public readonly IMapper _Mapper;

		public BusesBussines()
		{
		}
		#endregion

		#region constructor 
		public BusesBussines(IMapper mapper)
		{
			_Mapper = mapper;
			_IBusesRepository = new BusesRepository();
		}
		#endregion

		public BusesResponse Create(BusesRequest entity)
		{
			Buses au = _Mapper.Map<Buses>(entity);
			au = _IBusesRepository.Create(au);
			BusesResponse res = _Mapper.Map<BusesResponse>(au);
			return res;
		}

		public List<BusesResponse> CreateMultiple(List<BusesRequest> request)
		{
			List<Buses> au = _Mapper.Map<List<Buses>>(request);
			au = _IBusesRepository.InsertMultiple(au);
			List<BusesResponse> res = _Mapper.Map<List<BusesResponse>>(au);
			return res;
		}

		public int Delete(object id)
		{
			return _IBusesRepository.Delete(id);
		}

		public int deleteMultipleItems(List<BusesRequest> request)
		{
			List<Buses> au = _Mapper.Map<List<Buses>>(request);
			int cantidad = _IBusesRepository.DeleteMultipleItems(au);
			return cantidad;
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		public List<BusesResponse> getAll()
		{
			List<Buses> lsl = _IBusesRepository.GetAll();
			List<BusesResponse> res = _Mapper.Map<List<BusesResponse>>(lsl);
			return res;
		}

		public List<BusesResponse> getAutoComplete(string query)
		{
			throw new NotImplementedException();
		}

		public BusesResponse getById(object id)
		{
			Buses au = _IBusesRepository.GetById(id);
			BusesResponse res = _Mapper.Map<BusesResponse>(au);
			return res;
		}

		public BusesResponse Update(BusesRequest entity)
		{
			Buses au = _Mapper.Map<Buses>(entity);
			au = _IBusesRepository.Update(au);
			BusesResponse res = _Mapper.Map<BusesResponse>(au);
			return res;
		}

		public List<BusesResponse> UpdateMultiple(List<BusesRequest> request)
		{
			List<Buses> au = _Mapper.Map<List<Buses>>(request);
			au = _IBusesRepository.UpdateMultiple(au);
			List<BusesResponse> res = _Mapper.Map<List<BusesResponse>>(au);
			return res;
		}
	}
}
