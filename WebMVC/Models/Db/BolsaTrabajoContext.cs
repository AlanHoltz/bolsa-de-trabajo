using Microsoft.EntityFrameworkCore;

namespace BolsaTrabajo.Models.Db
{
    public class BolsaTrabajoContext: DbContext
    {
        public BolsaTrabajoContext(DbContextOptions options): base(options)
        {

        }
    }
}
