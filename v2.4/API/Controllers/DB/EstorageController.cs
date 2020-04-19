using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models.DB;

namespace API.Controllers.DB
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstorageController : ControllerBase
    {
        private readonly DBContext _context;

        public EstorageController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Estorage
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Estorage>>> GetEstorage()
        {
            return await _context.Estorage.ToListAsync();
        }

        // GET: api/Estorage/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Estorage>> GetEstorage(short id)
        {
            var estorage = await _context.Estorage.FindAsync(id);

            if (estorage == null)
            {
                return NotFound();
            }

            return estorage;
        }

        // PUT: api/Estorage/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEstorage(short id, Estorage estorage)
        {
            if (id != estorage.EstorageId)
            {
                return BadRequest();
            }

            _context.Entry(estorage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstorageExists(id))
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

        // POST: api/Estorage
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Estorage>> PostEstorage(Estorage estorage)
        {
            _context.Estorage.Add(estorage);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EstorageExists(estorage.EstorageId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEstorage", new { id = estorage.EstorageId }, estorage);
        }

        // DELETE: api/Estorage/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Estorage>> DeleteEstorage(short id)
        {
            var estorage = await _context.Estorage.FindAsync(id);
            if (estorage == null)
            {
                return NotFound();
            }

            _context.Estorage.Remove(estorage);
            await _context.SaveChangesAsync();

            return estorage;
        }

        private bool EstorageExists(short id)
        {
            return _context.Estorage.Any(e => e.EstorageId == id);
        }
    }
}
