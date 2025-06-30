using API.Context;
using API.Models;
using API.Models.Saidas;

namespace API.Services.Saidas {
    public class SaidaService : ISaidaInterface {
        private readonly AppDbContext _context;

        public SaidaService(AppDbContext context) {
            _context = context;
        }
    }
}
