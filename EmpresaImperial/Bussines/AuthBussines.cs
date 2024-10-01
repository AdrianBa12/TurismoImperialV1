using AutoMapper;
using IBussines;
using Bussines;
using Models.ResponseResponse;
using Models.RequestResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilSecurity.UtilSecurity;

namespace Bussines
{
	public class AuthBussines : IAuthBussines
	{
		private readonly IMapper _mapper;
		private readonly IUsuarioBussines _userBussnies;
		public AuthBussines(IMapper mapper)
		{
			_userBussnies = new UsuarioBussines(mapper);
			_mapper = mapper;
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		public LoginResponse login(LoginRequest request)
		{
			LoginResponse res = new LoginResponse();
			UsuarioResponse user = _userBussnies.GetByUserName(request.Username);
			if (user.Username != null && !(user.Username.ToLower() == request.Username.ToLower()))
			{
				res.Message = "Usuario y/o password invalido";
				res.Usuario = null;
				return res;
			}
			string newPassword = UtilCripto.encriptar_AES(request.Password);
			if (!(newPassword == user.Password))
			{
				res.Message = "Usuario y/o password invalido";
				res.Usuario = null;
				return res;
			}
			res.Usuario = user;
			return res;
		}
	}
}
