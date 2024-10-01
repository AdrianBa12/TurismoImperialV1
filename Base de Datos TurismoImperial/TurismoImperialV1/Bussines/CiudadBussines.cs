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
	public class CiudadBussines : ICiudadBussines
	{
		#region Declaracion de vcariables generales
		public readonly ICiudadRepository _ICiudadRepository = null;
		public readonly IMapper _Mapper;

		public CiudadBussines()
		{
		}
		#endregion

		#region constructor 
		public CiudadBussines(IMapper mapper)
		{
			_Mapper = mapper;
			_ICiudadRepository = new CiudadRepository();
		}
		#endregion

		public CiudadResponse Create(CiudadRequest entity)
		{
			Ciudad au = _Mapper.Map<Ciudad>(entity);
			au = _ICiudadRepository.Create(au);
			CiudadResponse res = _Mapper.Map<CiudadResponse>(au);
			return res;
		}

		public List<CiudadResponse> CreateMultiple(List<CiudadRequest> request)
		{
			List<Ciudad> au = _Mapper.Map<List<Ciudad>>(request);
			au = _ICiudadRepository.InsertMultiple(au);
			List<CiudadResponse> res = _Mapper.Map<List<CiudadResponse>>(au);
			return res;
		}

		public int Delete(object id)
		{
			return _ICiudadRepository.Delete(id);
		}

		public int deleteMultipleItems(List<CiudadRequest> request)
		{
			List<Ciudad> au = _Mapper.Map<List<Ciudad>>(request);
			int cantidad = _ICiudadRepository.DeleteMultipleItems(au);
			return cantidad;
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		public List<CiudadResponse> getAll()
		{
			List<Ciudad> lsl = _ICiudadRepository.GetAll();
			List<CiudadResponse> res = _Mapper.Map<List<CiudadResponse>>(lsl);
			return res;
		}

		public List<CiudadResponse> getAutoComplete(string query)
		{
			throw new NotImplementedException();
		}

		public CiudadResponse getById(object id)
		{
			Ciudad au = _ICiudadRepository.GetById(id);
			CiudadResponse res = _Mapper.Map<CiudadResponse>(au);
			return res;
		}

		public CiudadResponse Update(CiudadRequest entity)
		{
			Ciudad au = _Mapper.Map<Ciudad>(entity);
			au = _ICiudadRepository.Update(au);
			CiudadResponse res = _Mapper.Map<CiudadResponse>(au);
			return res;
		}

		public List<CiudadResponse> UpdateMultiple(List<CiudadRequest> request)
		{
			List<Ciudad> au = _Mapper.Map<List<Ciudad>>(request);
			au = _ICiudadRepository.UpdateMultiple(au);
			List<CiudadResponse> res = _Mapper.Map<List<CiudadResponse>>(au);
			return res;
		}
	}
}
