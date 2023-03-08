using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET.NovaPasta
{
    public class EquipeModel
    {
        [Key]
        public int Id { get; internal set; }

        [Required]
        public string? Nome { get; set; }

        [Required]
        public string? setor { get; set; }

        //public ICollection<FuncionarioModel>? Funcionario_ { get; set; }
    }
}
