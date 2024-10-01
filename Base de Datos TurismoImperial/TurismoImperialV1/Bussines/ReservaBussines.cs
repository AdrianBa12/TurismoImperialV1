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
	public class ReservaBussines : IReservaBussines
	{
		#region Declaracion de vcariables generales
		public readonly IReservaRepository _IReservaRepository = null;
		public readonly IMapper _Mapper;

		public ReservaBussines()
		{
		}
		#endregion

		#region constructor 
		public ReservaBussines(IMapper mapper)
		{
			_Mapper = mapper;
			_IReservaRepository = new ReservaRepository();
		}
		#endregion

		public ReservaResponse Create(ReservaRequest entity)
		{
			Reserva au = _Mapper.Map<Reserva>(entity);
			au = _IReservaRepository.Create(au);
			ReservaResponse res = _Mapper.Map<ReservaResponse>(au);
			return res;
		}

		public List<ReservaResponse> CreateMultiple(List<ReservaRequest> request)
		{
			List<Reserva> au = _Mapper.Map<List<Reserva>>(request);
			au = _IReservaRepository.InsertMultiple(au);
			List<ReservaResponse> res = _Mapper.Map<List<ReservaResponse>>(au);
			return res;
		}

		public int Delete(object id)
		{
			return _IReservaRepository.Delete(id);
		}

		public int deleteMultipleItems(List<ReservaRequest> request)
		{
			List<Reserva> au = _Mapper.Map<List<Reserva>>(request);
			int cantidad = _IReservaRepository.DeleteMultipleItems(au);
			return cantidad;
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		public List<ReservaResponse> getAll()
		{
			List<Reserva> lsl = _IReservaRepository.GetAll();
			List<ReservaResponse> res = _Mapper.Map<List<ReservaResponse>>(lsl);
			return res;
		}

		public List<ReservaResponse> getAutoComplete(string query)
		{
			throw new NotImplementedException();
		}

		public ReservaResponse getById(object id)
		{
			Reserva au = _IReservaRepository.GetById(id);
			ReservaResponse res = _Mapper.Map<ReservaResponse>(au);
			return res;
		}

		public ReservaResponse Update(ReservaRequest entity)
		{
			Reserva au = _Mapper.Map<Reserva>(entity);
			au = _IReservaRepository.Update(au);
			ReservaResponse res = _Mapper.Map<ReservaResponse>(au);
			return res;
		}

		public List<ReservaResponse> UpdateMultiple(List<ReservaRequest> request)
		{
			List<Reserva> au = _Mapper.Map<List<Reserva>>(request);
			au = _IReservaRepository.UpdateMultiple(au);
			List<ReservaResponse> res = _Mapper.Map<List<ReservaResponse>>(au);
			return res;
		}
	}
}
