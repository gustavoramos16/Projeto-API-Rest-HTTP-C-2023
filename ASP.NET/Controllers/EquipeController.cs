using ASP.NET.NovaPasta;
using ASP.NET.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipeController : ControllerBase
    {
        private readonly InterfaceEquipe _equiperep;

        public EquipeController(InterfaceEquipe equiperep)
        {
            _equiperep = equiperep;
        }

        [HttpGet]
        public async Task<ActionResult<List<EquipeModel>>> BuscarEquipes()
        {
            List<EquipeModel> equipes = await _equiperep.ExibirTodasEquipes();
            return Ok(equipes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<EquipeModel>>> BuscarPorID(int id)
        {
            EquipeModel equipe = await _equiperep.BuscarEquipeID(id);
            return Ok(equipe);
        }

        [HttpPost]
        public async Task<ActionResult<EquipeModel>> Cadastrar([FromBody] EquipeModel equipeModel)
        {
            EquipeModel equipe = await _equiperep.AdicionarEquipe(equipeModel);
            return Ok(equipe);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<EquipeModel>> Atualizar([FromBody] EquipeModel equipeModel, int id)
        {
            equipeModel.Id = id;
            EquipeModel equipe = await _equiperep.AtualizarEquipe(equipeModel, id);
            return Ok(equipe);
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<EquipeModel>> Apagar([FromBody] EquipeModel equipeModel, int id)
        {
            bool apagado = await _equiperep.ApagarEquipe(id);
            return Ok(apagado);
        }
    }
}
