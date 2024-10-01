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
	public class EmpleadosBussines : IEmpleadosBussines
	{
		#region Declaracion de vcariables generales
		public readonly IEmpleadosRepository _IEmpleadosRepository = null;
		public readonly IMapper _Mapper;

		public EmpleadosBussines()
		{
		}
		#endregion

		#region constructor 
		public EmpleadosBussines(IMapper mapper)
		{
			_Mapper = mapper;
			_IEmpleadosRepository = new EmpleadosRepository();
		}
		#endregion

		public EmpleadosResponse Create(EmpleadosRequest entity)
		{
			Empleados au = _Mapper.Map<Empleados>(entity);
			au = _IEmpleadosRepository.Create(au);
			EmpleadosResponse res = _Mapper.Map<EmpleadosResponse>(au);
			return res;
		}

		public List<EmpleadosResponse> CreateMultiple(List<EmpleadosRequest> request)
		{
			List<Empleados> au = _Mapper.Map<List<Empleados>>(request);
			au = _IEmpleadosRepository.InsertMultiple(au);
			List<EmpleadosResponse> res = _Mapper.Map<List<EmpleadosResponse>>(au);
			return res;
		}

		public int Delete(object id)
		{
			return _IEmpleadosRepository.Delete(id);
		}

		public int deleteMultipleItems(List<EmpleadosRequest> request)
		{
			List<Empleados> au = _Mapper.Map<List<Empleados>>(request);
			int cantidad = _IEmpleadosRepository.DeleteMultipleItems(au);
			return cantidad;
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		public List<EmpleadosResponse> getAll()
		{
			List<Empleados> lsl = _IEmpleadosRepository.GetAll();
			List<EmpleadosResponse> res = _Mapper.Map<List<EmpleadosResponse>>(lsl);
			return res;
		}

		public List<EmpleadosResponse> getAutoComplete(string query)
		{
			throw new NotImplementedException();
		}

		public EmpleadosResponse getById(object id)
		{
			Empleados au = _IEmpleadosRepository.GetById(id);
			EmpleadosResponse res = _Mapper.Map<EmpleadosResponse>(au);
			return res;
		}

		public EmpleadosResponse Update(EmpleadosRequest entity)
		{
			Empleados au = _Mapper.Map<Empleados>(entity);
			au = _IEmpleadosRepository.Update(au);
			EmpleadosResponse res = _Mapper.Map<EmpleadosResponse>(au);
			return res;
		}

		public List<EmpleadosResponse> UpdateMultiple(List<EmpleadosRequest> request)
		{
			List<Empleados> au = _Mapper.Map<List<Empleados>>(request);
			au = _IEmpleadosRepository.UpdateMultiple(au);
			List<EmpleadosResponse> res = _Mapper.Map<List<EmpleadosResponse>>(au);
			return res;
		}
	}
}
