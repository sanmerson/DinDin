using API.DTO.Entradas;
using API.Models;


namespace API.Services.Entradas {
    public interface IEntradaInterface {

        Task<ResponseModel<List<EntradasModel>>> ListarEntradas();

        Task<ResponseModel<EntradasModel>> BuscarEntradasPorId(int ID);

        Task<ResponseModel<List<EntradasModel>>> CriarEntrada(EntradasModel entrada);

        Task<ResponseModel<EntradasModel>> RemoverEntrada(int ID);

        Task<ResponseModel<EntradasModel>> EditarEntrada(EntradasDTO entrada);

    }
}
