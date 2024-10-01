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
	public class ConductorBussines : IConductorBussines
	{
		#region Declaracion de vcariables generales
		public readonly IConductorRepository _IConductorRepository = null;
		public readonly IMapper _Mapper;

		public ConductorBussines()
		{
		}
		#endregion

		#region constructor 
		public ConductorBussines(IMapper mapper)
		{
			_Mapper = mapper;
			_IConductorRepository = new ConductorRepository();
		}
		#endregion

		public ConductorResponse Create(ConductorRequest entity)
		{
			Conductor au = _Mapper.Map<Conductor>(entity);
			au = _IConductorRepository.Create(au);
			ConductorResponse res = _Mapper.Map<ConductorResponse>(au);
			return res;
		}

		public List<ConductorResponse> CreateMultiple(List<ConductorRequest> request)
		{
			List<Conductor> au = _Mapper.Map<List<Conductor>>(request);
			au = _IConductorRepository.InsertMultiple(au);
			List<ConductorResponse> res = _Mapper.Map<List<ConductorResponse>>(au);
			return res;
		}

		public int Delete(object id)
		{
			return _IConductorRepository.Delete(id);
		}

		public int deleteMultipleItems(List<ConductorRequest> request)
		{
			List<Conductor> au = _Mapper.Map<List<Conductor>>(request);
			int cantidad = _IConductorRepository.DeleteMultipleItems(au);
			return cantidad;
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		public List<ConductorResponse> getAll()
		{
			List<Conductor> lsl = _IConductorRepository.GetAll();
			List<ConductorResponse> res = _Mapper.Map<List<ConductorResponse>>(lsl);
			return res;
		}

		public List<ConductorResponse> getAutoComplete(string query)
		{
			throw new NotImplementedException();
		}

		public ConductorResponse getById(object id)
		{
			Conductor au = _IConductorRepository.GetById(id);
			ConductorResponse res = _Mapper.Map<ConductorResponse>(au);
			return res;
		}

		public ConductorResponse Update(ConductorRequest entity)
		{
			Conductor au = _Mapper.Map<Conductor>(entity);
			au = _IConductorRepository.Update(au);
			ConductorResponse res = _Mapper.Map<ConductorResponse>(au);
			return res;
		}

		public List<ConductorResponse> UpdateMultiple(List<ConductorRequest> request)
		{
			List<Conductor> au = _Mapper.Map<List<Conductor>>(request);
			au = _IConductorRepository.UpdateMultiple(au);
			List<ConductorResponse> res = _Mapper.Map<List<ConductorResponse>>(au);
			return res;
		}
	}
}
