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
    public class TauxiliarySupplySystemController : ControllerBase
    {
        private readonly DBContext _context;

        public TauxiliarySupplySystemController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TauxiliarySupplySystem
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TauxiliarySupplySystem>>> GetTauxiliarySupplySystem()
        {
            return await _context.TauxiliarySupplySystem.ToListAsync();
        }

        // GET: api/TauxiliarySupplySystem/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TauxiliarySupplySystem>> GetTauxiliarySupplySystem(long id)
        {
            var tauxiliarySupplySystem = await _context.TauxiliarySupplySystem.FindAsync(id);

            if (tauxiliarySupplySystem == null)
            {
                return NotFound();
            }

            return tauxiliarySupplySystem;
        }

        // PUT: api/TauxiliarySupplySystem/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTauxiliarySupplySystem(long id, TauxiliarySupplySystem tauxiliarySupplySystem)
        {
            if (id != tauxiliarySupplySystem.TauxiliarySupplySystemId)
            {
                return BadRequest();
            }

            _context.Entry(tauxiliarySupplySystem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TauxiliarySupplySystemExists(id))
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

        // POST: api/TauxiliarySupplySystem
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TauxiliarySupplySystem>> PostTauxiliarySupplySystem(TauxiliarySupplySystem tauxiliarySupplySystem)
        {
            _context.TauxiliarySupplySystem.Add(tauxiliarySupplySystem);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TauxiliarySupplySystemExists(tauxiliarySupplySystem.TauxiliarySupplySystemId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTauxiliarySupplySystem", new { id = tauxiliarySupplySystem.TauxiliarySupplySystemId }, tauxiliarySupplySystem);
        }

        // DELETE: api/TauxiliarySupplySystem/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TauxiliarySupplySystem>> DeleteTauxiliarySupplySystem(long id)
        {
            var tauxiliarySupplySystem = await _context.TauxiliarySupplySystem.FindAsync(id);
            if (tauxiliarySupplySystem == null)
            {
                return NotFound();
            }

            _context.TauxiliarySupplySystem.Remove(tauxiliarySupplySystem);
            await _context.SaveChangesAsync();

            return tauxiliarySupplySystem;
        }

        private bool TauxiliarySupplySystemExists(long id)
        {
            return _context.TauxiliarySupplySystem.Any(e => e.TauxiliarySupplySystemId == id);
        }
    }
}
