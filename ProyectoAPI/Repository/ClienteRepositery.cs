using ProyectoAPI.Data;
using ProyectoAPI.Models;
using ProyectoAPI.Repository.IRepository;

namespace ProyectoAPI.Repository
{
    public class ClienteRepositery : Repository<Cliente>, IClientesRepositery
    {
        private readonly ProyectContext _db;

        public ClienteRepositery(ProyectContext db):base(db)
        {
            _db = db;
        }

        public async Task<Cliente> updateCliente(Cliente entity)
        {
            _db.Clientes.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
