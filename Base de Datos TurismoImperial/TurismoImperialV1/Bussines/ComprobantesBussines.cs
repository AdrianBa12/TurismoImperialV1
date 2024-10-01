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
	public class ComprobantesBussines : IComprobantesBussines
	{
		#region Declaracion de vcariables generales
		public readonly IComprobantesRepository _IComprobantesRepository = null;
		public readonly IMapper _Mapper;

		public ComprobantesBussines()
		{
		}
		#endregion

		#region constructor 
		public ComprobantesBussines(IMapper mapper)
		{
			_Mapper = mapper;
			_IComprobantesRepository = new ComprobantesRepository();
		}
		#endregion

		public ComprobantesResponse Create(ComprobantesRequest entity)
		{
			Comprobantes au = _Mapper.Map<Comprobantes>(entity);
			au = _IComprobantesRepository.Create(au);
			ComprobantesResponse res = _Mapper.Map<ComprobantesResponse>(au);
			return res;
		}

		public List<ComprobantesResponse> CreateMultiple(List<ComprobantesRequest> request)
		{
			List<Comprobantes> au = _Mapper.Map<List<Comprobantes>>(request);
			au = _IComprobantesRepository.InsertMultiple(au);
			List<ComprobantesResponse> res = _Mapper.Map<List<ComprobantesResponse>>(au);
			return res;
		}

		public int Delete(object id)
		{
			return _IComprobantesRepository.Delete(id);
		}

		public int deleteMultipleItems(List<ComprobantesRequest> request)
		{
			List<Comprobantes> au = _Mapper.Map<List<Comprobantes>>(request);
			int cantidad = _IComprobantesRepository.DeleteMultipleItems(au);
			return cantidad;
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		public List<ComprobantesResponse> getAll()
		{
			List<Comprobantes> lsl = _IComprobantesRepository.GetAll();
			List<ComprobantesResponse> res = _Mapper.Map<List<ComprobantesResponse>>(lsl);
			return res;
		}

		public List<ComprobantesResponse> getAutoComplete(string query)
		{
			throw new NotImplementedException();
		}

		public ComprobantesResponse getById(object id)
		{
			Comprobantes au = _IComprobantesRepository.GetById(id);
			ComprobantesResponse res = _Mapper.Map<ComprobantesResponse>(au);
			return res;
		}

		public ComprobantesResponse Update(ComprobantesRequest entity)
		{
			Comprobantes au = _Mapper.Map<Comprobantes>(entity);
			au = _IComprobantesRepository.Update(au);
			ComprobantesResponse res = _Mapper.Map<ComprobantesResponse>(au);
			return res;
		}

		public List<ComprobantesResponse> UpdateMultiple(List<ComprobantesRequest> request)
		{
			List<Comprobantes> au = _Mapper.Map<List<Comprobantes>>(request);
			au = _IComprobantesRepository.UpdateMultiple(au);
			List<ComprobantesResponse> res = _Mapper.Map<List<ComprobantesResponse>>(au);
			return res;
		}
	}
}
