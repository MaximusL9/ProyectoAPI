using ProyectoAPI.Data;
using ProyectoAPI.Models;
using ProyectoAPI.Repository.IRepository;

namespace ProyectoAPI.Repository
{
    public class VentaRepositery : Repository<Venta>, IVentasRepositery
    {
        private readonly ProyectContext _db;

        public VentaRepositery(ProyectContext db):base(db)
        {
            this._db = db;
        }

        public  async Task<Venta> updateVentas(Venta entity)
        {
            _db.Ventas.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
