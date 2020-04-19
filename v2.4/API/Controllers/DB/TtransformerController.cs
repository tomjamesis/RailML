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
    public class TtransformerController : ControllerBase
    {
        private readonly DBContext _context;

        public TtransformerController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Ttransformer
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ttransformer>>> GetTtransformer()
        {
            return await _context.Ttransformer.ToListAsync();
        }

        // GET: api/Ttransformer/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ttransformer>> GetTtransformer(long id)
        {
            var ttransformer = await _context.Ttransformer.FindAsync(id);

            if (ttransformer == null)
            {
                return NotFound();
            }

            return ttransformer;
        }

        // PUT: api/Ttransformer/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTtransformer(long id, Ttransformer ttransformer)
        {
            if (id != ttransformer.TtransformerId)
            {
                return BadRequest();
            }

            _context.Entry(ttransformer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TtransformerExists(id))
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

        // POST: api/Ttransformer
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Ttransformer>> PostTtransformer(Ttransformer ttransformer)
        {
            _context.Ttransformer.Add(ttransformer);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TtransformerExists(ttransformer.TtransformerId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTtransformer", new { id = ttransformer.TtransformerId }, ttransformer);
        }

        // DELETE: api/Ttransformer/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Ttransformer>> DeleteTtransformer(long id)
        {
            var ttransformer = await _context.Ttransformer.FindAsync(id);
            if (ttransformer == null)
            {
                return NotFound();
            }

            _context.Ttransformer.Remove(ttransformer);
            await _context.SaveChangesAsync();

            return ttransformer;
        }

        private bool TtransformerExists(long id)
        {
            return _context.Ttransformer.Any(e => e.TtransformerId == id);
        }
    }
}
