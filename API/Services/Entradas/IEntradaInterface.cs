using API.Models;


namespace API.Services.Entradas {
    public interface IEntradaInterface {

        Task<ResponseModel<List<EntradasModel>>> ListarEntradas();

        Task<ResponseModel<EntradasModel>> BuscarEntradasPorId(int ID);

    }
}
