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
    public class EsignalGroupsController : ControllerBase
    {
        private readonly DBContext _context;

        public EsignalGroupsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EsignalGroups
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EsignalGroups>>> GetEsignalGroups()
        {
            return await _context.EsignalGroups.ToListAsync();
        }

        // GET: api/EsignalGroups/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EsignalGroups>> GetEsignalGroups(long id)
        {
            var esignalGroups = await _context.EsignalGroups.FindAsync(id);

            if (esignalGroups == null)
            {
                return NotFound();
            }

            return esignalGroups;
        }

        // PUT: api/EsignalGroups/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEsignalGroups(long id, EsignalGroups esignalGroups)
        {
            if (id != esignalGroups.EsignalGroupsId)
            {
                return BadRequest();
            }

            _context.Entry(esignalGroups).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EsignalGroupsExists(id))
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

        // POST: api/EsignalGroups
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EsignalGroups>> PostEsignalGroups(EsignalGroups esignalGroups)
        {
            _context.EsignalGroups.Add(esignalGroups);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EsignalGroupsExists(esignalGroups.EsignalGroupsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEsignalGroups", new { id = esignalGroups.EsignalGroupsId }, esignalGroups);
        }

        // DELETE: api/EsignalGroups/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EsignalGroups>> DeleteEsignalGroups(long id)
        {
            var esignalGroups = await _context.EsignalGroups.FindAsync(id);
            if (esignalGroups == null)
            {
                return NotFound();
            }

            _context.EsignalGroups.Remove(esignalGroups);
            await _context.SaveChangesAsync();

            return esignalGroups;
        }

        private bool EsignalGroupsExists(long id)
        {
            return _context.EsignalGroups.Any(e => e.EsignalGroupsId == id);
        }
    }
}
