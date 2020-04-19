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
    public class TcirculationController : ControllerBase
    {
        private readonly DBContext _context;

        public TcirculationController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tcirculation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tcirculation>>> GetTcirculation()
        {
            return await _context.Tcirculation.ToListAsync();
        }

        // GET: api/Tcirculation/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tcirculation>> GetTcirculation(long id)
        {
            var tcirculation = await _context.Tcirculation.FindAsync(id);

            if (tcirculation == null)
            {
                return NotFound();
            }

            return tcirculation;
        }

        // PUT: api/Tcirculation/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTcirculation(long id, Tcirculation tcirculation)
        {
            if (id != tcirculation.TcirculationId)
            {
                return BadRequest();
            }

            _context.Entry(tcirculation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TcirculationExists(id))
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

        // POST: api/Tcirculation
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tcirculation>> PostTcirculation(Tcirculation tcirculation)
        {
            _context.Tcirculation.Add(tcirculation);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TcirculationExists(tcirculation.TcirculationId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTcirculation", new { id = tcirculation.TcirculationId }, tcirculation);
        }

        // DELETE: api/Tcirculation/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tcirculation>> DeleteTcirculation(long id)
        {
            var tcirculation = await _context.Tcirculation.FindAsync(id);
            if (tcirculation == null)
            {
                return NotFound();
            }

            _context.Tcirculation.Remove(tcirculation);
            await _context.SaveChangesAsync();

            return tcirculation;
        }

        private bool TcirculationExists(long id)
        {
            return _context.Tcirculation.Any(e => e.TcirculationId == id);
        }
    }
}
