using DBModel.DB;
using Models.RequestResponse;
using UtilInterface;

namespace IRepository
{
    public interface IUsuarioRepository: ICRUDRepositorio<Usuario>
    {
        Usuario GetByUserName(string userName);
    }
}