namespace ProyectoForm.Dto
{
    public class RegistrarVentaDto
    {
        public double TotalVenta { get; set; }

        public double cambio { get; set; }

        public double PrecioProducto { get; set; }

        public int Cantidad { get; set; }
        public int IdProducto { get; set; }
    }
}
