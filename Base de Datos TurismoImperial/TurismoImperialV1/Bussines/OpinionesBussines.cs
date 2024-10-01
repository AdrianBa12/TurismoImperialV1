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
	public class OpinionesBussines : IOpinionesBussines
	{
		#region Declaracion de vcariables generales
		public readonly IOpinionesRepository _IOpinionesRepository = null;
		public readonly IMapper _Mapper;

		public OpinionesBussines()
		{
		}
		#endregion

		#region constructor 
		public OpinionesBussines(IMapper mapper)
		{
			_Mapper = mapper;
			_IOpinionesRepository = new OpinionesRepository();
		}
		#endregion

		public OpinionesResponse Create(OpinionesRequest entity)
		{
			Opiniones au = _Mapper.Map<Opiniones>(entity);
			au = _IOpinionesRepository.Create(au);
			OpinionesResponse res = _Mapper.Map<OpinionesResponse>(au);
			return res;
		}

		public List<OpinionesResponse> CreateMultiple(List<OpinionesRequest> request)
		{
			List<Opiniones> au = _Mapper.Map<List<Opiniones>>(request);
			au = _IOpinionesRepository.InsertMultiple(au);
			List<OpinionesResponse> res = _Mapper.Map<List<OpinionesResponse>>(au);
			return res;
		}

		public int Delete(object id)
		{
			return _IOpinionesRepository.Delete(id);
		}

		public int deleteMultipleItems(List<OpinionesRequest> request)
		{
			List<Opiniones> au = _Mapper.Map<List<Opiniones>>(request);
			int cantidad = _IOpinionesRepository.DeleteMultipleItems(au);
			return cantidad;
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		public List<OpinionesResponse> getAll()
		{
			List<Opiniones> lsl = _IOpinionesRepository.GetAll();
			List<OpinionesResponse> res = _Mapper.Map<List<OpinionesResponse>>(lsl);
			return res;
		}

		public List<OpinionesResponse> getAutoComplete(string query)
		{
			throw new NotImplementedException();
		}

		public OpinionesResponse getById(object id)
		{
			Opiniones au = _IOpinionesRepository.GetById(id);
			OpinionesResponse res = _Mapper.Map<OpinionesResponse>(au);
			return res;
		}

		public OpinionesResponse Update(OpinionesRequest entity)
		{
			Opiniones au = _Mapper.Map<Opiniones>(entity);
			au = _IOpinionesRepository.Update(au);
			OpinionesResponse res = _Mapper.Map<OpinionesResponse>(au);
			return res;
		}

		public List<OpinionesResponse> UpdateMultiple(List<OpinionesRequest> request)
		{
			List<Opiniones> au = _Mapper.Map<List<Opiniones>>(request);
			au = _IOpinionesRepository.UpdateMultiple(au);
			List<OpinionesResponse> res = _Mapper.Map<List<OpinionesResponse>>(au);
			return res;
		}
	}
}
