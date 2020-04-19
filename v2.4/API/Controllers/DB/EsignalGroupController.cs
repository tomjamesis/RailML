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
    public class EsignalGroupController : ControllerBase
    {
        private readonly DBContext _context;

        public EsignalGroupController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EsignalGroup
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EsignalGroup>>> GetEsignalGroup()
        {
            return await _context.EsignalGroup.ToListAsync();
        }

        // GET: api/EsignalGroup/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EsignalGroup>> GetEsignalGroup(short id)
        {
            var esignalGroup = await _context.EsignalGroup.FindAsync(id);

            if (esignalGroup == null)
            {
                return NotFound();
            }

            return esignalGroup;
        }

        // PUT: api/EsignalGroup/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEsignalGroup(short id, EsignalGroup esignalGroup)
        {
            if (id != esignalGroup.EsignalGroupId)
            {
                return BadRequest();
            }

            _context.Entry(esignalGroup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EsignalGroupExists(id))
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

        // POST: api/EsignalGroup
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EsignalGroup>> PostEsignalGroup(EsignalGroup esignalGroup)
        {
            _context.EsignalGroup.Add(esignalGroup);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EsignalGroupExists(esignalGroup.EsignalGroupId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEsignalGroup", new { id = esignalGroup.EsignalGroupId }, esignalGroup);
        }

        // DELETE: api/EsignalGroup/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EsignalGroup>> DeleteEsignalGroup(short id)
        {
            var esignalGroup = await _context.EsignalGroup.FindAsync(id);
            if (esignalGroup == null)
            {
                return NotFound();
            }

            _context.EsignalGroup.Remove(esignalGroup);
            await _context.SaveChangesAsync();

            return esignalGroup;
        }

        private bool EsignalGroupExists(short id)
        {
            return _context.EsignalGroup.Any(e => e.EsignalGroupId == id);
        }
    }
}
