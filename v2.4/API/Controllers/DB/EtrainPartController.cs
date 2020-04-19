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
    public class EtrainPartController : ControllerBase
    {
        private readonly DBContext _context;

        public EtrainPartController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EtrainPart
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EtrainPart>>> GetEtrainPart()
        {
            return await _context.EtrainPart.ToListAsync();
        }

        // GET: api/EtrainPart/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EtrainPart>> GetEtrainPart(short id)
        {
            var etrainPart = await _context.EtrainPart.FindAsync(id);

            if (etrainPart == null)
            {
                return NotFound();
            }

            return etrainPart;
        }

        // PUT: api/EtrainPart/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEtrainPart(short id, EtrainPart etrainPart)
        {
            if (id != etrainPart.EtrainPartId)
            {
                return BadRequest();
            }

            _context.Entry(etrainPart).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EtrainPartExists(id))
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

        // POST: api/EtrainPart
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EtrainPart>> PostEtrainPart(EtrainPart etrainPart)
        {
            _context.EtrainPart.Add(etrainPart);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EtrainPartExists(etrainPart.EtrainPartId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEtrainPart", new { id = etrainPart.EtrainPartId }, etrainPart);
        }

        // DELETE: api/EtrainPart/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EtrainPart>> DeleteEtrainPart(short id)
        {
            var etrainPart = await _context.EtrainPart.FindAsync(id);
            if (etrainPart == null)
            {
                return NotFound();
            }

            _context.EtrainPart.Remove(etrainPart);
            await _context.SaveChangesAsync();

            return etrainPart;
        }

        private bool EtrainPartExists(short id)
        {
            return _context.EtrainPart.Any(e => e.EtrainPartId == id);
        }
    }
}
