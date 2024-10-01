using IRepository;
using Repository.Generic;
using DBModel.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
	public class BusesRepository : GenericRepository<Buses>, IBusesRepository
	{
		public List<Buses> GetAutoComplete(string query)
		{
			throw new NotImplementedException();
		}


	}
}
