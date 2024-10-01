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
	public class PagosBussines : IPagosBussines
	{
		#region Declaracion de vcariables generales
		public readonly IPagosRepository _IPagosRepository = null;
		public readonly IMapper _Mapper;

		public PagosBussines()
		{
		}
		#endregion

		#region constructor 
		public PagosBussines(IMapper mapper)
		{
			_Mapper = mapper;
			_IPagosRepository = new PagosRepository();
		}
		#endregion

		public PagosResponse Create(PagosRequest entity)
		{
			Pagos au = _Mapper.Map<Pagos>(entity);
			au = _IPagosRepository.Create(au);
			PagosResponse res = _Mapper.Map<PagosResponse>(au);
			return res;
		}

		public List<PagosResponse> CreateMultiple(List<PagosRequest> request)
		{
			List<Pagos> au = _Mapper.Map<List<Pagos>>(request);
			au = _IPagosRepository.InsertMultiple(au);
			List<PagosResponse> res = _Mapper.Map<List<PagosResponse>>(au);
			return res;
		}

		public int Delete(object id)
		{
			return _IPagosRepository.Delete(id);
		}

		public int deleteMultipleItems(List<PagosRequest> request)
		{
			List<Pagos> au = _Mapper.Map<List<Pagos>>(request);
			int cantidad = _IPagosRepository.DeleteMultipleItems(au);
			return cantidad;
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		public List<PagosResponse> getAll()
		{
			List<Pagos> lsl = _IPagosRepository.GetAll();
			List<PagosResponse> res = _Mapper.Map<List<PagosResponse>>(lsl);
			return res;
		}

		public List<PagosResponse> getAutoComplete(string query)
		{
			throw new NotImplementedException();
		}

		public PagosResponse getById(object id)
		{
			Pagos au = _IPagosRepository.GetById(id);
			PagosResponse res = _Mapper.Map<PagosResponse>(au);
			return res;
		}

		public PagosResponse Update(PagosRequest entity)
		{
			Pagos au = _Mapper.Map<Pagos>(entity);
			au = _IPagosRepository.Update(au);
			PagosResponse res = _Mapper.Map<PagosResponse>(au);
			return res;
		}

		public List<PagosResponse> UpdateMultiple(List<PagosRequest> request)
		{
			List<Pagos> au = _Mapper.Map<List<Pagos>>(request);
			au = _IPagosRepository.UpdateMultiple(au);
			List<PagosResponse> res = _Mapper.Map<List<PagosResponse>>(au);
			return res;
		}
	}
}
