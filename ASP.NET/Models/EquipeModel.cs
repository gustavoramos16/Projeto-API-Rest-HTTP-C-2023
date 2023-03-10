using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

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

        [JsonIgnore]
        [NotMapped]
        public ICollection<FuncionarioModel>? Funcionario { get; set;}

    }
}
