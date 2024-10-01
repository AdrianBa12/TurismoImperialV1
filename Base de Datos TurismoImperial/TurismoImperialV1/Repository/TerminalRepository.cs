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
	public class TerminalRepository : GenericRepository<Terminal>, ITerminalRepository
	{
		public List<Terminal> GetAutoComplete(string query)
		{
			throw new NotImplementedException();
		}
	}
}
