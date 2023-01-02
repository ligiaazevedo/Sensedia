using Microsoft.EntityFrameworkCore;

namespace API.Context
{
    public class SensediaContext : DbContext
    {
        public SensediaContext(DbContextOptionsBuilder<SensediaContext> options)
        {

        }
    }
}
