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
    public class TrailNetworkController : ControllerBase
    {
        private readonly DBContext _context;

        public TrailNetworkController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TrailNetwork
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrailNetwork>>> GetTrailNetwork()
        {
            return await _context.TrailNetwork.ToListAsync();
        }

        // GET: api/TrailNetwork/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TrailNetwork>> GetTrailNetwork(long id)
        {
            var trailNetwork = await _context.TrailNetwork.FindAsync(id);

            if (trailNetwork == null)
            {
                return NotFound();
            }

            return trailNetwork;
        }

        // PUT: api/TrailNetwork/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrailNetwork(long id, TrailNetwork trailNetwork)
        {
            if (id != trailNetwork.TrailNetworkId)
            {
                return BadRequest();
            }

            _context.Entry(trailNetwork).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrailNetworkExists(id))
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

        // POST: api/TrailNetwork
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TrailNetwork>> PostTrailNetwork(TrailNetwork trailNetwork)
        {
            _context.TrailNetwork.Add(trailNetwork);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TrailNetworkExists(trailNetwork.TrailNetworkId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTrailNetwork", new { id = trailNetwork.TrailNetworkId }, trailNetwork);
        }

        // DELETE: api/TrailNetwork/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TrailNetwork>> DeleteTrailNetwork(long id)
        {
            var trailNetwork = await _context.TrailNetwork.FindAsync(id);
            if (trailNetwork == null)
            {
                return NotFound();
            }

            _context.TrailNetwork.Remove(trailNetwork);
            await _context.SaveChangesAsync();

            return trailNetwork;
        }

        private bool TrailNetworkExists(long id)
        {
            return _context.TrailNetwork.Any(e => e.TrailNetworkId == id);
        }
    }
}
