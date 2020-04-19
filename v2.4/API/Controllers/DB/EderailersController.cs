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
    public class EderailersController : ControllerBase
    {
        private readonly DBContext _context;

        public EderailersController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Ederailers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ederailers>>> GetEderailers()
        {
            return await _context.Ederailers.ToListAsync();
        }

        // GET: api/Ederailers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ederailers>> GetEderailers(long id)
        {
            var ederailers = await _context.Ederailers.FindAsync(id);

            if (ederailers == null)
            {
                return NotFound();
            }

            return ederailers;
        }

        // PUT: api/Ederailers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEderailers(long id, Ederailers ederailers)
        {
            if (id != ederailers.EderailersId)
            {
                return BadRequest();
            }

            _context.Entry(ederailers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EderailersExists(id))
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

        // POST: api/Ederailers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Ederailers>> PostEderailers(Ederailers ederailers)
        {
            _context.Ederailers.Add(ederailers);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EderailersExists(ederailers.EderailersId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEderailers", new { id = ederailers.EderailersId }, ederailers);
        }

        // DELETE: api/Ederailers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Ederailers>> DeleteEderailers(long id)
        {
            var ederailers = await _context.Ederailers.FindAsync(id);
            if (ederailers == null)
            {
                return NotFound();
            }

            _context.Ederailers.Remove(ederailers);
            await _context.SaveChangesAsync();

            return ederailers;
        }

        private bool EderailersExists(long id)
        {
            return _context.Ederailers.Any(e => e.EderailersId == id);
        }
    }
}
