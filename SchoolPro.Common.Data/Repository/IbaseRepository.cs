using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPro.Common.Data.Repository
{
    public interface IbaseRepository<Tentity, Ttype> where Tentity : class
    {
        void Save(Tentity Tentity);
        void Update(Tentity Tentity);
        void Remove(Tentity Tentity);

        List<Tentity> GetAll();
        Tentity GetEntityBy(Ttype id);
        bool Exists(Expression<Func<Tentity, bool>> Filter);
    }
}
