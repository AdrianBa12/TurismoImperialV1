using DBModel.DB;
using IRepository;
using Models.RequestResponse;
using Repository.Generic;

namespace Repository
{
    public class UsuarioRepository : GenericRepository<Usuario>, IUsuarioRepository
    {

        public List<Usuario> GetAutoComplete(string query)
        {
            throw new NotImplementedException();
        }

        public Usuario GetByUserName(string userName)
        {
            Usuario user = dbSet.Where(x => x.Username == userName).FirstOrDefault();
            return user;

        }
    }
}