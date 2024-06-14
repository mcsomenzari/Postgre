using System.Data.Entity;

namespace ConsoleApp1
{
    public class PgContext : DbContext
    {
        public PgContext() : base("PgChecklist")
        {
        }

        public DbSet<CipSystem> Sistemas { get; set; }
    }

}