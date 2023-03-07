using ASP.NET.Data;
using ASP.NET.NovaPasta;
using ASP.NET.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET.Repositorios
{
    public class EquipeRepositorio : InterfaceEquipe
    {
        private readonly SistemaDB _bancodados;
        public EquipeRepositorio(SistemaDB sistemaEquipe)
        {
            _bancodados = sistemaEquipe;
        }

        public async Task<List<EquipeModel>> ExibirTodasEquipes()
        {
            return await _bancodados.Equipes.ToListAsync();
        }

        public async Task<EquipeModel> BuscarEquipeID(int id)
        {
            return await _bancodados.Equipes.FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<EquipeModel> AdicionarEquipe(EquipeModel equipe)
        {
            _bancodados.Equipes.Add(equipe);
            _bancodados.SaveChanges();

            return equipe;
        }

        public async Task<EquipeModel> AtualizarEquipe(EquipeModel equipe, int id)
        {
            EquipeModel equipeID = await BuscarEquipeID(id);

            if( equipeID == null)
            {
                throw new Exception($"O ID: {id} não foi encontrado");
            }
            
            equipeID.Nome = equipe.Nome;
            equipeID.setor = equipe.setor;

            _bancodados.Equipes.Update(equipeID);
            _bancodados.SaveChanges();

            return equipeID;
        }

        public async Task<bool> ApagarEquipe(int id)
        {
            EquipeModel equipeID = await BuscarEquipeID(id);

            if (equipeID == null)
            {
                throw new Exception($"O ID: {id} relacionado a equipe não foi encontrado");
            }

            _bancodados.Equipes.Remove(equipeID);
            _bancodados.SaveChanges();

            return true;
        }



    }
}
