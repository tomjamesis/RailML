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
    public class EorganizationalUnitBindingController : ControllerBase
    {
        private readonly DBContext _context;

        public EorganizationalUnitBindingController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EorganizationalUnitBinding
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EorganizationalUnitBinding>>> GetEorganizationalUnitBinding()
        {
            return await _context.EorganizationalUnitBinding.ToListAsync();
        }

        // GET: api/EorganizationalUnitBinding/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EorganizationalUnitBinding>> GetEorganizationalUnitBinding(long id)
        {
            var eorganizationalUnitBinding = await _context.EorganizationalUnitBinding.FindAsync(id);

            if (eorganizationalUnitBinding == null)
            {
                return NotFound();
            }

            return eorganizationalUnitBinding;
        }

        // PUT: api/EorganizationalUnitBinding/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEorganizationalUnitBinding(long id, EorganizationalUnitBinding eorganizationalUnitBinding)
        {
            if (id != eorganizationalUnitBinding.EorganizationalUnitBindingId)
            {
                return BadRequest();
            }

            _context.Entry(eorganizationalUnitBinding).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EorganizationalUnitBindingExists(id))
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

        // POST: api/EorganizationalUnitBinding
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EorganizationalUnitBinding>> PostEorganizationalUnitBinding(EorganizationalUnitBinding eorganizationalUnitBinding)
        {
            _context.EorganizationalUnitBinding.Add(eorganizationalUnitBinding);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EorganizationalUnitBindingExists(eorganizationalUnitBinding.EorganizationalUnitBindingId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEorganizationalUnitBinding", new { id = eorganizationalUnitBinding.EorganizationalUnitBindingId }, eorganizationalUnitBinding);
        }

        // DELETE: api/EorganizationalUnitBinding/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EorganizationalUnitBinding>> DeleteEorganizationalUnitBinding(long id)
        {
            var eorganizationalUnitBinding = await _context.EorganizationalUnitBinding.FindAsync(id);
            if (eorganizationalUnitBinding == null)
            {
                return NotFound();
            }

            _context.EorganizationalUnitBinding.Remove(eorganizationalUnitBinding);
            await _context.SaveChangesAsync();

            return eorganizationalUnitBinding;
        }

        private bool EorganizationalUnitBindingExists(long id)
        {
            return _context.EorganizationalUnitBinding.Any(e => e.EorganizationalUnitBindingId == id);
        }
    }
}
