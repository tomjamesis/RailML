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
    public class TtrainController : ControllerBase
    {
        private readonly DBContext _context;

        public TtrainController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Ttrain
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ttrain>>> GetTtrain()
        {
            return await _context.Ttrain.ToListAsync();
        }

        // GET: api/Ttrain/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ttrain>> GetTtrain(short id)
        {
            var ttrain = await _context.Ttrain.FindAsync(id);

            if (ttrain == null)
            {
                return NotFound();
            }

            return ttrain;
        }

        // PUT: api/Ttrain/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTtrain(short id, Ttrain ttrain)
        {
            if (id != ttrain.TtrainId)
            {
                return BadRequest();
            }

            _context.Entry(ttrain).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TtrainExists(id))
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

        // POST: api/Ttrain
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Ttrain>> PostTtrain(Ttrain ttrain)
        {
            _context.Ttrain.Add(ttrain);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TtrainExists(ttrain.TtrainId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTtrain", new { id = ttrain.TtrainId }, ttrain);
        }

        // DELETE: api/Ttrain/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Ttrain>> DeleteTtrain(short id)
        {
            var ttrain = await _context.Ttrain.FindAsync(id);
            if (ttrain == null)
            {
                return NotFound();
            }

            _context.Ttrain.Remove(ttrain);
            await _context.SaveChangesAsync();

            return ttrain;
        }

        private bool TtrainExists(short id)
        {
            return _context.Ttrain.Any(e => e.TtrainId == id);
        }
    }
}
