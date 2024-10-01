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
	public class VehiculoBussines : IVehiculoBussines
	{
		#region Declaracion de vcariables generales
		public readonly IVehiculoRepository _IVehiculoRepository = null;
		public readonly IMapper _Mapper;

		public VehiculoBussines()
		{
		}
		#endregion

		#region constructor 
		public VehiculoBussines(IMapper mapper)
		{
			_Mapper = mapper;
			_IVehiculoRepository = new VehiculoRepository();
		}
		#endregion

		public VehiculoResponse Create(VehiculoRequest entity)
		{
			Vehiculo au = _Mapper.Map<Vehiculo>(entity);
			au = _IVehiculoRepository.Create(au);
			VehiculoResponse res = _Mapper.Map<VehiculoResponse>(au);
			return res;
		}

		public List<VehiculoResponse> CreateMultiple(List<VehiculoRequest> request)
		{
			List<Vehiculo> au = _Mapper.Map<List<Vehiculo>>(request);
			au = _IVehiculoRepository.InsertMultiple(au);
			List<VehiculoResponse> res = _Mapper.Map<List<VehiculoResponse>>(au);
			return res;
		}

		public int Delete(object id)
		{
			return _IVehiculoRepository.Delete(id);
		}

		public int deleteMultipleItems(List<VehiculoRequest> request)
		{
			List<Vehiculo> au = _Mapper.Map<List<Vehiculo>>(request);
			int cantidad = _IVehiculoRepository.DeleteMultipleItems(au);
			return cantidad;
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		public List<VehiculoResponse> getAll()
		{
			List<Vehiculo> lsl = _IVehiculoRepository.GetAll();
			List<VehiculoResponse> res = _Mapper.Map<List<VehiculoResponse>>(lsl);
			return res;
		}

		public List<VehiculoResponse> getAutoComplete(string query)
		{
			throw new NotImplementedException();
		}

		public VehiculoResponse getById(object id)
		{
			Vehiculo au = _IVehiculoRepository.GetById(id);
			VehiculoResponse res = _Mapper.Map<VehiculoResponse>(au);
			return res;
		}

		public VehiculoResponse Update(VehiculoRequest entity)
		{
			Vehiculo au = _Mapper.Map<Vehiculo>(entity);
			au = _IVehiculoRepository.Update(au);
			VehiculoResponse res = _Mapper.Map<VehiculoResponse>(au);
			return res;
		}

		public List<VehiculoResponse> UpdateMultiple(List<VehiculoRequest> request)
		{
			List<Vehiculo> au = _Mapper.Map<List<Vehiculo>>(request);
			au = _IVehiculoRepository.UpdateMultiple(au);
			List<VehiculoResponse> res = _Mapper.Map<List<VehiculoResponse>>(au);
			return res;
		}
	}
}
