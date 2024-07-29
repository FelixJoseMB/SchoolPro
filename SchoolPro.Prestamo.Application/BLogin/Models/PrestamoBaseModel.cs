namespace SchoolPro.Prestamo.Application.BLogin.Models
{
    public abstract class PrestamoBaseModel : ModelBasePrestamo
    {
        public string Descripcion { get; set; }
        public bool? Estado { get; set; }
    }
}
