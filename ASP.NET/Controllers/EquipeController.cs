using ASP.NET.NovaPasta;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipeController : ControllerBase
    {

        [HttpGet]
        public ActionResult<List<EquipeModel>> BuscarEquipes()
        {
            return Ok();
        }
    }
}
