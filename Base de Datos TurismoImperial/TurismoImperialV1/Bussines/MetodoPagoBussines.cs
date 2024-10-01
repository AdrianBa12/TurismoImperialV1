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
	public class MetodoPagoBussines : IMetodoPagoBussines
	{
		#region Declaracion de vcariables generales
		public readonly IMetodoPagoRepository _IMetodoPagoRepository = null;
		public readonly IMapper _Mapper;

		public MetodoPagoBussines()
		{
		}
		#endregion

		#region constructor 
		public MetodoPagoBussines(IMapper mapper)
		{
			_Mapper = mapper;
			_IMetodoPagoRepository = new MetodoPagoRepository();
		}
		#endregion

		public MetodoPagoResponse Create(MetodoPagoRequest entity)
		{
			MetodoPago au = _Mapper.Map<MetodoPago>(entity);
			au = _IMetodoPagoRepository.Create(au);
			MetodoPagoResponse res = _Mapper.Map<MetodoPagoResponse>(au);
			return res;
		}

		public List<MetodoPagoResponse> CreateMultiple(List<MetodoPagoRequest> request)
		{
			List<MetodoPago> au = _Mapper.Map<List<MetodoPago>>(request);
			au = _IMetodoPagoRepository.InsertMultiple(au);
			List<MetodoPagoResponse> res = _Mapper.Map<List<MetodoPagoResponse>>(au);
			return res;
		}

		public int Delete(object id)
		{
			return _IMetodoPagoRepository.Delete(id);
		}

		public int deleteMultipleItems(List<MetodoPagoRequest> request)
		{
			List<MetodoPago> au = _Mapper.Map<List<MetodoPago>>(request);
			int cantidad = _IMetodoPagoRepository.DeleteMultipleItems(au);
			return cantidad;
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		public List<MetodoPagoResponse> getAll()
		{
			List<MetodoPago> lsl = _IMetodoPagoRepository.GetAll();
			List<MetodoPagoResponse> res = _Mapper.Map<List<MetodoPagoResponse>>(lsl);
			return res;
		}

		public List<MetodoPagoResponse> getAutoComplete(string query)
		{
			throw new NotImplementedException();
		}

		public MetodoPagoResponse getById(object id)
		{
			MetodoPago au = _IMetodoPagoRepository.GetById(id);
			MetodoPagoResponse res = _Mapper.Map<MetodoPagoResponse>(au);
			return res;
		}

		public MetodoPagoResponse Update(MetodoPagoRequest entity)
		{
			MetodoPago au = _Mapper.Map<MetodoPago>(entity);
			au = _IMetodoPagoRepository.Update(au);
			MetodoPagoResponse res = _Mapper.Map<MetodoPagoResponse>(au);
			return res;
		}

		public List<MetodoPagoResponse> UpdateMultiple(List<MetodoPagoRequest> request)
		{
			List<MetodoPago> au = _Mapper.Map<List<MetodoPago>>(request);
			au = _IMetodoPagoRepository.UpdateMultiple(au);
			List<MetodoPagoResponse> res = _Mapper.Map<List<MetodoPagoResponse>>(au);
			return res;
		}
	}
}
