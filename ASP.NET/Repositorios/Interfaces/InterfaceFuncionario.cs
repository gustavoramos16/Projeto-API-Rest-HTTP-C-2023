using ASP.NET.NovaPasta;

namespace ASP.NET.Repositorios.Interfaces
{
    public interface InterfaceFuncionario
    {
        Task<List<FuncionarioModel>> ExibirTodosFuncionarios();

        Task<FuncionarioModel> BuscarFuncionarioID(int id);

        Task<FuncionarioModel> AdicionarFuncionario(FuncionarioModel funcionario);

        Task<FuncionarioModel> AtualizarFuncionario(FuncionarioModel funcionario, int id);

        Task<bool> ApagarFuncionario(int id);
    }
}
