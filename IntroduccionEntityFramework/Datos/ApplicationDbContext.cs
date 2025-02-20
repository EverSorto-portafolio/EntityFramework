using IntroduccionEntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace IntroduccionEntityFramework.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
        public DbSet<Categoria> Categorias { get; set; }
    }
}


