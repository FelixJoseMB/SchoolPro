using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPro.Common.Data.Base
{
    public abstract class BaseEntity<Ttype>
    {
        public abstract Ttype Id { get; set; }

    }
}