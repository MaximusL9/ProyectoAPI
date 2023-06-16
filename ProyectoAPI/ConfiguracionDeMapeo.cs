using AutoMapper;
using ProyectoAPI.Models;
using ProyectoAPI.Models.Dto;

namespace ProyectoAPI
{
    public class ConfiguracionDeMapeo:Profile
    {
        public ConfiguracionDeMapeo()
        {
            //Clientes
            CreateMap<Cliente, ClienteDto>().ReverseMap();
            CreateMap<ClienteDto, Cliente>().ReverseMap();

            CreateMap<Cliente, RegistrarClienteDto>().ReverseMap();
            CreateMap<Cliente, ModificarClienteDto>().ReverseMap();

            //Productos
            CreateMap<Producto, ProductoDto>().ReverseMap();
            CreateMap<ProductoDto, Producto>().ReverseMap();

            CreateMap<Producto, RegistrarProductoDto>().ReverseMap();
            CreateMap<Producto, ActualizarProductoDto>().ReverseMap();

            //Ventas
            CreateMap<Venta, VentaDto>().ReverseMap();
            CreateMap<VentaDto, Venta>().ReverseMap();

            CreateMap<Venta, RegistrarVentaDto>().ReverseMap();
            //CreateMap<Venta, ActualizarVentaDto>().ReverseMap();

            //Empleados
            CreateMap<Employee, EmployeeDto>().ReverseMap();
            CreateMap<EmployeeDto, EmployeeDto>().ReverseMap();
            
            
            CreateMap<Employee, EmployeeCreateDto>().ReverseMap();
            CreateMap<Employee, EmployeeUpdateDto>().ReverseMap();

        }
        

        
    }
}
