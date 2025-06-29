using API.Models;
using API.Models.Saidas;

namespace API.Services.Saidas {
    public class SaidaService : ISaidaInterface {
        public Task<List<ResponseModel<SaidasModel>>> ListarSaidas() {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<SaidasModel>> SaidaPorId() {
            throw new NotImplementedException();
        }
    }
}
