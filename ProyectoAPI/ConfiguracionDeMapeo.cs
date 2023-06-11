using AutoMapper;
using ProyectoAPI.Models;
using ProyectoAPI.Models.Dto;

namespace ProyectoAPI
{
    public class ConfiguracionDeMapeo:Profile
    {
        public ConfiguracionDeMapeo()
        {
            CreateMap<Cliente, ClienteDto>().ReverseMap();
            CreateMap<Producto, ProductoDto>().ReverseMap();
            CreateMap<Venta, VentaDto>().ReverseMap();
            CreateMap<Employee, EmployeeDto>().ReverseMap();
            CreateMap<RegistrarVentaDto, Venta>().ReverseMap();
            CreateMap<ActualizarProductoDto, Producto>().ReverseMap();
            CreateMap<RegistrarProductoDto, Producto>().ReverseMap();
            CreateMap<RegistrarClienteDto, Cliente>().ReverseMap();
            CreateMap<ModificarClienteDto, Cliente>().ReverseMap();
            CreateMap<EmployeeCreateDto, Employee>().ReverseMap();
            CreateMap<EmployeeUpdateDto, Employee>().ReverseMap();

        }
        

        
    }
}
