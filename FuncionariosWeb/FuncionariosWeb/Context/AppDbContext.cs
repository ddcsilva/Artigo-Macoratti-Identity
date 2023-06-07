using FuncionariosWeb.Model;
using FuncionariosWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace FuncionariosWeb.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
    public DbSet<Funcionario> Funcionarios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Funcionario>().HasData(
        new Funcionario
        {
            FuncionarioId = 1,
            Nome = "Danilo",
            Departamento = Departamento.TI,
            Email = "danilo.silva@msn.com"
        });
    }
}