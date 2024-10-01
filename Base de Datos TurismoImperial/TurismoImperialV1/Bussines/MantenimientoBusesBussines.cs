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
	public class MantenimientoBusesBussines : IMantenimientoBusesBussines
	{
		#region Declaracion de vcariables generales
		public readonly IMantenimientoBusesRepository _IMantenimientoBusesRepository = null;
		public readonly IMapper _Mapper;

		public MantenimientoBusesBussines()
		{
		}
		#endregion

		#region constructor 
		public MantenimientoBusesBussines(IMapper mapper)
		{
			_Mapper = mapper;
			_IMantenimientoBusesRepository = new MantenimientoBusesRepository();
		}
		#endregion

		public MantenimientoBusesResponse Create(MantenimientoBusesRequest entity)
		{
			MantenimientoBuses au = _Mapper.Map<MantenimientoBuses>(entity);
			au = _IMantenimientoBusesRepository.Create(au);
			MantenimientoBusesResponse res = _Mapper.Map<MantenimientoBusesResponse>(au);
			return res;
		}

		public List<MantenimientoBusesResponse> CreateMultiple(List<MantenimientoBusesRequest> request)
		{
			List<MantenimientoBuses> au = _Mapper.Map<List<MantenimientoBuses>>(request);
			au = _IMantenimientoBusesRepository.InsertMultiple(au);
			List<MantenimientoBusesResponse> res = _Mapper.Map<List<MantenimientoBusesResponse>>(au);
			return res;
		}

		public int Delete(object id)
		{
			return _IMantenimientoBusesRepository.Delete(id);
		}

		public int deleteMultipleItems(List<MantenimientoBusesRequest> request)
		{
			List<MantenimientoBuses> au = _Mapper.Map<List<MantenimientoBuses>>(request);
			int cantidad = _IMantenimientoBusesRepository.DeleteMultipleItems(au);
			return cantidad;
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		public List<MantenimientoBusesResponse> getAll()
		{
			List<MantenimientoBuses> lsl = _IMantenimientoBusesRepository.GetAll();
			List<MantenimientoBusesResponse> res = _Mapper.Map<List<MantenimientoBusesResponse>>(lsl);
			return res;
		}

		public List<MantenimientoBusesResponse> getAutoComplete(string query)
		{
			throw new NotImplementedException();
		}

		public MantenimientoBusesResponse getById(object id)
		{
			MantenimientoBuses au = _IMantenimientoBusesRepository.GetById(id);
			MantenimientoBusesResponse res = _Mapper.Map<MantenimientoBusesResponse>(au);
			return res;
		}

		public MantenimientoBusesResponse Update(MantenimientoBusesRequest entity)
		{
			MantenimientoBuses au = _Mapper.Map<MantenimientoBuses>(entity);
			au = _IMantenimientoBusesRepository.Update(au);
			MantenimientoBusesResponse res = _Mapper.Map<MantenimientoBusesResponse>(au);
			return res;
		}

		public List<MantenimientoBusesResponse> UpdateMultiple(List<MantenimientoBusesRequest> request)
		{
			List<MantenimientoBuses> au = _Mapper.Map<List<MantenimientoBuses>>(request);
			au = _IMantenimientoBusesRepository.UpdateMultiple(au);
			List<MantenimientoBusesResponse> res = _Mapper.Map<List<MantenimientoBusesResponse>>(au);
			return res;
		}
	}
}
