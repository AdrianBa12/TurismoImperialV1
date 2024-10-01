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
	public class EstadoPagoBussines : IEstadoPagoBussines
	{
		#region Declaracion de vcariables generales
		public readonly IEstadoPagoRepository _IEstadoPagoRepository = null;
		public readonly IMapper _Mapper;

		public EstadoPagoBussines()
		{
		}
		#endregion

		#region constructor 
		public EstadoPagoBussines(IMapper mapper)
		{
			_Mapper = mapper;
			_IEstadoPagoRepository = new EstadoPagoRepository();
		}
		#endregion

		public EstadoPagoResponse Create(EstadoPagoRequest entity)
		{
			EstadoPago au = _Mapper.Map<EstadoPago>(entity);
			au = _IEstadoPagoRepository.Create(au);
			EstadoPagoResponse res = _Mapper.Map<EstadoPagoResponse>(au);
			return res;
		}

		public List<EstadoPagoResponse> CreateMultiple(List<EstadoPagoRequest> request)
		{
			List<EstadoPago> au = _Mapper.Map<List<EstadoPago>>(request);
			au = _IEstadoPagoRepository.InsertMultiple(au);
			List<EstadoPagoResponse> res = _Mapper.Map<List<EstadoPagoResponse>>(au);
			return res;
		}

		public int Delete(object id)
		{
			return _IEstadoPagoRepository.Delete(id);
		}

		public int deleteMultipleItems(List<EstadoPagoRequest> request)
		{
			List<EstadoPago> au = _Mapper.Map<List<EstadoPago>>(request);
			int cantidad = _IEstadoPagoRepository.DeleteMultipleItems(au);
			return cantidad;
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		public List<EstadoPagoResponse> getAll()
		{
			List<EstadoPago> lsl = _IEstadoPagoRepository.GetAll();
			List<EstadoPagoResponse> res = _Mapper.Map<List<EstadoPagoResponse>>(lsl);
			return res;
		}

		public List<EstadoPagoResponse> getAutoComplete(string query)
		{
			throw new NotImplementedException();
		}

		public EstadoPagoResponse getById(object id)
		{
			EstadoPago au = _IEstadoPagoRepository.GetById(id);
			EstadoPagoResponse res = _Mapper.Map<EstadoPagoResponse>(au);
			return res;
		}

		public EstadoPagoResponse Update(EstadoPagoRequest entity)
		{
			EstadoPago au = _Mapper.Map<EstadoPago>(entity);
			au = _IEstadoPagoRepository.Update(au);
			EstadoPagoResponse res = _Mapper.Map<EstadoPagoResponse>(au);
			return res;
		}

		public List<EstadoPagoResponse> UpdateMultiple(List<EstadoPagoRequest> request)
		{
			List<EstadoPago> au = _Mapper.Map<List<EstadoPago>>(request);
			au = _IEstadoPagoRepository.UpdateMultiple(au);
			List<EstadoPagoResponse> res = _Mapper.Map<List<EstadoPagoResponse>>(au);
			return res;
		}
	}
}
