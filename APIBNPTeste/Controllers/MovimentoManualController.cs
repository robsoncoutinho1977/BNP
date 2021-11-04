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
    public class MovimentoManualController : ControllerBase
    {
        private readonly BNPContext _context;

        public MovimentoManualController(BNPContext context)
        {
            _context = context;
        }

        // GET: api/MovimentoManual
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movimento_Manual>>> GetMovimentoManuais()
        {
            return await _context.MovimentoManuais.ToListAsync();
        }

        // GET: api/MovimentoManual/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Movimento_Manual>> GetMovimento_Manual(int id)
        {
            var movimento_Manual = await _context.MovimentoManuais.FindAsync(id);

            if (movimento_Manual == null)
            {
                return NotFound();
            }

            return movimento_Manual;
        }

        // PUT: api/MovimentoManual/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovimento_Manual(int id, Movimento_Manual movimento_Manual)
        {
            if (id != movimento_Manual.MovimentoManual)
            {
                return BadRequest();
            }

            _context.Entry(movimento_Manual).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Movimento_ManualExists(id))
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

        // POST: api/MovimentoManual
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Movimento_Manual>> PostMovimento_Manual(Movimento_Manual movimento_Manual)
        {
            _context.MovimentoManuais.Add(movimento_Manual);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMovimento_Manual", new { id = movimento_Manual.MovimentoManual }, movimento_Manual);
        }

        // DELETE: api/MovimentoManual/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Movimento_Manual>> DeleteMovimento_Manual(int id)
        {
            var movimento_Manual = await _context.MovimentoManuais.FindAsync(id);
            if (movimento_Manual == null)
            {
                return NotFound();
            }

            _context.MovimentoManuais.Remove(movimento_Manual);
            await _context.SaveChangesAsync();

            return movimento_Manual;
        }

        private bool Movimento_ManualExists(int id)
        {
            return _context.MovimentoManuais.Any(e => e.MovimentoManual == id);
        }
    }
}
