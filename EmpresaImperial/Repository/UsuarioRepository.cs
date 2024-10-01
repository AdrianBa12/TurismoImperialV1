using DBModel.DB;
using IRepository;
using Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UsuarioRepository : GenericRepository<Usuarios>, IUsuarioRepository
    {
		public List<Usuarios> GetAutoComplete(string query)
		{
			throw new NotImplementedException();
		}

		public Usuarios GetByUserName(string userName)
		{
			Usuarios user = dbSet.Where(x => x. CorreoElectronico == userName).FirstOrDefault();
			return user;

		}
	}
}
