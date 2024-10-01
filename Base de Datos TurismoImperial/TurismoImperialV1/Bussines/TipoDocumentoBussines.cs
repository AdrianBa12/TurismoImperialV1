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
	public class TipoDocumentoBussines : ITipoDocumentoBussines
	{
		#region Declaracion de vcariables generales
		public readonly ITipoDocumentoRepository _ITipoDocumentoRepository = null;
		public readonly IMapper _Mapper;

		public TipoDocumentoBussines()
		{
		}
		#endregion

		#region constructor 
		public TipoDocumentoBussines(IMapper mapper)
		{
			_Mapper = mapper;
			_ITipoDocumentoRepository = new TipoDocumentoRepository();
		}
		#endregion

		public TipoDocumentoResponse Create(TipoDocumentoRequest entity)
		{
			TipoDocumento au = _Mapper.Map<TipoDocumento>(entity);
			au = _ITipoDocumentoRepository.Create(au);
			TipoDocumentoResponse res = _Mapper.Map<TipoDocumentoResponse>(au);
			return res;
		}

		public List<TipoDocumentoResponse> CreateMultiple(List<TipoDocumentoRequest> request)
		{
			List<TipoDocumento> au = _Mapper.Map<List<TipoDocumento>>(request);
			au = _ITipoDocumentoRepository.InsertMultiple(au);
			List<TipoDocumentoResponse> res = _Mapper.Map<List<TipoDocumentoResponse>>(au);
			return res;
		}

		public int Delete(object id)
		{
			return _ITipoDocumentoRepository.Delete(id);
		}

		public int deleteMultipleItems(List<TipoDocumentoRequest> request)
		{
			List<TipoDocumento> au = _Mapper.Map<List<TipoDocumento>>(request);
			int cantidad = _ITipoDocumentoRepository.DeleteMultipleItems(au);
			return cantidad;
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		public List<TipoDocumentoResponse> getAll()
		{
			List<TipoDocumento> lsl = _ITipoDocumentoRepository.GetAll();
			List<TipoDocumentoResponse> res = _Mapper.Map<List<TipoDocumentoResponse>>(lsl);
			return res;
		}

		public List<TipoDocumentoResponse> getAutoComplete(string query)
		{
			throw new NotImplementedException();
		}

		public TipoDocumentoResponse getById(object id)
		{
			TipoDocumento au = _ITipoDocumentoRepository.GetById(id);
			TipoDocumentoResponse res = _Mapper.Map<TipoDocumentoResponse>(au);
			return res;
		}

		public TipoDocumentoResponse Update(TipoDocumentoRequest entity)
		{
			TipoDocumento au = _Mapper.Map<TipoDocumento>(entity);
			au = _ITipoDocumentoRepository.Update(au);
			TipoDocumentoResponse res = _Mapper.Map<TipoDocumentoResponse>(au);
			return res;
		}

		public List<TipoDocumentoResponse> UpdateMultiple(List<TipoDocumentoRequest> request)
		{
			List<TipoDocumento> au = _Mapper.Map<List<TipoDocumento>>(request);
			au = _ITipoDocumentoRepository.UpdateMultiple(au);
			List<TipoDocumentoResponse> res = _Mapper.Map<List<TipoDocumentoResponse>>(au);
			return res;
		}
	}
}
