

using Microsoft.EntityFrameworkCore;
using System.Security.AccessControl;

namespace BiblioMonolitica.web.Data.Context
{
    public class PrestamoContext : DbContext
    {
        #region "Constructor"
        public PrestamoContext(DbContextOptions<PrestamoContext> options) : base(options)
        {

        }
        #endregion

        #region "Db Sets"
        public DbSet<SchoolPro.Prestamo.Domain.Entities.Prestamo> Prestamo { get; set; }
        public DbContextOptions<PrestamoContext> Options { get; }
        #endregion
    }
}
