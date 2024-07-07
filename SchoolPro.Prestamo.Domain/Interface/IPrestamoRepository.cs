
using SchoolPro.Common.Data.Repository;
using SchoolPro.Common.Data.Base;

namespace SchoolPro.Prestamo.Domain.Interface
{
    public interface IPrestamoRepository : IbaseRepository<Domain.Entities.Prestamo, int>

    {
        List<Prestamo.Domain.Entities.Prestamo> GetPrestamobyPrestamoId(int PrestamoId); 
    }
}
