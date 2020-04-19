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
    public class TauxiliarySupplyController : ControllerBase
    {
        private readonly DBContext _context;

        public TauxiliarySupplyController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TauxiliarySupply
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TauxiliarySupply>>> GetTauxiliarySupply()
        {
            return await _context.TauxiliarySupply.ToListAsync();
        }

        // GET: api/TauxiliarySupply/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TauxiliarySupply>> GetTauxiliarySupply(long id)
        {
            var tauxiliarySupply = await _context.TauxiliarySupply.FindAsync(id);

            if (tauxiliarySupply == null)
            {
                return NotFound();
            }

            return tauxiliarySupply;
        }

        // PUT: api/TauxiliarySupply/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTauxiliarySupply(long id, TauxiliarySupply tauxiliarySupply)
        {
            if (id != tauxiliarySupply.TauxiliarySupplyId)
            {
                return BadRequest();
            }

            _context.Entry(tauxiliarySupply).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TauxiliarySupplyExists(id))
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

        // POST: api/TauxiliarySupply
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TauxiliarySupply>> PostTauxiliarySupply(TauxiliarySupply tauxiliarySupply)
        {
            _context.TauxiliarySupply.Add(tauxiliarySupply);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TauxiliarySupplyExists(tauxiliarySupply.TauxiliarySupplyId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTauxiliarySupply", new { id = tauxiliarySupply.TauxiliarySupplyId }, tauxiliarySupply);
        }

        // DELETE: api/TauxiliarySupply/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TauxiliarySupply>> DeleteTauxiliarySupply(long id)
        {
            var tauxiliarySupply = await _context.TauxiliarySupply.FindAsync(id);
            if (tauxiliarySupply == null)
            {
                return NotFound();
            }

            _context.TauxiliarySupply.Remove(tauxiliarySupply);
            await _context.SaveChangesAsync();

            return tauxiliarySupply;
        }

        private bool TauxiliarySupplyExists(long id)
        {
            return _context.TauxiliarySupply.Any(e => e.TauxiliarySupplyId == id);
        }
    }
}
