﻿// <auto-generated />
using ASP.NET.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASP.NET.Migrations
{
    [DbContext(typeof(SistemaDB))]
    [Migration("20230307225716_InitialDB")]
    partial class InitialDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ASP.NET.NovaPasta.EquipeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("setor")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Equipes");
                });

            modelBuilder.Entity("ASP.NET.NovaPasta.FuncionarioModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("cargo")
                        .HasColumnType("longtext");

                    b.Property<string>("email")
                        .HasColumnType("longtext");

                    b.Property<string>("nome")
                        .HasColumnType("longtext");

                    b.Property<string>("referencia_para_a_equipe")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Funcionarios");
                });
#pragma warning restore 612, 618
        }
    }
}
