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
    public class EbalisesController : ControllerBase
    {
        private readonly DBContext _context;

        public EbalisesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Ebalises
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ebalises>>> GetEbalises()
        {
            return await _context.Ebalises.ToListAsync();
        }

        // GET: api/Ebalises/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ebalises>> GetEbalises(long id)
        {
            var ebalises = await _context.Ebalises.FindAsync(id);

            if (ebalises == null)
            {
                return NotFound();
            }

            return ebalises;
        }

        // PUT: api/Ebalises/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEbalises(long id, Ebalises ebalises)
        {
            if (id != ebalises.EbalisesId)
            {
                return BadRequest();
            }

            _context.Entry(ebalises).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EbalisesExists(id))
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

        // POST: api/Ebalises
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Ebalises>> PostEbalises(Ebalises ebalises)
        {
            _context.Ebalises.Add(ebalises);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EbalisesExists(ebalises.EbalisesId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEbalises", new { id = ebalises.EbalisesId }, ebalises);
        }

        // DELETE: api/Ebalises/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Ebalises>> DeleteEbalises(long id)
        {
            var ebalises = await _context.Ebalises.FindAsync(id);
            if (ebalises == null)
            {
                return NotFound();
            }

            _context.Ebalises.Remove(ebalises);
            await _context.SaveChangesAsync();

            return ebalises;
        }

        private bool EbalisesExists(long id)
        {
            return _context.Ebalises.Any(e => e.EbalisesId == id);
        }
    }
}
