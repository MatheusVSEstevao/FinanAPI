using FinanAPI.Models;
using Microsoft.EntityFrameworkCore;
using FinanAPI.Models.Enuns;

namespace FinanAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {

        }

        public DbSet<Salario> TB_SALARIOS { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Salario>().HasData
            (
                new Salario() { Id = 1, Nome = "Matheus Estagiário", ValorLiquido=1500.00, GastosObrigatorios=600.00, GastosLazer=400.00, ValorFinal=500.00, ValorGuardado=400.00, ValorEmergencial=100.00 , Cargo=CargoEnum.estagiario},
                new Salario() { Id = 2, Nome = "Matheus Trainee", ValorLiquido=1846.50, GastosObrigatorios=600.00, GastosLazer=500.00, ValorFinal=746.50, ValorGuardado=600.00, ValorEmergencial=146.50, Cargo=CargoEnum.trainee},                
                new Salario() { Id = 3, Nome = "Matheus Júnior", ValorLiquido=2500.00, GastosObrigatorios=600.00, GastosLazer=700.00, ValorFinal=1200.00, ValorGuardado=1000.00, ValorEmergencial=200.00, Cargo=CargoEnum.junior},
                new Salario() { Id = 4, Nome = "Matheus Pleno", ValorLiquido=5000.00, GastosObrigatorios=600.00, GastosLazer=1500.00, ValorFinal=2900.00, ValorGuardado=2500.00, ValorEmergencial=400.00, Cargo=CargoEnum.pleno},
                new Salario() { Id = 5, Nome = "Matheus Sênior", ValorLiquido=8000.00, GastosObrigatorios=600.00, GastosLazer=3000.00, ValorFinal=4400.00, ValorGuardado=3500.00, ValorEmergencial=900.00, Cargo=CargoEnum.Senior}
            );
        }
    }
}