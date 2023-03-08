using ASP.NET.NovaPasta;
using ASP.NET.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListagemDeFuncionarios : ControllerBase
    {
        private readonly InterfaceFuncionario _funcionariorep;

        public ListagemDeFuncionarios(InterfaceFuncionario funcionariorep)
        {
            _funcionariorep = funcionariorep;
        }

        [HttpGet]
        public async Task<ActionResult<List<FuncionarioModel>>> ExibirFuncionarios()
        {
            List<FuncionarioModel> funcionarios = await _funcionariorep.ExibirTodosFuncionarios();
            return Ok(funcionarios);
        }
    }
}
