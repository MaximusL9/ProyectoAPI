using ProyectoAPI.Models;

namespace ProyectoAPI.Repository.IRepository
{
    public interface IClientesRepositery:IRepository<Cliente>

    {
        public Task<Cliente> updateCliente(Cliente entity);
    }
}
