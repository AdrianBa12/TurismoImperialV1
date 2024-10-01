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
	public class IncidenciasRepository : GenericRepository<Incidencias>, IIncidenciasRepository
	{
		public List<Incidencias> GetAutoComplete(string query)
		{
			throw new NotImplementedException();
		}
	}
}
