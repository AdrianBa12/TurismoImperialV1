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
	public class DetallesViajeBussines : IDetallesViajeBussines
	{
		#region Declaracion de vcariables generales
		public readonly IDetallesViajeRepository _IDetallesViajeRepository = null;
		public readonly IMapper _Mapper;

		public DetallesViajeBussines()
		{
		}
		#endregion

		#region constructor 
		public DetallesViajeBussines(IMapper mapper)
		{
			_Mapper = mapper;
			_IDetallesViajeRepository = new DetallesViajeRepository();
		}
		#endregion

		public DetallesViajeResponse Create(DetallesViajeRequest entity)
		{
			DetallesViaje au = _Mapper.Map<DetallesViaje>(entity);
			au = _IDetallesViajeRepository.Create(au);
			DetallesViajeResponse res = _Mapper.Map<DetallesViajeResponse>(au);
			return res;
		}

		public List<DetallesViajeResponse> CreateMultiple(List<DetallesViajeRequest> request)
		{
			List<DetallesViaje> au = _Mapper.Map<List<DetallesViaje>>(request);
			au = _IDetallesViajeRepository.InsertMultiple(au);
			List<DetallesViajeResponse> res = _Mapper.Map<List<DetallesViajeResponse>>(au);
			return res;
		}

		public int Delete(object id)
		{
			return _IDetallesViajeRepository.Delete(id);
		}

		public int deleteMultipleItems(List<DetallesViajeRequest> request)
		{
			List<DetallesViaje> au = _Mapper.Map<List<DetallesViaje>>(request);
			int cantidad = _IDetallesViajeRepository.DeleteMultipleItems(au);
			return cantidad;
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		public List<DetallesViajeResponse> getAll()
		{
			List<DetallesViaje> lsl = _IDetallesViajeRepository.GetAll();
			List<DetallesViajeResponse> res = _Mapper.Map<List<DetallesViajeResponse>>(lsl);
			return res;
		}

		public List<DetallesViajeResponse> getAutoComplete(string query)
		{
			throw new NotImplementedException();
		}

		public DetallesViajeResponse getById(object id)
		{
			DetallesViaje au = _IDetallesViajeRepository.GetById(id);
			DetallesViajeResponse res = _Mapper.Map<DetallesViajeResponse>(au);
			return res;
		}

		public DetallesViajeResponse Update(DetallesViajeRequest entity)
		{
			DetallesViaje au = _Mapper.Map<DetallesViaje>(entity);
			au = _IDetallesViajeRepository.Update(au);
			DetallesViajeResponse res = _Mapper.Map<DetallesViajeResponse>(au);
			return res;
		}

		public List<DetallesViajeResponse> UpdateMultiple(List<DetallesViajeRequest> request)
		{
			List<DetallesViaje> au = _Mapper.Map<List<DetallesViaje>>(request);
			au = _IDetallesViajeRepository.UpdateMultiple(au);
			List<DetallesViajeResponse> res = _Mapper.Map<List<DetallesViajeResponse>>(au);
			return res;
		}
	}
}
