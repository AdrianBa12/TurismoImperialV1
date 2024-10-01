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
	public class ViajesBussines : IViajesBussines
	{
		#region Declaracion de vcariables generales
		public readonly IViajesRepository _IViajesRepository = null;
		public readonly IMapper _Mapper;

		public ViajesBussines()
		{
		}
		#endregion

		#region constructor 
		public ViajesBussines(IMapper mapper)
		{
			_Mapper = mapper;
			_IViajesRepository = new ViajesRepository();
		}
		#endregion

		public ViajesResponse Create(ViajesRequest entity)
		{
			Viajes au = _Mapper.Map<Viajes>(entity);
			au = _IViajesRepository.Create(au);
			ViajesResponse res = _Mapper.Map<ViajesResponse>(au);
			return res;
		}

		public List<ViajesResponse> CreateMultiple(List<ViajesRequest> request)
		{
			List<Viajes> au = _Mapper.Map<List<Viajes>>(request);
			au = _IViajesRepository.InsertMultiple(au);
			List<ViajesResponse> res = _Mapper.Map<List<ViajesResponse>>(au);
			return res;
		}

		public int Delete(object id)
		{
			return _IViajesRepository.Delete(id);
		}

		public int deleteMultipleItems(List<ViajesRequest> request)
		{
			List<Viajes> au = _Mapper.Map<List<Viajes>>(request);
			int cantidad = _IViajesRepository.DeleteMultipleItems(au);
			return cantidad;
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		public List<ViajesResponse> getAll()
		{
			List<Viajes> lsl = _IViajesRepository.GetAll();
			List<ViajesResponse> res = _Mapper.Map<List<ViajesResponse>>(lsl);
			return res;
		}

		public List<ViajesResponse> getAutoComplete(string query)
		{
			throw new NotImplementedException();
		}

		public ViajesResponse getById(object id)
		{
			Viajes au = _IViajesRepository.GetById(id);
			ViajesResponse res = _Mapper.Map<ViajesResponse>(au);
			return res;
		}

		public ViajesResponse Update(ViajesRequest entity)
		{
			Viajes au = _Mapper.Map<Viajes>(entity);
			au = _IViajesRepository.Update(au);
			ViajesResponse res = _Mapper.Map<ViajesResponse>(au);
			return res;
		}

		public List<ViajesResponse> UpdateMultiple(List<ViajesRequest> request)
		{
			List<Viajes> au = _Mapper.Map<List<Viajes>>(request);
			au = _IViajesRepository.UpdateMultiple(au);
			List<ViajesResponse> res = _Mapper.Map<List<ViajesResponse>>(au);
			return res;
		}
	}
}
