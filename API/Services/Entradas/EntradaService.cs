using API.Context;
using API.DTO.Entradas;
using API.Models;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;
using System.Threading.Tasks;

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

        public async Task<ResponseModel<EntradasModel>> RemoverEntrada(int ID) {
            ResponseModel<EntradasModel> Response = new ResponseModel<EntradasModel>();

            try {
                var resultado = await BuscarEntradasPorId(ID);
                var entrada = resultado.Dados;

                _context.entradas.Remove(entrada);
                await _context.SaveChangesAsync();

                Response.Mensagem = "Entrada Removida com Sucesso";
                return Response;
            } catch (Exception ex) {
                Response.Mensagem = ex.Message;
                Response.Status = false;
                return Response;
            }
        }

        public async Task<ResponseModel<List<EntradasModel>>> CriarEntrada(EntradasModel entrada)  {
            ResponseModel<List<EntradasModel>> Response = new ResponseModel<List<EntradasModel>>();

            try {

                var entradaAdicionada = new EntradasModel() {
                    Nome = entrada.Nome,
                    Valor = entrada.Valor,
                    DataEntrada = entrada.DataEntrada,
                    Recorrente = entrada.Recorrente,
                    Tipo = entrada.Tipo,
                };

                _context.Add(entradaAdicionada);
                await _context.SaveChangesAsync();

                Response.Dados = await _context.entradas.ToListAsync();
                Response.Mensagem = "Entrada adicionada com sucesso";
                return Response;

            } catch (Exception ex) {
                Response.Mensagem = ex.Message;
                Response.Status = false;
                return Response;
            }
        }

        public async Task<ResponseModel<EntradasModel>> EditarEntrada(EntradasDTO entrada) {
            ResponseModel<EntradasModel> Response = new ResponseModel<EntradasModel>();
            try {
                var resultado = await BuscarEntradasPorId(entrada.Id);
                var entradaParaEditar = resultado.Dados;

                if (entrada.Nome != null)
                    entradaParaEditar.Nome = entrada.Nome;

                if (entrada.Valor.HasValue)
                    entradaParaEditar.Valor = entrada.Valor.Value;

                if (entrada.DataEntrada.HasValue)
                    entradaParaEditar.DataEntrada = entrada.DataEntrada.Value;

                if (entrada.Recorrente.HasValue)
                    entradaParaEditar.Recorrente = entrada.Recorrente.Value;

                if (entrada.Tipo.HasValue)
                    entradaParaEditar.Tipo = entrada.Tipo.Value;

                _context.Update(entradaParaEditar);
                await _context.SaveChangesAsync();

                resultado = await BuscarEntradasPorId(entrada.Id);
                var entradaModificada = resultado.Dados;

                Response.Dados = entradaModificada;
                Response.Mensagem = "Entrada alterada com sucesso";
                return Response;

            } catch (Exception ex) {
                Response.Mensagem = ex.Message;
                Response.Status = false;
                return Response;
            }
        }

    }
}
