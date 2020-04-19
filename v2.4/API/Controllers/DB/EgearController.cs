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
    public class EgearController : ControllerBase
    {
        private readonly DBContext _context;

        public EgearController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Egear
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Egear>>> GetEgear()
        {
            return await _context.Egear.ToListAsync();
        }

        // GET: api/Egear/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Egear>> GetEgear(short id)
        {
            var egear = await _context.Egear.FindAsync(id);

            if (egear == null)
            {
                return NotFound();
            }

            return egear;
        }

        // PUT: api/Egear/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEgear(short id, Egear egear)
        {
            if (id != egear.EgearId)
            {
                return BadRequest();
            }

            _context.Entry(egear).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EgearExists(id))
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

        // POST: api/Egear
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Egear>> PostEgear(Egear egear)
        {
            _context.Egear.Add(egear);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EgearExists(egear.EgearId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEgear", new { id = egear.EgearId }, egear);
        }

        // DELETE: api/Egear/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Egear>> DeleteEgear(short id)
        {
            var egear = await _context.Egear.FindAsync(id);
            if (egear == null)
            {
                return NotFound();
            }

            _context.Egear.Remove(egear);
            await _context.SaveChangesAsync();

            return egear;
        }

        private bool EgearExists(short id)
        {
            return _context.Egear.Any(e => e.EgearId == id);
        }
    }
}
