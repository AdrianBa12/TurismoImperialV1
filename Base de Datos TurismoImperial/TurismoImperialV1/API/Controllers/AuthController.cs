﻿using AutoMapper;
using Bussines;

using IBussines;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Models.RequestResponse;

using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthBussines _authBussines;
        private readonly IMapper _mapper;

        public AuthController(IMapper mapper)
        {
            _mapper = mapper;
			_authBussines = new AuthBussines(mapper);
        }

        [HttpGet]
        public IActionResult get()
        {
            return Ok("El servicio está escuchando");
        }

        /// <summary>
        /// Realiza el proceso de login
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult post([FromBody] LoginRequest request)
        {
            LoginResponse res = _authBussines.login(request);
            if (res.Usuario == null || res.Usuario.IdUsuario == 0)
            {
                return Ok(res);
            }

            res.Token = CreateToken(res.Usuario);
            res.RefreshToken = new Guid().ToString();
            res.Success = true;
            return Ok(res);
        }



        private static string CreateToken(UsuarioResponse user)
        {

            //create claims details based on the user information
            IConfigurationBuilder configurationBuild = new ConfigurationBuilder();
            configurationBuild = configurationBuild.AddJsonFile("appsettings.json");
            IConfiguration configurationFile = configurationBuild.Build();
            // Leemos el archivo de configuración.


            //string hahaha = configurationFile["Jwt:Subject"];

            int TimpoVidaToken = int.Parse(configurationFile["Jwt:TimeJWTMin"]);
            var claims = new[] {
                        new Claim(JwtRegisteredClaimNames.Sub, configurationFile["Jwt:Subject"]),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                        new Claim("UserId", user.IdUsuario.ToString()),
                        new Claim("DisplayName", $"jperez"),
                        new Claim("UserName", user.Username),
                        //new Claim("Password", user.Contraseña),
                        //new Claim(ClaimTypes.Role, user.Role.Id.ToString()),
                        //new Claim("RoleName", user.Role.Description),
                        //new Claim("Email", user.Email)
                    };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configurationFile["Jwt:Key"]));
            var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                configurationFile["Jwt:Issuer"],
                configurationFile["Jwt:Audience"],
                claims,
                expires: DateTime.UtcNow.AddMinutes(TimpoVidaToken),
                signingCredentials: signIn);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }


    }
}

