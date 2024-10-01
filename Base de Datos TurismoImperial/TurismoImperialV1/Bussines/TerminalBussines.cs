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
	public class TerminalBussines : ITerminalBussines
	{
		#region Declaracion de vcariables generales
		public readonly ITerminalRepository _ITerminalRepository = null;
		public readonly IMapper _Mapper;

		public TerminalBussines()
		{
		}
		#endregion

		#region constructor 
		public TerminalBussines(IMapper mapper)
		{
			_Mapper = mapper;
			_ITerminalRepository = new TerminalRepository();
		}
		#endregion

		public TerminalResponse Create(TerminalRequest entity)
		{
			Terminal au = _Mapper.Map<Terminal>(entity);
			au = _ITerminalRepository.Create(au);
			TerminalResponse res = _Mapper.Map<TerminalResponse>(au);
			return res;
		}

		public List<TerminalResponse> CreateMultiple(List<TerminalRequest> request)
		{
			List<Terminal> au = _Mapper.Map<List<Terminal>>(request);
			au = _ITerminalRepository.InsertMultiple(au);
			List<TerminalResponse> res = _Mapper.Map<List<TerminalResponse>>(au);
			return res;
		}

		public int Delete(object id)
		{
			return _ITerminalRepository.Delete(id);
		}

		public int deleteMultipleItems(List<TerminalRequest> request)
		{
			List<Terminal> au = _Mapper.Map<List<Terminal>>(request);
			int cantidad = _ITerminalRepository.DeleteMultipleItems(au);
			return cantidad;
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		public List<TerminalResponse> getAll()
		{
			List<Terminal> lsl = _ITerminalRepository.GetAll();
			List<TerminalResponse> res = _Mapper.Map<List<TerminalResponse>>(lsl);
			return res;
		}

		public List<TerminalResponse> getAutoComplete(string query)
		{
			throw new NotImplementedException();
		}

		public TerminalResponse getById(object id)
		{
			Terminal au = _ITerminalRepository.GetById(id);
			TerminalResponse res = _Mapper.Map<TerminalResponse>(au);
			return res;
		}

		public TerminalResponse Update(TerminalRequest entity)
		{
			Terminal au = _Mapper.Map<Terminal>(entity);
			au = _ITerminalRepository.Update(au);
			TerminalResponse res = _Mapper.Map<TerminalResponse>(au);
			return res;
		}

		public List<TerminalResponse> UpdateMultiple(List<TerminalRequest> request)
		{
			List<Terminal> au = _Mapper.Map<List<Terminal>>(request);
			au = _ITerminalRepository.UpdateMultiple(au);
			List<TerminalResponse> res = _Mapper.Map<List<TerminalResponse>>(au);
			return res;
		}
	}
}
