using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APIBNPTeste.Models;

namespace APIBNPTeste.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoCosifController : ControllerBase
    {
        private readonly BNPContext _context;

        public ProdutoCosifController(BNPContext context)
        {
            _context = context;
        }

        // GET: api/ProdutoCosif
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto_Cosif>>> GetProdutoCosifs()
        {
            return await _context.ProdutoCosifs.ToListAsync();
        }

        // GET: api/ProdutoCosif/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Produto_Cosif>> GetProduto_Cosif(string id)
        {
            var produto_Cosif = await _context.ProdutoCosifs.FindAsync(id);

            if (produto_Cosif == null)
            {
                return NotFound();
            }

            return produto_Cosif;
        }

        // PUT: api/ProdutoCosif/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduto_Cosif(string id, Produto_Cosif produto_Cosif)
        {
            if (id != produto_Cosif.COD_PRODUTO)
            {
                return BadRequest();
            }

            _context.Entry(produto_Cosif).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Produto_CosifExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ProdutoCosif
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Produto_Cosif>> PostProduto_Cosif(Produto_Cosif produto_Cosif)
        {
            _context.ProdutoCosifs.Add(produto_Cosif);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Produto_CosifExists(produto_Cosif.COD_PRODUTO))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetProduto_Cosif", new { id = produto_Cosif.COD_PRODUTO }, produto_Cosif);
        }

        // DELETE: api/ProdutoCosif/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Produto_Cosif>> DeleteProduto_Cosif(string id)
        {
            var produto_Cosif = await _context.ProdutoCosifs.FindAsync(id);
            if (produto_Cosif == null)
            {
                return NotFound();
            }

            _context.ProdutoCosifs.Remove(produto_Cosif);
            await _context.SaveChangesAsync();

            return produto_Cosif;
        }

        private bool Produto_CosifExists(string id)
        {
            return _context.ProdutoCosifs.Any(e => e.COD_PRODUTO == id);
        }
    }
}
