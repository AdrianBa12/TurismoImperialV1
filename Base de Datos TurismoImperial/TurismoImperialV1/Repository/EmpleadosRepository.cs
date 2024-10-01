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
    public class EmpleadosRepository : GenericRepository<Empleados>, IEmpleadosRepository
	{
		public List<Empleados> GetAutoComplete(string query)
		{
			throw new NotImplementedException();
		}
	}
}
