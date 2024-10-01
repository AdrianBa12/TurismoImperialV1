using DBModel.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilInterface;

namespace IRepository
{
    public interface IUsuarioRepository : ICRUDRepository<Usuarios>
    {
        Usuarios GetByUserName(string userName);
    }
}
