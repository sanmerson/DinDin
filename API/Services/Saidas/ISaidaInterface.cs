using API.Models;
using API.Models.Saidas;

namespace API.Services.Saidas {
    public interface ISaidaInterface {

        Task<List<ResponseModel<SaidasModel>>> ListarSaidas();

        Task<ResponseModel<SaidasModel>> SaidaPorId();
    }
}
