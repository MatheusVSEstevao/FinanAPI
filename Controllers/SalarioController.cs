using Microsoft.AspNetCore.Mvc;
using FinanAPI.Models;
using FinanAPI.Models.Enuns;
using System.Collections.Generic;
using System.Linq;

namespace FinanAPI.Controllers
{

        [ApiController]
        [Route("[Controller]")]

        public class SalarioController : ControllerBase
        {
            private static List<Salario> salarios = new List<Salario>()
            {

                new Salario() { Id = 1, Nome = "Matheus Estagiário", ValorLiquido=1500.00, GastosObrigatorios=600.00, GastosLazer=400.00, ValorFinal=500.00, ValorGuardado=400.00, ValorEmergencial=100.00 , Cargo=CargoEnum.estagiario},
                new Salario() { Id = 2, Nome = "Matheus Trainee", ValorLiquido=1846.50, GastosObrigatorios=600.00, GastosLazer=500.00, ValorFinal=746.50, ValorGuardado=600.00, ValorEmergencial=146.50, Cargo=CargoEnum.trainee},                
                new Salario() { Id = 3, Nome = "Matheus Júnior", ValorLiquido=2500.00, GastosObrigatorios=600.00, GastosLazer=700.00, ValorFinal=1200.00, ValorGuardado=1000.00, ValorEmergencial=200.00, Cargo=CargoEnum.junior},
                new Salario() { Id = 4, Nome = "Matheus Pleno", ValorLiquido=5000.00, GastosObrigatorios=600.00, GastosLazer=1500.00, ValorFinal=2900.00, ValorGuardado=2500.00, ValorEmergencial=400.00, Cargo=CargoEnum.pleno},
                new Salario() { Id = 5, Nome = "Matheus Sênior", ValorLiquido=8000.00, GastosObrigatorios=600.00, GastosLazer=3000.00, ValorFinal=4400.00, ValorGuardado=3500.00, ValorEmergencial=900.00, Cargo=CargoEnum.Senior}
                
            };

            [HttpGet("Get")]
            public IActionResult GetFirst()
            {
                Salario s = salarios[0];
                return Ok(s);
            }
    
            [HttpGet("GetAll")]
            public IActionResult Get()
            {
                return Ok(salarios);
            }

            [HttpGet("{id}")]

            public IActionResult GetSingle(int id)
            {
                return Ok(salarios.FirstOrDefault(sa => sa.Id == id));
            }

            [HttpPost]
            public IActionResult AddSalario(Salario novoSalario)
            {
                salarios.Add(novoSalario);
                return Ok(salarios);
            }

            [HttpGet("GetOrdenado")]
            public IActionResult GetOrdem()
            {
                List<Salario> listaFinal = salarios.OrderBy(p => p.ValorLiquido).ToList();
                return Ok(listaFinal);
            }

            [HttpGet("GetSomaLiquida")]
            public IActionResult GetSomaValorLiquido()
            {
                return Ok(salarios.Sum(s => s.ValorLiquido));
            }

            [HttpGet("GetByNomeAproximado/{Nome}")]
            public IActionResult GetByNomeAproximado(string Nome)
            {
                List<Salario> listaBusca = salarios.FindAll(p=> p.Nome.Contains(Nome));
                return Ok(listaBusca);
            }

            [HttpPut]
            public IActionResult UpdateSalario(Salario s)
            {
                Salario salarioAlterado = salarios.Find(sal => sal.Id == s.Id);
                salarioAlterado.Nome = s.Nome;
                salarioAlterado.ValorLiquido = s.ValorLiquido;
                salarioAlterado.GastosObrigatorios = s.GastosObrigatorios;
                salarioAlterado.GastosLazer = s.GastosLazer;
                salarioAlterado.ValorFinal = s.ValorFinal;
                salarioAlterado.ValorGuardado = s.ValorGuardado;
                salarioAlterado.ValorEmergencial = s.ValorEmergencial;
                salarioAlterado.Cargo = s.Cargo;
                
            }
            
        }
          

}
