using ASP.NET.Data;
using ASP.NET.Repositorios;
using ASP.NET.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace ASP.NET
{
    public class Program
    {

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllersWithViews();

            // Conexão ao banco de Dados MySql
            var connectionStringMySql = builder.Configuration.GetConnectionString("ConnectionMySql");
            builder.Services.AddDbContext<SistemaDB>
                (options => options.UseMySQL(connectionStringMySql, mysqlOptions =>
                {
                    ServerVersion.AutoDetect(connectionStringMySql);
                }));

            //################################

            //Relação de dependência

            builder.Services.AddScoped<InterfaceEquipe, EquipeRepositorio>();
            builder.Services.AddScoped<InterfaceFuncionario, FuncionarioRepositorio>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            //################################

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}