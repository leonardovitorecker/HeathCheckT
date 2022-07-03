using HeathCheck1.Models;
using Microsoft.EntityFrameworkCore;

namespace HeathCheck1.Database
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> opcoes)
   : base(opcoes)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {


            base.OnModelCreating(builder);
        }

        public DbSet<EspecialidadeModel> especialidades { get; set; }
        public DbSet<EspecialistaModel> especialistas { get; set; }
        public DbSet<UsuarioModel> usuarios { get; set; }
     
    }
}
