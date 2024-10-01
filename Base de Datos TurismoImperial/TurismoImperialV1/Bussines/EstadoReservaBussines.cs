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
	public class EstadoReservaBussines : IEstadoReservaBussines
	{
		#region Declaracion de vcariables generales
		public readonly IEstadoReservaRepository _IEstadoReservaRepository = null;
		public readonly IMapper _Mapper;

		public EstadoReservaBussines()
		{
		}
		#endregion

		#region constructor 
		public EstadoReservaBussines(IMapper mapper)
		{
			_Mapper = mapper;
			_IEstadoReservaRepository = new EstadoReservaRepository();
		}
		#endregion

		public EstadoReservaResponse Create(EstadoReservaRequest entity)
		{
			EstadoReserva au = _Mapper.Map<EstadoReserva>(entity);
			au = _IEstadoReservaRepository.Create(au);
			EstadoReservaResponse res = _Mapper.Map<EstadoReservaResponse>(au);
			return res;
		}

		public List<EstadoReservaResponse> CreateMultiple(List<EstadoReservaRequest> request)
		{
			List<EstadoReserva> au = _Mapper.Map<List<EstadoReserva>>(request);
			au = _IEstadoReservaRepository.InsertMultiple(au);
			List<EstadoReservaResponse> res = _Mapper.Map<List<EstadoReservaResponse>>(au);
			return res;
		}

		public int Delete(object id)
		{
			return _IEstadoReservaRepository.Delete(id);
		}

		public int deleteMultipleItems(List<EstadoReservaRequest> request)
		{
			List<EstadoReserva> au = _Mapper.Map<List<EstadoReserva>>(request);
			int cantidad = _IEstadoReservaRepository.DeleteMultipleItems(au);
			return cantidad;
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		public List<EstadoReservaResponse> getAll()
		{
			List<EstadoReserva> lsl = _IEstadoReservaRepository.GetAll();
			List<EstadoReservaResponse> res = _Mapper.Map<List<EstadoReservaResponse>>(lsl);
			return res;
		}

		public List<EstadoReservaResponse> getAutoComplete(string query)
		{
			throw new NotImplementedException();
		}

		public EstadoReservaResponse getById(object id)
		{
			EstadoReserva au = _IEstadoReservaRepository.GetById(id);
			EstadoReservaResponse res = _Mapper.Map<EstadoReservaResponse>(au);
			return res;
		}

		public EstadoReservaResponse Update(EstadoReservaRequest entity)
		{
			EstadoReserva au = _Mapper.Map<EstadoReserva>(entity);
			au = _IEstadoReservaRepository.Update(au);
			EstadoReservaResponse res = _Mapper.Map<EstadoReservaResponse>(au);
			return res;
		}

		public List<EstadoReservaResponse> UpdateMultiple(List<EstadoReservaRequest> request)
		{
			List<EstadoReserva> au = _Mapper.Map<List<EstadoReserva>>(request);
			au = _IEstadoReservaRepository.UpdateMultiple(au);
			List<EstadoReservaResponse> res = _Mapper.Map<List<EstadoReservaResponse>>(au);
			return res;
		}
	}
}
