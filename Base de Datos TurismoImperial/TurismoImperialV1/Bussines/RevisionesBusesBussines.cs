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
	public class RevisionesBusesBussines : IRevisionesBusesBussines
	{
		#region Declaracion de vcariables generales
		public readonly IRevisionesBusesRepository _IRevisionesBusesRepository = null;
		public readonly IMapper _Mapper;

		public RevisionesBusesBussines()
		{
		}
		#endregion

		#region constructor 
		public RevisionesBusesBussines(IMapper mapper)
		{
			_Mapper = mapper;
			_IRevisionesBusesRepository = new RevisionesBusesRepository();
		}
		#endregion

		public RevisionesBusesResponse Create(RevisionesBusesRequest entity)
		{
			RevisionesBuses au = _Mapper.Map<RevisionesBuses>(entity);
			au = _IRevisionesBusesRepository.Create(au);
			RevisionesBusesResponse res = _Mapper.Map<RevisionesBusesResponse>(au);
			return res;
		}

		public List<RevisionesBusesResponse> CreateMultiple(List<RevisionesBusesRequest> request)
		{
			List<RevisionesBuses> au = _Mapper.Map<List<RevisionesBuses>>(request);
			au = _IRevisionesBusesRepository.InsertMultiple(au);
			List<RevisionesBusesResponse> res = _Mapper.Map<List<RevisionesBusesResponse>>(au);
			return res;
		}

		public int Delete(object id)
		{
			return _IRevisionesBusesRepository.Delete(id);
		}

		public int deleteMultipleItems(List<RevisionesBusesRequest> request)
		{
			List<RevisionesBuses> au = _Mapper.Map<List<RevisionesBuses>>(request);
			int cantidad = _IRevisionesBusesRepository.DeleteMultipleItems(au);
			return cantidad;
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		public List<RevisionesBusesResponse> getAll()
		{
			List<RevisionesBuses> lsl = _IRevisionesBusesRepository.GetAll();
			List<RevisionesBusesResponse> res = _Mapper.Map<List<RevisionesBusesResponse>>(lsl);
			return res;
		}

		public List<RevisionesBusesResponse> getAutoComplete(string query)
		{
			throw new NotImplementedException();
		}

		public RevisionesBusesResponse getById(object id)
		{
			RevisionesBuses au = _IRevisionesBusesRepository.GetById(id);
			RevisionesBusesResponse res = _Mapper.Map<RevisionesBusesResponse>(au);
			return res;
		}

		public RevisionesBusesResponse Update(RevisionesBusesRequest entity)
		{
			RevisionesBuses au = _Mapper.Map<RevisionesBuses>(entity);
			au = _IRevisionesBusesRepository.Update(au);
			RevisionesBusesResponse res = _Mapper.Map<RevisionesBusesResponse>(au);
			return res;
		}

		public List<RevisionesBusesResponse> UpdateMultiple(List<RevisionesBusesRequest> request)
		{
			List<RevisionesBuses> au = _Mapper.Map<List<RevisionesBuses>>(request);
			au = _IRevisionesBusesRepository.UpdateMultiple(au);
			List<RevisionesBusesResponse> res = _Mapper.Map<List<RevisionesBusesResponse>>(au);
			return res;
		}
	}
}
