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
    public class EauxiliarySupplyController : ControllerBase
    {
        private readonly DBContext _context;

        public EauxiliarySupplyController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EauxiliarySupply
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EauxiliarySupply>>> GetEauxiliarySupply()
        {
            return await _context.EauxiliarySupply.ToListAsync();
        }

        // GET: api/EauxiliarySupply/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EauxiliarySupply>> GetEauxiliarySupply(short id)
        {
            var eauxiliarySupply = await _context.EauxiliarySupply.FindAsync(id);

            if (eauxiliarySupply == null)
            {
                return NotFound();
            }

            return eauxiliarySupply;
        }

        // PUT: api/EauxiliarySupply/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEauxiliarySupply(short id, EauxiliarySupply eauxiliarySupply)
        {
            if (id != eauxiliarySupply.EauxiliarySupplyId)
            {
                return BadRequest();
            }

            _context.Entry(eauxiliarySupply).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EauxiliarySupplyExists(id))
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

        // POST: api/EauxiliarySupply
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EauxiliarySupply>> PostEauxiliarySupply(EauxiliarySupply eauxiliarySupply)
        {
            _context.EauxiliarySupply.Add(eauxiliarySupply);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EauxiliarySupplyExists(eauxiliarySupply.EauxiliarySupplyId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEauxiliarySupply", new { id = eauxiliarySupply.EauxiliarySupplyId }, eauxiliarySupply);
        }

        // DELETE: api/EauxiliarySupply/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EauxiliarySupply>> DeleteEauxiliarySupply(short id)
        {
            var eauxiliarySupply = await _context.EauxiliarySupply.FindAsync(id);
            if (eauxiliarySupply == null)
            {
                return NotFound();
            }

            _context.EauxiliarySupply.Remove(eauxiliarySupply);
            await _context.SaveChangesAsync();

            return eauxiliarySupply;
        }

        private bool EauxiliarySupplyExists(short id)
        {
            return _context.EauxiliarySupply.Any(e => e.EauxiliarySupplyId == id);
        }
    }
}
