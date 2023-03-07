using ASP.NET.NovaPasta;

namespace ASP.NET.Repositorios.Interfaces
{
    public interface InterfaceEquipe
    {
        Task<List<EquipeModel>> ExibirTodasEquipes();

        Task<EquipeModel> BuscarEquipeID(int id);

        Task<EquipeModel> AdicionarEquipe(EquipeModel equipe);

        Task<EquipeModel> AtualizarEquipe(EquipeModel equipe, int id);

        Task<bool> ApagarEquipe(int id);

    }
}
