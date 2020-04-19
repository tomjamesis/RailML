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
    public class TserviceSectionRefController : ControllerBase
    {
        private readonly DBContext _context;

        public TserviceSectionRefController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TserviceSectionRef
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TserviceSectionRef>>> GetTserviceSectionRef()
        {
            return await _context.TserviceSectionRef.ToListAsync();
        }

        // GET: api/TserviceSectionRef/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TserviceSectionRef>> GetTserviceSectionRef(short id)
        {
            var tserviceSectionRef = await _context.TserviceSectionRef.FindAsync(id);

            if (tserviceSectionRef == null)
            {
                return NotFound();
            }

            return tserviceSectionRef;
        }

        // PUT: api/TserviceSectionRef/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTserviceSectionRef(short id, TserviceSectionRef tserviceSectionRef)
        {
            if (id != tserviceSectionRef.TserviceSectionRefId)
            {
                return BadRequest();
            }

            _context.Entry(tserviceSectionRef).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TserviceSectionRefExists(id))
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

        // POST: api/TserviceSectionRef
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TserviceSectionRef>> PostTserviceSectionRef(TserviceSectionRef tserviceSectionRef)
        {
            _context.TserviceSectionRef.Add(tserviceSectionRef);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TserviceSectionRefExists(tserviceSectionRef.TserviceSectionRefId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTserviceSectionRef", new { id = tserviceSectionRef.TserviceSectionRefId }, tserviceSectionRef);
        }

        // DELETE: api/TserviceSectionRef/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TserviceSectionRef>> DeleteTserviceSectionRef(short id)
        {
            var tserviceSectionRef = await _context.TserviceSectionRef.FindAsync(id);
            if (tserviceSectionRef == null)
            {
                return NotFound();
            }

            _context.TserviceSectionRef.Remove(tserviceSectionRef);
            await _context.SaveChangesAsync();

            return tserviceSectionRef;
        }

        private bool TserviceSectionRefExists(short id)
        {
            return _context.TserviceSectionRef.Any(e => e.TserviceSectionRefId == id);
        }
    }
}
