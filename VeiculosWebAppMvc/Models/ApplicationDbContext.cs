using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeiculosWebAppMvc.Models
{
    // Classe de Contexto que faz um "contexto de dados". Cria uma instância em toda a aplicação para manipular o banco de dados. Configuração adicional no Startup.cs
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        //Cria e configura tabela no banco de dados
        public DbSet<Veiculo> Veiculos { get; set; } //coleção de veiculos, referência direta pra tabela. Migration pega as configurações e gera o DB.
        public DbSet<Consumo> Consumos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
