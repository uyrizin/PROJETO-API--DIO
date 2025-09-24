using Microsoft.EntityFrameworkCore;
using projeto_api.Controllers.Entitys;

namespace projeto_api.context
{
    public class Agenda : DbContext
    {
        public Agenda(DbContextOptions<Agenda> options) : base(options) { }

        public DbSet<Contatos> Contatos { get; set; }
    }
}
