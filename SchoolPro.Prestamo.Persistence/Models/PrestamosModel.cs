namespace BiblioMonolitica.web.Data.Models
{
    public class PrestamoModel
    {
        public int? IdPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }

        public bool Estado { get; set; }
    
        public string Descripcion { get; set; }
    }
}
