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
    public class TtrainPartRefController : ControllerBase
    {
        private readonly DBContext _context;

        public TtrainPartRefController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TtrainPartRef
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TtrainPartRef>>> GetTtrainPartRef()
        {
            return await _context.TtrainPartRef.ToListAsync();
        }

        // GET: api/TtrainPartRef/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TtrainPartRef>> GetTtrainPartRef(short id)
        {
            var ttrainPartRef = await _context.TtrainPartRef.FindAsync(id);

            if (ttrainPartRef == null)
            {
                return NotFound();
            }

            return ttrainPartRef;
        }

        // PUT: api/TtrainPartRef/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTtrainPartRef(short id, TtrainPartRef ttrainPartRef)
        {
            if (id != ttrainPartRef.TtrainPartRefId)
            {
                return BadRequest();
            }

            _context.Entry(ttrainPartRef).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TtrainPartRefExists(id))
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

        // POST: api/TtrainPartRef
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TtrainPartRef>> PostTtrainPartRef(TtrainPartRef ttrainPartRef)
        {
            _context.TtrainPartRef.Add(ttrainPartRef);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TtrainPartRefExists(ttrainPartRef.TtrainPartRefId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTtrainPartRef", new { id = ttrainPartRef.TtrainPartRefId }, ttrainPartRef);
        }

        // DELETE: api/TtrainPartRef/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TtrainPartRef>> DeleteTtrainPartRef(short id)
        {
            var ttrainPartRef = await _context.TtrainPartRef.FindAsync(id);
            if (ttrainPartRef == null)
            {
                return NotFound();
            }

            _context.TtrainPartRef.Remove(ttrainPartRef);
            await _context.SaveChangesAsync();

            return ttrainPartRef;
        }

        private bool TtrainPartRefExists(short id)
        {
            return _context.TtrainPartRef.Any(e => e.TtrainPartRefId == id);
        }
    }
}
