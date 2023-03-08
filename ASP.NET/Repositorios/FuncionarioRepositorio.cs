using ASP.NET.Data;
using ASP.NET.NovaPasta;
using ASP.NET.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET.Repositorios
{
    public class FuncionarioRepositorio : InterfaceFuncionario
    {
        private readonly SistemaDB _bancodados;

        public FuncionarioRepositorio(SistemaDB sistemaFuncionario)
        {
            _bancodados = sistemaFuncionario;
        }

        public async Task<List<FuncionarioModel>> ExibirTodosFuncionarios()
        {
            return await _bancodados.Funcionarios.ToListAsync();
        }

        public async Task<FuncionarioModel> BuscarFuncionarioID(int id)
        {
            return await _bancodados.Funcionarios.FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<FuncionarioModel> AdicionarFuncionario(FuncionarioModel funcionario)
        {
            //FuncionarioModel funcionarioID = await BuscarFuncionarioID(id);
            //funcionarioID.cargo = funcionario.cargo;
            //funcionarioID.email = funcionario.email;

            if (funcionario.cargo.ToLower() != "gerente")
            {
                _bancodados.Funcionarios.Add(funcionario);
            }
            else
            {
                if(funcionario.email == "")
                {
                    throw new Exception($"O campo email é obrigatório para gerentes");
                }
                else
                {
                    _bancodados.Funcionarios.Add(funcionario);
                }

            }
            _bancodados.SaveChanges();

            return funcionario;
        }

        public async Task<FuncionarioModel> AtualizarFuncionario(FuncionarioModel funcionario, int id)
        {
            FuncionarioModel funcionarioID = await BuscarFuncionarioID(id);
            
            if(funcionarioID == null)
            {
                throw new Exception($"O ID: {id} não foi encontrado");
            }

            funcionarioID.nome = funcionario.nome;
            funcionarioID.cargo = funcionario.cargo;
            funcionarioID.email = funcionario.email;
            funcionarioID.EquipeId = funcionario.EquipeId;

            _bancodados.SaveChanges();

            return funcionarioID;
        }

        public async Task<bool> ApagarFuncionario(int id)
        {
            FuncionarioModel funcionarioID = await BuscarFuncionarioID(id);

            if (funcionarioID == null)
            {
                throw new Exception($"O ID: {id} relacionado com funcionario não foi encontrado");

            }

            _bancodados.Funcionarios.Remove(funcionarioID);
            _bancodados.SaveChanges();

            return true;

        }
    }
}


