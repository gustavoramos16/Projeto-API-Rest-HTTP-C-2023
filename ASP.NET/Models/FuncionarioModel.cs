using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ASP.NET.NovaPasta
{
    public class FuncionarioModel
    {
        [Key]
        public int Id { get; internal set; }

        [Required]
        public string? nome { get; set; }

        [Required]
        public string? cargo { get; set; }

        public string? email { get; set; }



        [Required]
        [ForeignKey("Referencia para a equipe")]
        public int? Referencia_para_a_equipe{ get; set; }

        [JsonIgnore]
        [NotMapped]
        public EquipeModel? Equipe { get; set; } 
        
    }
}
