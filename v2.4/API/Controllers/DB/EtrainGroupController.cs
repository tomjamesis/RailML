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
    public class EtrainGroupController : ControllerBase
    {
        private readonly DBContext _context;

        public EtrainGroupController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EtrainGroup
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EtrainGroup>>> GetEtrainGroup()
        {
            return await _context.EtrainGroup.ToListAsync();
        }

        // GET: api/EtrainGroup/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EtrainGroup>> GetEtrainGroup(short id)
        {
            var etrainGroup = await _context.EtrainGroup.FindAsync(id);

            if (etrainGroup == null)
            {
                return NotFound();
            }

            return etrainGroup;
        }

        // PUT: api/EtrainGroup/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEtrainGroup(short id, EtrainGroup etrainGroup)
        {
            if (id != etrainGroup.EtrainGroupId)
            {
                return BadRequest();
            }

            _context.Entry(etrainGroup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EtrainGroupExists(id))
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

        // POST: api/EtrainGroup
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EtrainGroup>> PostEtrainGroup(EtrainGroup etrainGroup)
        {
            _context.EtrainGroup.Add(etrainGroup);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EtrainGroupExists(etrainGroup.EtrainGroupId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEtrainGroup", new { id = etrainGroup.EtrainGroupId }, etrainGroup);
        }

        // DELETE: api/EtrainGroup/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EtrainGroup>> DeleteEtrainGroup(short id)
        {
            var etrainGroup = await _context.EtrainGroup.FindAsync(id);
            if (etrainGroup == null)
            {
                return NotFound();
            }

            _context.EtrainGroup.Remove(etrainGroup);
            await _context.SaveChangesAsync();

            return etrainGroup;
        }

        private bool EtrainGroupExists(short id)
        {
            return _context.EtrainGroup.Any(e => e.EtrainGroupId == id);
        }
    }
}
