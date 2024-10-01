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
	public class ConductorRepository : GenericRepository<Conductor>, IConductorRepository
	{
		public List<Conductor> GetAutoComplete(string query)
		{
			throw new NotImplementedException();
		}
	}
}
