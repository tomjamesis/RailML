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
    public class EtransformerController : ControllerBase
    {
        private readonly DBContext _context;

        public EtransformerController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Etransformer
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Etransformer>>> GetEtransformer()
        {
            return await _context.Etransformer.ToListAsync();
        }

        // GET: api/Etransformer/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Etransformer>> GetEtransformer(short id)
        {
            var etransformer = await _context.Etransformer.FindAsync(id);

            if (etransformer == null)
            {
                return NotFound();
            }

            return etransformer;
        }

        // PUT: api/Etransformer/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEtransformer(short id, Etransformer etransformer)
        {
            if (id != etransformer.EtransformerId)
            {
                return BadRequest();
            }

            _context.Entry(etransformer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EtransformerExists(id))
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

        // POST: api/Etransformer
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Etransformer>> PostEtransformer(Etransformer etransformer)
        {
            _context.Etransformer.Add(etransformer);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EtransformerExists(etransformer.EtransformerId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEtransformer", new { id = etransformer.EtransformerId }, etransformer);
        }

        // DELETE: api/Etransformer/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Etransformer>> DeleteEtransformer(short id)
        {
            var etransformer = await _context.Etransformer.FindAsync(id);
            if (etransformer == null)
            {
                return NotFound();
            }

            _context.Etransformer.Remove(etransformer);
            await _context.SaveChangesAsync();

            return etransformer;
        }

        private bool EtransformerExists(short id)
        {
            return _context.Etransformer.Any(e => e.EtransformerId == id);
        }
    }
}
