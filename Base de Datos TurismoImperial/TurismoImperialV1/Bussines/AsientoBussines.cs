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
	public class AsientoBussines : IAsientoBussines
	{
		#region Declaracion de vcariables generales
		public readonly IAsientoRepository _IAsientoRepository = null;
		public readonly IMapper _Mapper;

		public AsientoBussines()
		{
		}
		#endregion

		#region constructor 
		public AsientoBussines(IMapper mapper)
		{
			_Mapper = mapper;
			_IAsientoRepository = new AsientoRepository();
		}
		#endregion

		public AsientoResponse Create(AsientoRequest entity)
		{
			Asiento au = _Mapper.Map<Asiento>(entity);
			au = _IAsientoRepository.Create(au);
			AsientoResponse res = _Mapper.Map<AsientoResponse>(au);
			return res;
		}

		public List<AsientoResponse> CreateMultiple(List<AsientoRequest> request)
		{
			List<Asiento> au = _Mapper.Map<List<Asiento>>(request);
			au = _IAsientoRepository.InsertMultiple(au);
			List<AsientoResponse> res = _Mapper.Map<List<AsientoResponse>>(au);
			return res;
		}

		public int Delete(object id)
		{
			return _IAsientoRepository.Delete(id);
		}

		public int deleteMultipleItems(List<AsientoRequest> request)
		{
			List<Asiento> au = _Mapper.Map<List<Asiento>>(request);
			int cantidad = _IAsientoRepository.DeleteMultipleItems(au);
			return cantidad;
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		public List<AsientoResponse> getAll()
		{
			List<Asiento> lsl = _IAsientoRepository.GetAll();
			List<AsientoResponse> res = _Mapper.Map<List<AsientoResponse>>(lsl);
			return res;
		}

		public List<AsientoResponse> getAutoComplete(string query)
		{
			throw new NotImplementedException();
		}

		public AsientoResponse getById(object id)
		{
			Asiento au = _IAsientoRepository.GetById(id);
			AsientoResponse res = _Mapper.Map<AsientoResponse>(au);
			return res;
		}

		public AsientoResponse Update(AsientoRequest entity)
		{
			Asiento au = _Mapper.Map<Asiento>(entity);
			au = _IAsientoRepository.Update(au);
			AsientoResponse res = _Mapper.Map<AsientoResponse>(au);
			return res;
		}

		public List<AsientoResponse> UpdateMultiple(List<AsientoRequest> request)
		{
			List<Asiento> au = _Mapper.Map<List<Asiento>>(request);
			au = _IAsientoRepository.UpdateMultiple(au);
			List<AsientoResponse> res = _Mapper.Map<List<AsientoResponse>>(au);
			return res;
		}
	}
}
