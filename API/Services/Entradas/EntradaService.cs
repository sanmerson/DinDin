using API.Context;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Services.Entradas {
    public class EntradaService : IEntradaInterface {

        private readonly AppDbContext _context;
        public EntradaService(AppDbContext context) {
            _context = context;
        }

        public async Task<ResponseModel<EntradasModel>> BuscarEntradasPorId(int ID) {

            ResponseModel<EntradasModel> Response = new ResponseModel<EntradasModel>();

            try {

                var entrada = await _context.entradas.FirstOrDefaultAsync(EntradaDatabase => EntradaDatabase.Id == ID);
                if (entrada == null) {
                    Response.Mensagem = "Entrada não encontrada";
                    return Response;
                }
                Response.Dados = entrada;
                Response.Mensagem = "Sucesso";
                return Response;

            } catch (Exception ex) {

                Response.Mensagem = ex.Message;
                Response.Status = false;
                return Response;
            }
        }

        public async Task<ResponseModel<List<EntradasModel>>> ListarEntradas() {

            ResponseModel<List<EntradasModel>> Response = new ResponseModel<List<EntradasModel>>();

            try {
                var entradas = await _context.entradas.ToListAsync();
                Response.Dados = entradas;
                Response.Mensagem = "Sucesso";
                return Response;

            } catch (Exception ex) {
                Response.Mensagem = ex.Message;
                Response.Status = false;
                return Response;
            }
        }
    }
}
