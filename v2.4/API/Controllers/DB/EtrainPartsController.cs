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
    public class EtrainPartsController : ControllerBase
    {
        private readonly DBContext _context;

        public EtrainPartsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EtrainParts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EtrainParts>>> GetEtrainParts()
        {
            return await _context.EtrainParts.ToListAsync();
        }

        // GET: api/EtrainParts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EtrainParts>> GetEtrainParts(long id)
        {
            var etrainParts = await _context.EtrainParts.FindAsync(id);

            if (etrainParts == null)
            {
                return NotFound();
            }

            return etrainParts;
        }

        // PUT: api/EtrainParts/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEtrainParts(long id, EtrainParts etrainParts)
        {
            if (id != etrainParts.EtrainPartsId)
            {
                return BadRequest();
            }

            _context.Entry(etrainParts).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EtrainPartsExists(id))
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

        // POST: api/EtrainParts
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EtrainParts>> PostEtrainParts(EtrainParts etrainParts)
        {
            _context.EtrainParts.Add(etrainParts);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EtrainPartsExists(etrainParts.EtrainPartsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEtrainParts", new { id = etrainParts.EtrainPartsId }, etrainParts);
        }

        // DELETE: api/EtrainParts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EtrainParts>> DeleteEtrainParts(long id)
        {
            var etrainParts = await _context.EtrainParts.FindAsync(id);
            if (etrainParts == null)
            {
                return NotFound();
            }

            _context.EtrainParts.Remove(etrainParts);
            await _context.SaveChangesAsync();

            return etrainParts;
        }

        private bool EtrainPartsExists(long id)
        {
            return _context.EtrainParts.Any(e => e.EtrainPartsId == id);
        }
    }
}
