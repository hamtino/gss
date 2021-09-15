using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class carroesController : ControllerBase
    {
        private readonly WebApplication1Context _context;

        public carroesController(WebApplication1Context context)
        {
            _context = context;
        }

        // GET: api/carroes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<carro>>> Getcarro()
        {
            return await _context.carro.ToListAsync();
        }

        // GET: api/carroes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<carro>> Getcarro(int id)
        {
            var carro = await _context.carro.FindAsync(id);

            if (carro == null)
            {
                return NotFound();
            }

            return carro;
        }

        // PUT: api/carroes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> Putcarro(int id, carro carro)
        {
            if (id != carro.ID)
            {
                return BadRequest();
            }

            _context.Entry(carro).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!carroExists(id))
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

        // POST: api/carroes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<carro>> Postcarro(carro carro)
        {
            _context.carro.Add(carro);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getcarro", new { id = carro.ID }, carro);
        }

        // DELETE: api/carroes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<carro>> Deletecarro(int id)
        {
            var carro = await _context.carro.FindAsync(id);
            if (carro == null)
            {
                return NotFound();
            }

            _context.carro.Remove(carro);
            await _context.SaveChangesAsync();

            return carro;
        }

        private bool carroExists(int id)
        {
            return _context.carro.Any(e => e.ID == id);
        }
    }
}
