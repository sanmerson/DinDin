using API.Models;
using API.Models.Acoes;
using API.Models.Economias;
using API.Models.Saidas;
using Microsoft.EntityFrameworkCore;

namespace API.Context {
    public class AppDbContext : DbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<EntradasModel> entradas { get; set; }
        public DbSet<SaidasModel> saidas { get; set; }
        public DbSet<EconomiasModel> economias { get; set; }
        public DbSet<AcoesModel> acoes { get; set; }
    }
}
