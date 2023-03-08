using ASP.NET.NovaPasta;
using ASP.NET.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CriaçãoDeFuncionario : ControllerBase
    {
        private readonly InterfaceFuncionario _funcionariorep;

        public CriaçãoDeFuncionario(InterfaceFuncionario funcionariorep)
        {
            _funcionariorep = funcionariorep;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<FuncionarioModel>>> BuscarPorID(int id)
        {
            FuncionarioModel funcionario = await _funcionariorep.BuscarFuncionarioID(id);
            return Ok(funcionario);
        }

        [HttpPost]
        public async Task<ActionResult<FuncionarioModel>> Cadastrar([FromBody] FuncionarioModel funcionarioModel)
        {
            FuncionarioModel funcionario = await _funcionariorep.AdicionarFuncionario(funcionarioModel);
            return Ok(funcionario); 
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<FuncionarioModel>> Atualizar([FromBody] FuncionarioModel funcionarioModel, int id)
        {
            funcionarioModel.Id = id;
            FuncionarioModel funcionario = await _funcionariorep.AtualizarFuncionario(funcionarioModel, id);
            return Ok(funcionario);
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<FuncionarioModel>> Apagar([FromBody] FuncionarioModel funcionarioModel, int id)
        {
            bool apagado = await _funcionariorep.ApagarFuncionario(id);
            return Ok(apagado);
        }
    }
}
