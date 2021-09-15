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
    public class pagosController : ControllerBase
    {
        private readonly WebApplication1Context _context;

        public pagosController(WebApplication1Context context)
        {
            _context = context;
        }

        // GET: api/pagos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<pagos>>> Getpagos()
        {
            return await _context.pagos.ToListAsync();
        }

        // GET: api/pagos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<pagos>> Getpagos(int id)
        {
            var pagos = await _context.pagos.FindAsync(id);

            if (pagos == null)
            {
                return NotFound();
            }

            return pagos;
        }

        // PUT: api/pagos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> Putpagos(int id, pagos pagos)
        {
            if (id != pagos.ID)
            {
                return BadRequest();
            }

            _context.Entry(pagos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!pagosExists(id))
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

        // POST: api/pagos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<pagos>> Postpagos(pagos pagos)
        {
            _context.pagos.Add(pagos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getpagos", new { id = pagos.ID }, pagos);
        }

        // DELETE: api/pagos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<pagos>> Deletepagos(int id)
        {
            var pagos = await _context.pagos.FindAsync(id);
            if (pagos == null)
            {
                return NotFound();
            }

            _context.pagos.Remove(pagos);
            await _context.SaveChangesAsync();

            return pagos;
        }

        private bool pagosExists(int id)
        {
            return _context.pagos.Any(e => e.ID == id);
        }
    }
}
