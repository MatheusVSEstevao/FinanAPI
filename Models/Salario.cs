using FinanAPI.Models.Enuns;

namespace FinanAPI.Models
{
    public class Salario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double ValorLiquido { get; set; }
        public double GastosObrigatorios { get; set; }
        public double GastosLazer { get; set; }
        public double ValorFinal { get; set; }
        public double ValorGuardado { get; set; }
        public double ValorEmergencial { get; set; }
        public CargoEnum Cargo { get; set; }
        public double valor { get; set; } 

    }
    

    
}