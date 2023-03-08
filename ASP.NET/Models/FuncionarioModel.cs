using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET.NovaPasta
{
    public class FuncionarioModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string? nome { get; set; }

        [Required]
        public string? cargo { get; set; }

        public string? email { get; set; }

        [Required]
        [NotMapped]
        public int? Referencia_Para_a_Equipe { get; set; }
        [ForeignKey("Referencia_Para_a_Equipe")]
        
        public EquipeModel Equipe_ { get; set; }
    }
}
