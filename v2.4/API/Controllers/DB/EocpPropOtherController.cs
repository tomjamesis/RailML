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
    public class EocpPropOtherController : ControllerBase
    {
        private readonly DBContext _context;

        public EocpPropOtherController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EocpPropOther
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EocpPropOther>>> GetEocpPropOther()
        {
            return await _context.EocpPropOther.ToListAsync();
        }

        // GET: api/EocpPropOther/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EocpPropOther>> GetEocpPropOther(short id)
        {
            var eocpPropOther = await _context.EocpPropOther.FindAsync(id);

            if (eocpPropOther == null)
            {
                return NotFound();
            }

            return eocpPropOther;
        }

        // PUT: api/EocpPropOther/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEocpPropOther(short id, EocpPropOther eocpPropOther)
        {
            if (id != eocpPropOther.EocpPropOtherId)
            {
                return BadRequest();
            }

            _context.Entry(eocpPropOther).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EocpPropOtherExists(id))
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

        // POST: api/EocpPropOther
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EocpPropOther>> PostEocpPropOther(EocpPropOther eocpPropOther)
        {
            _context.EocpPropOther.Add(eocpPropOther);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EocpPropOtherExists(eocpPropOther.EocpPropOtherId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEocpPropOther", new { id = eocpPropOther.EocpPropOtherId }, eocpPropOther);
        }

        // DELETE: api/EocpPropOther/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EocpPropOther>> DeleteEocpPropOther(short id)
        {
            var eocpPropOther = await _context.EocpPropOther.FindAsync(id);
            if (eocpPropOther == null)
            {
                return NotFound();
            }

            _context.EocpPropOther.Remove(eocpPropOther);
            await _context.SaveChangesAsync();

            return eocpPropOther;
        }

        private bool EocpPropOtherExists(short id)
        {
            return _context.EocpPropOther.Any(e => e.EocpPropOtherId == id);
        }
    }
}
