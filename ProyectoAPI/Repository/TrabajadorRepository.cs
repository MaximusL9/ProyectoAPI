using ProyectoAPI.Data;
using ProyectoAPI.Models;
using ProyectoAPI.Repository.IRepository;

namespace ProyectoAPI.Repository
{
    public class TrabajadorRepository:Repository<Employee>, ITrabajadorRepository
    {
        private readonly ProyectContext _db;

        public TrabajadorRepository(ProyectContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Employee> Update(Employee entity)
        {
            _db.Employees.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
