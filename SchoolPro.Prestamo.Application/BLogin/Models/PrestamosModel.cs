﻿namespace SchoolPro.Prestamo.Application.BLogin.Models
{
    public class PrestamosModel
    {
        public int? IdPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }

        public bool Estado { get; set; }
    
        public string Descripcion { get; set; }
    }
}
