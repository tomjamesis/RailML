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
    public class EsignalsController : ControllerBase
    {
        private readonly DBContext _context;

        public EsignalsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Esignals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Esignals>>> GetEsignals()
        {
            return await _context.Esignals.ToListAsync();
        }

        // GET: api/Esignals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Esignals>> GetEsignals(long id)
        {
            var esignals = await _context.Esignals.FindAsync(id);

            if (esignals == null)
            {
                return NotFound();
            }

            return esignals;
        }

        // PUT: api/Esignals/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEsignals(long id, Esignals esignals)
        {
            if (id != esignals.EsignalsId)
            {
                return BadRequest();
            }

            _context.Entry(esignals).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EsignalsExists(id))
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

        // POST: api/Esignals
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Esignals>> PostEsignals(Esignals esignals)
        {
            _context.Esignals.Add(esignals);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EsignalsExists(esignals.EsignalsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEsignals", new { id = esignals.EsignalsId }, esignals);
        }

        // DELETE: api/Esignals/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Esignals>> DeleteEsignals(long id)
        {
            var esignals = await _context.Esignals.FindAsync(id);
            if (esignals == null)
            {
                return NotFound();
            }

            _context.Esignals.Remove(esignals);
            await _context.SaveChangesAsync();

            return esignals;
        }

        private bool EsignalsExists(long id)
        {
            return _context.Esignals.Any(e => e.EsignalsId == id);
        }
    }
}
