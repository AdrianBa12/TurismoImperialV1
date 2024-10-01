using Models.RequestRequest;
using Models.ResponseResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilInterface;

namespace IBussines
{
	public interface IUsuarioBussines : ICRUDBussines<UsuarioRequest,UsuarioResponse>
	{
		UsuarioResponse GetByUserName(string userName);
	}
}
