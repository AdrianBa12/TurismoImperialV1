﻿using AutoMapper;
using DBModel.DB;
using IBussines;
using IRepository;
using Repository;
using Models.RequestRequest;
using Models.ResponseResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines
{
	public class UsuarioBussines : IUsuarioBussines
	{
		#region declaracion variables generales
		public readonly IUsuarioRepository _IUsuarioRepository = null;
		public readonly IMapper _mapper;
		#endregion

		#region constructor
		public UsuarioBussines(IMapper mapper)
		{
			_mapper = mapper;
			_IUsuarioRepository = new UsuarioRepository();
		}
		#endregion


		/* inyección de dependencias */

		public UsuarioResponse Create(UsuarioRequest entity)
		{
			Usuarios cat = _mapper.Map<Usuarios>(entity);
			cat = _IUsuarioRepository.Create(cat);
			UsuarioResponse res = _mapper.Map<UsuarioResponse>(cat);
			return res;
		}

		public List<UsuarioResponse> CreateMultiple(List<UsuarioRequest> request)
		{
			List<Usuarios> cat = _mapper.Map<List<Usuarios>>(request);
			cat = _IUsuarioRepository.InsertMultiple(cat);
			List<UsuarioResponse> res = _mapper.Map<List<UsuarioResponse>>(cat);
			return res;
		}

		public int Delete(object id)
		{
			return _IUsuarioRepository.Delete(id);
		}

		public int deleteMultipleItems(List<UsuarioRequest> request)
		{
			List<Usuarios> cat = _mapper.Map<List<Usuarios>>(request);
			int cantidad = _IUsuarioRepository.DeleteMultipleItems(cat);
			return cantidad;
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		public List<UsuarioResponse> getAll()
		{
			List<Usuarios> lst = _IUsuarioRepository.GetAll();
			List<UsuarioResponse> res = _mapper.Map<List<UsuarioResponse>>(lst);
			return res;
		}

		public List<UsuarioResponse> getAutoComplete(string query)
		{
			throw new NotImplementedException();
		}

		public UsuarioResponse getById(object id)
		{
			Usuarios cat = _IUsuarioRepository.GetById(id);
			UsuarioResponse res = _mapper.Map<UsuarioResponse>(cat);
			return res;
		}

		public UsuarioResponse GetByUserName(string userName)
		{
			Usuarios user = _IUsuarioRepository.GetByUserName(userName);
			UsuarioResponse res = _mapper.Map<UsuarioResponse>(user);
			return res;
		}

		public UsuarioResponse Update(UsuarioRequest entity)
		{
			Usuarios cat = _mapper.Map<Usuarios>(entity);
			cat = _IUsuarioRepository.Update(cat);
			UsuarioResponse res = _mapper.Map<UsuarioResponse>(cat);
			return res;
		}

		public List<UsuarioResponse> UpdateMultiple(List<UsuarioRequest> request)
		{
			List<Usuarios> cat = _mapper.Map<List<Usuarios>>(request);
			cat = _IUsuarioRepository.UpdateMultiple(cat);
			List<UsuarioResponse> res = _mapper.Map<List<UsuarioResponse>>(cat);
			return res;
		}
	}
}
