using ProyectoAPI.Models;

namespace ProyectoAPI.Repository.IRepository
{
    public interface IProductoRepositery:IRepository<Producto>
    {
        Task<Producto> updateProducto(Producto entity);
    }
}
