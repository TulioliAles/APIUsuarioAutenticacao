using APIUsuarioAutenticacao.Models;
using Microsoft.EntityFrameworkCore;

namespace APIUsuarioAutenticacao.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {            
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}
