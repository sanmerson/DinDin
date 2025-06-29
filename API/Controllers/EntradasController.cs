using API.Models;
using API.Services.Entradas;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class EntradasController : ControllerBase {
        private readonly IEntradaInterface _entradainterface;

        public EntradasController(IEntradaInterface entradaInterface) {
            _entradainterface = entradaInterface;
        }

        [HttpGet("ListarEntradas")]
        public async Task<ActionResult<ResponseModel<List<EntradasModel>>>> ListarEntradas() {
            var entradas = await _entradainterface.ListarEntradas();
            return Ok(entradas);
        }

        [HttpGet("BuscarEntradasPorId/{ID}")]
        public async Task<ActionResult<ResponseModel<EntradasModel>>> BuscarEntradasPorId(int ID) {
            var entrada = await _entradainterface.BuscarEntradasPorId(ID);
            return Ok(entrada);
        }
    }
}
