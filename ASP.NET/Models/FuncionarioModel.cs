﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public int? EquipeId { get; set; }
    }
}
