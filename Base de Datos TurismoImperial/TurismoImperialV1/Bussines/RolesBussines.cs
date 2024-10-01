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
	public class RolesBussines : IRolesBussines
	{
		#region Declaracion de vcariables generales
		public readonly IRolesRepository _IRolesRepository = null;
		public readonly IMapper _Mapper;

		public RolesBussines()
		{
		}
		#endregion

		#region constructor 
		public RolesBussines(IMapper mapper)
		{
			_Mapper = mapper;
			_IRolesRepository = new RolesRepository();
		}
		#endregion

		public RolesResponse Create(RolesRequest entity)
		{
			Roles au = _Mapper.Map<Roles>(entity);
			au = _IRolesRepository.Create(au);
			RolesResponse res = _Mapper.Map<RolesResponse>(au);
			return res;
		}

		public List<RolesResponse> CreateMultiple(List<RolesRequest> request)
		{
			List<Roles> au = _Mapper.Map<List<Roles>>(request);
			au = _IRolesRepository.InsertMultiple(au);
			List<RolesResponse> res = _Mapper.Map<List<RolesResponse>>(au);
			return res;
		}

		public int Delete(object id)
		{
			return _IRolesRepository.Delete(id);
		}

		public int deleteMultipleItems(List<RolesRequest> request)
		{
			List<Roles> au = _Mapper.Map<List<Roles>>(request);
			int cantidad = _IRolesRepository.DeleteMultipleItems(au);
			return cantidad;
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		public List<RolesResponse> getAll()
		{
			List<Roles> lsl = _IRolesRepository.GetAll();
			List<RolesResponse> res = _Mapper.Map<List<RolesResponse>>(lsl);
			return res;
		}

		public List<RolesResponse> getAutoComplete(string query)
		{
			throw new NotImplementedException();
		}

		public RolesResponse getById(object id)
		{
			Roles au = _IRolesRepository.GetById(id);
			RolesResponse res = _Mapper.Map<RolesResponse>(au);
			return res;
		}

		public RolesResponse Update(RolesRequest entity)
		{
			Roles au = _Mapper.Map<Roles>(entity);
			au = _IRolesRepository.Update(au);
			RolesResponse res = _Mapper.Map<RolesResponse>(au);
			return res;
		}

		public List<RolesResponse> UpdateMultiple(List<RolesRequest> request)
		{
			List<Roles> au = _Mapper.Map<List<Roles>>(request);
			au = _IRolesRepository.UpdateMultiple(au);
			List<RolesResponse> res = _Mapper.Map<List<RolesResponse>>(au);
			return res;
		}
	}
}
