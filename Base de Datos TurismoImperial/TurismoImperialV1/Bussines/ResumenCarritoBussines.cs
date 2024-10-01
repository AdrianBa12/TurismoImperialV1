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
	public class ResumenCarritoBussines : IResumenCarritoBussines
	{
		#region Declaracion de vcariables generales
		public readonly IResumenCarritoRepository _IResumenCarritoRepository = null;
		public readonly IMapper _Mapper;

		public ResumenCarritoBussines()
		{
		}
		#endregion

		#region constructor 
		public ResumenCarritoBussines(IMapper mapper)
		{
			_Mapper = mapper;
			_IResumenCarritoRepository = new ResumenCarritoRepository();
		}
		#endregion

		public ResumenCarritoResponse Create(ResumenCarritoRequest entity)
		{
			ResumenCarrito au = _Mapper.Map<ResumenCarrito>(entity);
			au = _IResumenCarritoRepository.Create(au);
			ResumenCarritoResponse res = _Mapper.Map<ResumenCarritoResponse>(au);
			return res;
		}

		public List<ResumenCarritoResponse> CreateMultiple(List<ResumenCarritoRequest> request)
		{
			List<ResumenCarrito> au = _Mapper.Map<List<ResumenCarrito>>(request);
			au = _IResumenCarritoRepository.InsertMultiple(au);
			List<ResumenCarritoResponse> res = _Mapper.Map<List<ResumenCarritoResponse>>(au);
			return res;
		}

		public int Delete(object id)
		{
			return _IResumenCarritoRepository.Delete(id);
		}

		public int deleteMultipleItems(List<ResumenCarritoRequest> request)
		{
			List<ResumenCarrito> au = _Mapper.Map<List<ResumenCarrito>>(request);
			int cantidad = _IResumenCarritoRepository.DeleteMultipleItems(au);
			return cantidad;
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		public List<ResumenCarritoResponse> getAll()
		{
			List<ResumenCarrito> lsl = _IResumenCarritoRepository.GetAll();
			List<ResumenCarritoResponse> res = _Mapper.Map<List<ResumenCarritoResponse>>(lsl);
			return res;
		}

		public List<ResumenCarritoResponse> getAutoComplete(string query)
		{
			throw new NotImplementedException();
		}

		public ResumenCarritoResponse getById(object id)
		{
			ResumenCarrito au = _IResumenCarritoRepository.GetById(id);
			ResumenCarritoResponse res = _Mapper.Map<ResumenCarritoResponse>(au);
			return res;
		}

		public ResumenCarritoResponse Update(ResumenCarritoRequest entity)
		{
			ResumenCarrito au = _Mapper.Map<ResumenCarrito>(entity);
			au = _IResumenCarritoRepository.Update(au);
			ResumenCarritoResponse res = _Mapper.Map<ResumenCarritoResponse>(au);
			return res;
		}

		public List<ResumenCarritoResponse> UpdateMultiple(List<ResumenCarritoRequest> request)
		{
			List<ResumenCarrito> au = _Mapper.Map<List<ResumenCarrito>>(request);
			au = _IResumenCarritoRepository.UpdateMultiple(au);
			List<ResumenCarritoResponse> res = _Mapper.Map<List<ResumenCarritoResponse>>(au);
			return res;
		}
	}
}
