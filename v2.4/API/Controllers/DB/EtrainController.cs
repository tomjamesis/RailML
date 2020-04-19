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
    public class EtrainController : ControllerBase
    {
        private readonly DBContext _context;

        public EtrainController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Etrain
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Etrain>>> GetEtrain()
        {
            return await _context.Etrain.ToListAsync();
        }

        // GET: api/Etrain/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Etrain>> GetEtrain(short id)
        {
            var etrain = await _context.Etrain.FindAsync(id);

            if (etrain == null)
            {
                return NotFound();
            }

            return etrain;
        }

        // PUT: api/Etrain/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEtrain(short id, Etrain etrain)
        {
            if (id != etrain.EtrainId)
            {
                return BadRequest();
            }

            _context.Entry(etrain).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EtrainExists(id))
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

        // POST: api/Etrain
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Etrain>> PostEtrain(Etrain etrain)
        {
            _context.Etrain.Add(etrain);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EtrainExists(etrain.EtrainId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEtrain", new { id = etrain.EtrainId }, etrain);
        }

        // DELETE: api/Etrain/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Etrain>> DeleteEtrain(short id)
        {
            var etrain = await _context.Etrain.FindAsync(id);
            if (etrain == null)
            {
                return NotFound();
            }

            _context.Etrain.Remove(etrain);
            await _context.SaveChangesAsync();

            return etrain;
        }

        private bool EtrainExists(short id)
        {
            return _context.Etrain.Any(e => e.EtrainId == id);
        }
    }
}
