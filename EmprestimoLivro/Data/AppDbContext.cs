using EmprestimoLivro.Models;
using Microsoft.EntityFrameworkCore;

namespace EmprestimoLivro.Data
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<EmprestimosModel> Emprestimos { get; set; }
    }
}
