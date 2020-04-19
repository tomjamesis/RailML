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
    public class EtapTsiTransportOperationalIdentifierController : ControllerBase
    {
        private readonly DBContext _context;

        public EtapTsiTransportOperationalIdentifierController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EtapTsiTransportOperationalIdentifier
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EtapTsiTransportOperationalIdentifier>>> GetEtapTsiTransportOperationalIdentifier()
        {
            return await _context.EtapTsiTransportOperationalIdentifier.ToListAsync();
        }

        // GET: api/EtapTsiTransportOperationalIdentifier/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EtapTsiTransportOperationalIdentifier>> GetEtapTsiTransportOperationalIdentifier(short id)
        {
            var etapTsiTransportOperationalIdentifier = await _context.EtapTsiTransportOperationalIdentifier.FindAsync(id);

            if (etapTsiTransportOperationalIdentifier == null)
            {
                return NotFound();
            }

            return etapTsiTransportOperationalIdentifier;
        }

        // PUT: api/EtapTsiTransportOperationalIdentifier/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEtapTsiTransportOperationalIdentifier(short id, EtapTsiTransportOperationalIdentifier etapTsiTransportOperationalIdentifier)
        {
            if (id != etapTsiTransportOperationalIdentifier.EtapTsiTransportOperationalIdentifierId)
            {
                return BadRequest();
            }

            _context.Entry(etapTsiTransportOperationalIdentifier).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EtapTsiTransportOperationalIdentifierExists(id))
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

        // POST: api/EtapTsiTransportOperationalIdentifier
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EtapTsiTransportOperationalIdentifier>> PostEtapTsiTransportOperationalIdentifier(EtapTsiTransportOperationalIdentifier etapTsiTransportOperationalIdentifier)
        {
            _context.EtapTsiTransportOperationalIdentifier.Add(etapTsiTransportOperationalIdentifier);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EtapTsiTransportOperationalIdentifierExists(etapTsiTransportOperationalIdentifier.EtapTsiTransportOperationalIdentifierId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEtapTsiTransportOperationalIdentifier", new { id = etapTsiTransportOperationalIdentifier.EtapTsiTransportOperationalIdentifierId }, etapTsiTransportOperationalIdentifier);
        }

        // DELETE: api/EtapTsiTransportOperationalIdentifier/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EtapTsiTransportOperationalIdentifier>> DeleteEtapTsiTransportOperationalIdentifier(short id)
        {
            var etapTsiTransportOperationalIdentifier = await _context.EtapTsiTransportOperationalIdentifier.FindAsync(id);
            if (etapTsiTransportOperationalIdentifier == null)
            {
                return NotFound();
            }

            _context.EtapTsiTransportOperationalIdentifier.Remove(etapTsiTransportOperationalIdentifier);
            await _context.SaveChangesAsync();

            return etapTsiTransportOperationalIdentifier;
        }

        private bool EtapTsiTransportOperationalIdentifierExists(short id)
        {
            return _context.EtapTsiTransportOperationalIdentifier.Any(e => e.EtapTsiTransportOperationalIdentifierId == id);
        }
    }
}
