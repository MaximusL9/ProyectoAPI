using ProyectoAPI.Models;

namespace ProyectoAPI.Repository.IRepository
{
    public interface IVentasRepositery:IRepository<Venta>
    {
        Task<Venta> updateVentas(Venta entity);
    }
}
