﻿namespace BiblioMonolitica.web.Data.Models
{
    public abstract class PrestamoBaseModel : ModelBasePrestamo
    {
        public required string Descripcion { get; set; }
        public bool? Estado { get; set; }
    }
}
