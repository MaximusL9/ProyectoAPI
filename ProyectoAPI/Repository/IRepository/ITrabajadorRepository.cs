using ProyectoAPI.Models;

namespace ProyectoAPI.Repository.IRepository
{
    public interface ITrabajadorRepository:IRepository<Employee>
    {
        Task<Employee> Update(Employee entity);
    }
}
