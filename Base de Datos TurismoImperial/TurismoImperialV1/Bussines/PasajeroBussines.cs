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
	public class PasajeroBussines : IPasajeroBussines
	{
		#region Declaracion de vcariables generales
		public readonly IPasajeroRepository _IPasajeroRepository = null;
		public readonly IMapper _Mapper;

		public PasajeroBussines()
		{
		}
		#endregion

		#region constructor 
		public PasajeroBussines(IMapper mapper)
		{
			_Mapper = mapper;
			_IPasajeroRepository = new PasajeroRepository();
		}
		#endregion

		public PasajeroResponse Create(PasajeroRequest entity)
		{
			Pasajero au = _Mapper.Map<Pasajero>(entity);
			au = _IPasajeroRepository.Create(au);
			PasajeroResponse res = _Mapper.Map<PasajeroResponse>(au);
			return res;
		}

		public List<PasajeroResponse> CreateMultiple(List<PasajeroRequest> request)
		{
			List<Pasajero> au = _Mapper.Map<List<Pasajero>>(request);
			au = _IPasajeroRepository.InsertMultiple(au);
			List<PasajeroResponse> res = _Mapper.Map<List<PasajeroResponse>>(au);
			return res;
		}

		public int Delete(object id)
		{
			return _IPasajeroRepository.Delete(id);
		}

		public int deleteMultipleItems(List<PasajeroRequest> request)
		{
			List<Pasajero> au = _Mapper.Map<List<Pasajero>>(request);
			int cantidad = _IPasajeroRepository.DeleteMultipleItems(au);
			return cantidad;
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		public List<PasajeroResponse> getAll()
		{
			List<Pasajero> lsl = _IPasajeroRepository.GetAll();
			List<PasajeroResponse> res = _Mapper.Map<List<PasajeroResponse>>(lsl);
			return res;
		}

		public List<PasajeroResponse> getAutoComplete(string query)
		{
			throw new NotImplementedException();
		}

		public PasajeroResponse getById(object id)
		{
			Pasajero au = _IPasajeroRepository.GetById(id);
			PasajeroResponse res = _Mapper.Map<PasajeroResponse>(au);
			return res;
		}

		public PasajeroResponse Update(PasajeroRequest entity)
		{
			Pasajero au = _Mapper.Map<Pasajero>(entity);
			au = _IPasajeroRepository.Update(au);
			PasajeroResponse res = _Mapper.Map<PasajeroResponse>(au);
			return res;
		}

		public List<PasajeroResponse> UpdateMultiple(List<PasajeroRequest> request)
		{
			List<Pasajero> au = _Mapper.Map<List<Pasajero>>(request);
			au = _IPasajeroRepository.UpdateMultiple(au);
			List<PasajeroResponse> res = _Mapper.Map<List<PasajeroResponse>>(au);
			return res;
		}
	}
}
