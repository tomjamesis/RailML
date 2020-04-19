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
    public class TformationController : ControllerBase
    {
        private readonly DBContext _context;

        public TformationController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tformation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tformation>>> GetTformation()
        {
            return await _context.Tformation.ToListAsync();
        }

        // GET: api/Tformation/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tformation>> GetTformation(short id)
        {
            var tformation = await _context.Tformation.FindAsync(id);

            if (tformation == null)
            {
                return NotFound();
            }

            return tformation;
        }

        // PUT: api/Tformation/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTformation(short id, Tformation tformation)
        {
            if (id != tformation.TformationId)
            {
                return BadRequest();
            }

            _context.Entry(tformation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TformationExists(id))
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

        // POST: api/Tformation
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tformation>> PostTformation(Tformation tformation)
        {
            _context.Tformation.Add(tformation);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TformationExists(tformation.TformationId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTformation", new { id = tformation.TformationId }, tformation);
        }

        // DELETE: api/Tformation/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tformation>> DeleteTformation(short id)
        {
            var tformation = await _context.Tformation.FindAsync(id);
            if (tformation == null)
            {
                return NotFound();
            }

            _context.Tformation.Remove(tformation);
            await _context.SaveChangesAsync();

            return tformation;
        }

        private bool TformationExists(short id)
        {
            return _context.Tformation.Any(e => e.TformationId == id);
        }
    }
}
