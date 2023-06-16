using ProyectoAPI.Data;
using ProyectoAPI.Models;
using ProyectoAPI.Repository.IRepository;

namespace ProyectoAPI.Repository
{
    public class ProductoRepositery : Repository<Producto>, IProductoRepositery
    {
        private readonly ProyectContext _db;

        public ProductoRepositery(ProyectContext db):base(db)
        {
            _db = db;
        }

        public async Task<Producto> updateProducto(Producto entity)
        {
            _db.Productos.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
