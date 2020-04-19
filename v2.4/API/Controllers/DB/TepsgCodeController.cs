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
    public class TepsgCodeController : ControllerBase
    {
        private readonly DBContext _context;

        public TepsgCodeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TepsgCode
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TepsgCode>>> GetTepsgCode()
        {
            return await _context.TepsgCode.ToListAsync();
        }

        // GET: api/TepsgCode/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TepsgCode>> GetTepsgCode(long id)
        {
            var tepsgCode = await _context.TepsgCode.FindAsync(id);

            if (tepsgCode == null)
            {
                return NotFound();
            }

            return tepsgCode;
        }

        // PUT: api/TepsgCode/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTepsgCode(long id, TepsgCode tepsgCode)
        {
            if (id != tepsgCode.TepsgCodeId)
            {
                return BadRequest();
            }

            _context.Entry(tepsgCode).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TepsgCodeExists(id))
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

        // POST: api/TepsgCode
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TepsgCode>> PostTepsgCode(TepsgCode tepsgCode)
        {
            _context.TepsgCode.Add(tepsgCode);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TepsgCodeExists(tepsgCode.TepsgCodeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTepsgCode", new { id = tepsgCode.TepsgCodeId }, tepsgCode);
        }

        // DELETE: api/TepsgCode/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TepsgCode>> DeleteTepsgCode(long id)
        {
            var tepsgCode = await _context.TepsgCode.FindAsync(id);
            if (tepsgCode == null)
            {
                return NotFound();
            }

            _context.TepsgCode.Remove(tepsgCode);
            await _context.SaveChangesAsync();

            return tepsgCode;
        }

        private bool TepsgCodeExists(long id)
        {
            return _context.TepsgCode.Any(e => e.TepsgCodeId == id);
        }
    }
}
