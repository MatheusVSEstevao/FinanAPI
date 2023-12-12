using Microsoft.AspNetCore.Mvc;
using FinanAPI.Data;
using FinanAPI.Models;
using FinanAPI.Models.Enuns;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace FinanAPI.Controllers
{
    [ApiController]
    [Route("Controller")]
    public class SalarioController : ControllerBase
    {

        private readonly DataContext _context;

        public SalarioController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            try
            {
                Salario s = await _context.TB_SALARIOS
                    .FirstOrDefaultAsync(sBusca => sBusca.Id == id);

                return Ok(s);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            try
            {
                List<Salario> lista = await _context.TB_SALARIOS.ToListAsync();
                return Ok(lista);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(Salario novoSalario)
        {
            try
            {
                if (novoSalario.ValorLiquido == 0)
                {
                    throw new Exception("Valor Líquido não pode ser 0");
                }
                await _context.TB_SALARIOS.AddAsync(novoSalario);
                await _context.SaveChangesAsync();

                return Ok(novoSalario.Id);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(Salario novoSalario)
        {
            try
            {
                if (novoSalario.ValorLiquido == 0)
                {
                    throw new Exception("Valor Líquido não pode ser 0");
                }
                _context.TB_SALARIOS.Update(novoSalario);
                int linhasAfetadas = await _context.SaveChangesAsync();

                return Ok(linhasAfetadas);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                Salario sRemover = await _context.TB_SALARIOS.FirstOrDefaultAsync(p => p.Id == id);

                _context.TB_SALARIOS.Remove(sRemover);
                int linhasAfetadas = await _context.SaveChangesAsync();
                return Ok(linhasAfetadas);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}