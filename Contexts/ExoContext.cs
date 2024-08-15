using Exo.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Localization;

// O ExoContext tem como funcionalidade cuidar das tratativas de conexão com o banco de dados.

namespace Exo.WebApi.Contexts
{
    public class ExoContext : DbContext
    {

        public ExoContext()
        {
        }
        public ExoContext(DbContextOptions<ExoContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Essa string de conexão depene da SUA máquina.
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;"
                + "Database=exoApi;Trusted_Connection=True;");

                // Exemplo 1 de string de conexão:
                // User ID=sa; Password= admin; Server= Localhost; Database=ExoApi;-
                // + Trusted_connection=False;

                // Exemplo 2 de string de conexão:
                // Server=localhost\\SQLEXPRESS; Database=ExoApi;Trusted_Connection=True;

            }
        }

        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}
