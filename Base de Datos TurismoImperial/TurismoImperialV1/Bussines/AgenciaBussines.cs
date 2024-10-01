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
	public class AgenciaBussines : IAgenciaBussines
	{
		#region Declaracion de vcariables generales
		public readonly IAgenciaRepository _IAgenciaRepository = null;
		public readonly IMapper _Mapper;

		public AgenciaBussines()
		{
		}
		#endregion

		#region constructor 
		public AgenciaBussines(IMapper mapper)
		{
			_Mapper = mapper;
			_IAgenciaRepository = new AgenciaRepository();
		}
		#endregion

		public AgenciaResponse Create(AgenciaRequest entity)
		{
			Agencia au = _Mapper.Map<Agencia>(entity);
			au = _IAgenciaRepository.Create(au);
			AgenciaResponse res = _Mapper.Map<AgenciaResponse>(au);
			return res;
		}

		public List<AgenciaResponse> CreateMultiple(List<AgenciaRequest> request)
		{
			List<Agencia> au = _Mapper.Map<List<Agencia>>(request);
			au = _IAgenciaRepository.InsertMultiple(au);
			List<AgenciaResponse> res = _Mapper.Map<List<AgenciaResponse>>(au);
			return res;
		}

		public int Delete(object id)
		{
			return _IAgenciaRepository.Delete(id);
		}

		public int deleteMultipleItems(List<AgenciaRequest> request)
		{
			List<Agencia> au = _Mapper.Map<List<Agencia>>(request);
			int cantidad = _IAgenciaRepository.DeleteMultipleItems(au);
			return cantidad;
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		public List<AgenciaResponse> getAll()
		{
			List<Agencia> lsl = _IAgenciaRepository.GetAll();
			List<AgenciaResponse> res = _Mapper.Map<List<AgenciaResponse>>(lsl);
			return res;
		}

		public List<AgenciaResponse> getAutoComplete(string query)
		{
			throw new NotImplementedException();
		}

		public AgenciaResponse getById(object id)
		{
			Agencia au = _IAgenciaRepository.GetById(id);
			AgenciaResponse res = _Mapper.Map<AgenciaResponse>(au);
			return res;
		}

		public AgenciaResponse Update(AgenciaRequest entity)
		{
			Agencia au = _Mapper.Map<Agencia>(entity);
			au = _IAgenciaRepository.Update(au);
			AgenciaResponse res = _Mapper.Map<AgenciaResponse>(au);
			return res;
		}

		public List<AgenciaResponse> UpdateMultiple(List<AgenciaRequest> request)
		{
			List<Agencia> au = _Mapper.Map<List<Agencia>>(request);
			au = _IAgenciaRepository.UpdateMultiple(au);
			List<AgenciaResponse> res = _Mapper.Map<List<AgenciaResponse>>(au);
			return res;
		}
	}
}
