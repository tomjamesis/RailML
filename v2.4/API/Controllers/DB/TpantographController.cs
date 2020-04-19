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
    public class TpantographController : ControllerBase
    {
        private readonly DBContext _context;

        public TpantographController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tpantograph
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tpantograph>>> GetTpantograph()
        {
            return await _context.Tpantograph.ToListAsync();
        }

        // GET: api/Tpantograph/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tpantograph>> GetTpantograph(long id)
        {
            var tpantograph = await _context.Tpantograph.FindAsync(id);

            if (tpantograph == null)
            {
                return NotFound();
            }

            return tpantograph;
        }

        // PUT: api/Tpantograph/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTpantograph(long id, Tpantograph tpantograph)
        {
            if (id != tpantograph.TpantographId)
            {
                return BadRequest();
            }

            _context.Entry(tpantograph).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TpantographExists(id))
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

        // POST: api/Tpantograph
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tpantograph>> PostTpantograph(Tpantograph tpantograph)
        {
            _context.Tpantograph.Add(tpantograph);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TpantographExists(tpantograph.TpantographId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTpantograph", new { id = tpantograph.TpantographId }, tpantograph);
        }

        // DELETE: api/Tpantograph/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tpantograph>> DeleteTpantograph(long id)
        {
            var tpantograph = await _context.Tpantograph.FindAsync(id);
            if (tpantograph == null)
            {
                return NotFound();
            }

            _context.Tpantograph.Remove(tpantograph);
            await _context.SaveChangesAsync();

            return tpantograph;
        }

        private bool TpantographExists(long id)
        {
            return _context.Tpantograph.Any(e => e.TpantographId == id);
        }
    }
}
