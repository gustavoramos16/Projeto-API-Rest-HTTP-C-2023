using ASP.NET.NovaPasta;
using ASP.NET.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListagemDeEquipes: ControllerBase
    {
        private readonly InterfaceEquipe _equiperep;

        public ListagemDeEquipes(InterfaceEquipe equiperep)
        {
            _equiperep = equiperep;
        }

        [HttpGet]
        public async Task<ActionResult<List<EquipeModel>>> ExibirEquipes()
        {
            List<EquipeModel> equipes = await _equiperep.ExibirTodasEquipes();
            return Ok(equipes);
        }
    }
}
