using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPro.Common.Data.Base
{
    public abstract class AuditEntity<Ttype> : BaseEntity<int>
    {

        public override int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string? Codigo { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public DateTime? FechaConfirmacionDevolucion { get; set; }
        public bool? EstadoRecibido { get; set; }
        public bool? EstadoEntregado { get; set; }
        public bool? Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Descripcion { get; set; }


    }
}
