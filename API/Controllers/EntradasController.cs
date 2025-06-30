using API.DTO.Entradas;
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

        [HttpPost("CriarEntrada")]
        public async Task<ActionResult<ResponseModel<List<EntradasModel>>>> CriarEntrada(EntradasModel criarEntrada) {
            var entrada = await _entradainterface.CriarEntrada(criarEntrada);
            return Ok(entrada);
        }

        [HttpPost("RemoverEntrada/{ID}")]
        public async Task<ActionResult<ResponseModel<List<EntradasModel>>>> RemoverEntrada(int ID) {
            var entrada = await _entradainterface.RemoverEntrada(ID);
            return Ok(entrada);
        }

        [HttpPost("EditarEntrada/")]
        public async Task<ActionResult<ResponseModel<EntradasModel>>> EditarEntrada(EntradasDTO editarEntrada) {
            var entrada = await _entradainterface.EditarEntrada(editarEntrada);
            return Ok(entrada);
        }
    }
}
