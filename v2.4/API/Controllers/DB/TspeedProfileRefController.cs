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
    public class TspeedProfileRefController : ControllerBase
    {
        private readonly DBContext _context;

        public TspeedProfileRefController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TspeedProfileRef
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TspeedProfileRef>>> GetTspeedProfileRef()
        {
            return await _context.TspeedProfileRef.ToListAsync();
        }

        // GET: api/TspeedProfileRef/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TspeedProfileRef>> GetTspeedProfileRef(short id)
        {
            var tspeedProfileRef = await _context.TspeedProfileRef.FindAsync(id);

            if (tspeedProfileRef == null)
            {
                return NotFound();
            }

            return tspeedProfileRef;
        }

        // PUT: api/TspeedProfileRef/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTspeedProfileRef(short id, TspeedProfileRef tspeedProfileRef)
        {
            if (id != tspeedProfileRef.TspeedProfileRefId)
            {
                return BadRequest();
            }

            _context.Entry(tspeedProfileRef).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TspeedProfileRefExists(id))
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

        // POST: api/TspeedProfileRef
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TspeedProfileRef>> PostTspeedProfileRef(TspeedProfileRef tspeedProfileRef)
        {
            _context.TspeedProfileRef.Add(tspeedProfileRef);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TspeedProfileRefExists(tspeedProfileRef.TspeedProfileRefId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTspeedProfileRef", new { id = tspeedProfileRef.TspeedProfileRefId }, tspeedProfileRef);
        }

        // DELETE: api/TspeedProfileRef/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TspeedProfileRef>> DeleteTspeedProfileRef(short id)
        {
            var tspeedProfileRef = await _context.TspeedProfileRef.FindAsync(id);
            if (tspeedProfileRef == null)
            {
                return NotFound();
            }

            _context.TspeedProfileRef.Remove(tspeedProfileRef);
            await _context.SaveChangesAsync();

            return tspeedProfileRef;
        }

        private bool TspeedProfileRefExists(short id)
        {
            return _context.TspeedProfileRef.Any(e => e.TspeedProfileRefId == id);
        }
    }
}
