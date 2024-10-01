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
	public class PersonaBussines : IPersonaBussines
	{
		#region Declaracion de vcariables generales
		public readonly IPersonaRepository _IPersonaRepository = null;
		public readonly IMapper _Mapper;

		public PersonaBussines()
		{
		}
		#endregion

		#region constructor 
		public PersonaBussines(IMapper mapper)
		{
			_Mapper = mapper;
			_IPersonaRepository = new PersonaRepository();
		}
		#endregion

		public PersonaResponse Create(PersonaRequest entity)
		{
			Persona au = _Mapper.Map<Persona>(entity);
			au = _IPersonaRepository.Create(au);
			PersonaResponse res = _Mapper.Map<PersonaResponse>(au);
			return res;
		}

		public List<PersonaResponse> CreateMultiple(List<PersonaRequest> request)
		{
			List<Persona> au = _Mapper.Map<List<Persona>>(request);
			au = _IPersonaRepository.InsertMultiple(au);
			List<PersonaResponse> res = _Mapper.Map<List<PersonaResponse>>(au);
			return res;
		}

		public int Delete(object id)
		{
			return _IPersonaRepository.Delete(id);
		}

		public int deleteMultipleItems(List<PersonaRequest> request)
		{
			List<Persona> au = _Mapper.Map<List<Persona>>(request);
			int cantidad = _IPersonaRepository.DeleteMultipleItems(au);
			return cantidad;
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		public List<PersonaResponse> getAll()
		{
			List<Persona> lsl = _IPersonaRepository.GetAll();
			List<PersonaResponse> res = _Mapper.Map<List<PersonaResponse>>(lsl);
			return res;
		}

		public List<PersonaResponse> getAutoComplete(string query)
		{
			throw new NotImplementedException();
		}

		public PersonaResponse getById(object id)
		{
			Persona au = _IPersonaRepository.GetById(id);
			PersonaResponse res = _Mapper.Map<PersonaResponse>(au);
			return res;
		}

		public PersonaResponse Update(PersonaRequest entity)
		{
			Persona au = _Mapper.Map<Persona>(entity);
			au = _IPersonaRepository.Update(au);
			PersonaResponse res = _Mapper.Map<PersonaResponse>(au);
			return res;
		}

		public List<PersonaResponse> UpdateMultiple(List<PersonaRequest> request)
		{
			List<Persona> au = _Mapper.Map<List<Persona>>(request);
			au = _IPersonaRepository.UpdateMultiple(au);
			List<PersonaResponse> res = _Mapper.Map<List<PersonaResponse>>(au);
			return res;
		}
	}
}
