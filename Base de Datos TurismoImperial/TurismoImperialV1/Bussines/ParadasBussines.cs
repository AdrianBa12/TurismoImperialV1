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
	public class ParadasBussines : IParadasBussines
	{
		#region Declaracion de vcariables generales
		public readonly IParadasRepository _IParadasRepository = null;
		public readonly IMapper _Mapper;

		public ParadasBussines()
		{
		}
		#endregion

		#region constructor 
		public ParadasBussines(IMapper mapper)
		{
			_Mapper = mapper;
			_IParadasRepository = new ParadasRepository();
		}
		#endregion

		public ParadasResponse Create(ParadasRequest entity)
		{
			Paradas au = _Mapper.Map<Paradas>(entity);
			au = _IParadasRepository.Create(au);
			ParadasResponse res = _Mapper.Map<ParadasResponse>(au);
			return res;
		}

		public List<ParadasResponse> CreateMultiple(List<ParadasRequest> request)
		{
			List<Paradas> au = _Mapper.Map<List<Paradas>>(request);
			au = _IParadasRepository.InsertMultiple(au);
			List<ParadasResponse> res = _Mapper.Map<List<ParadasResponse>>(au);
			return res;
		}

		public int Delete(object id)
		{
			return _IParadasRepository.Delete(id);
		}

		public int deleteMultipleItems(List<ParadasRequest> request)
		{
			List<Paradas> au = _Mapper.Map<List<Paradas>>(request);
			int cantidad = _IParadasRepository.DeleteMultipleItems(au);
			return cantidad;
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		public List<ParadasResponse> getAll()
		{
			List<Paradas> lsl = _IParadasRepository.GetAll();
			List<ParadasResponse> res = _Mapper.Map<List<ParadasResponse>>(lsl);
			return res;
		}

		public List<ParadasResponse> getAutoComplete(string query)
		{
			throw new NotImplementedException();
		}

		public ParadasResponse getById(object id)
		{
			Paradas au = _IParadasRepository.GetById(id);
			ParadasResponse res = _Mapper.Map<ParadasResponse>(au);
			return res;
		}

		public ParadasResponse Update(ParadasRequest entity)
		{
			Paradas au = _Mapper.Map<Paradas>(entity);
			au = _IParadasRepository.Update(au);
			ParadasResponse res = _Mapper.Map<ParadasResponse>(au);
			return res;
		}

		public List<ParadasResponse> UpdateMultiple(List<ParadasRequest> request)
		{
			List<Paradas> au = _Mapper.Map<List<Paradas>>(request);
			au = _IParadasRepository.UpdateMultiple(au);
			List<ParadasResponse> res = _Mapper.Map<List<ParadasResponse>>(au);
			return res;
		}
	}
}
