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
    public class TtrainPartController : ControllerBase
    {
        private readonly DBContext _context;

        public TtrainPartController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TtrainPart
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TtrainPart>>> GetTtrainPart()
        {
            return await _context.TtrainPart.ToListAsync();
        }

        // GET: api/TtrainPart/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TtrainPart>> GetTtrainPart(short id)
        {
            var ttrainPart = await _context.TtrainPart.FindAsync(id);

            if (ttrainPart == null)
            {
                return NotFound();
            }

            return ttrainPart;
        }

        // PUT: api/TtrainPart/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTtrainPart(short id, TtrainPart ttrainPart)
        {
            if (id != ttrainPart.TtrainPartId)
            {
                return BadRequest();
            }

            _context.Entry(ttrainPart).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TtrainPartExists(id))
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

        // POST: api/TtrainPart
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TtrainPart>> PostTtrainPart(TtrainPart ttrainPart)
        {
            _context.TtrainPart.Add(ttrainPart);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TtrainPartExists(ttrainPart.TtrainPartId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTtrainPart", new { id = ttrainPart.TtrainPartId }, ttrainPart);
        }

        // DELETE: api/TtrainPart/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TtrainPart>> DeleteTtrainPart(short id)
        {
            var ttrainPart = await _context.TtrainPart.FindAsync(id);
            if (ttrainPart == null)
            {
                return NotFound();
            }

            _context.TtrainPart.Remove(ttrainPart);
            await _context.SaveChangesAsync();

            return ttrainPart;
        }

        private bool TtrainPartExists(short id)
        {
            return _context.TtrainPart.Any(e => e.TtrainPartId == id);
        }
    }
}
