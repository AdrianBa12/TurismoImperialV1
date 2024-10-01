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
	public class RevisionesBusesRepository : GenericRepository<RevisionesBuses>, IRevisionesBusesRepository
	{
		public List<RevisionesBuses> GetAutoComplete(string query)
		{
			throw new NotImplementedException();
		}
	}
}
