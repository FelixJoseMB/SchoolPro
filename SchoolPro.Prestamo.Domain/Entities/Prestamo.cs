using SchoolPro.Common.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPro.Prestamo.Domain.Entities
{
    public  class Prestamo : AuditEntity<int>
            
    {
        [Column("IdPrestamo")]
        public override short Id { get; set; }
    }
}
