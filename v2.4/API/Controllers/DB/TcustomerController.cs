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
    public class TcustomerController : ControllerBase
    {
        private readonly DBContext _context;

        public TcustomerController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tcustomer
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tcustomer>>> GetTcustomer()
        {
            return await _context.Tcustomer.ToListAsync();
        }

        // GET: api/Tcustomer/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tcustomer>> GetTcustomer(short id)
        {
            var tcustomer = await _context.Tcustomer.FindAsync(id);

            if (tcustomer == null)
            {
                return NotFound();
            }

            return tcustomer;
        }

        // PUT: api/Tcustomer/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTcustomer(short id, Tcustomer tcustomer)
        {
            if (id != tcustomer.TcustomerId)
            {
                return BadRequest();
            }

            _context.Entry(tcustomer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TcustomerExists(id))
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

        // POST: api/Tcustomer
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tcustomer>> PostTcustomer(Tcustomer tcustomer)
        {
            _context.Tcustomer.Add(tcustomer);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TcustomerExists(tcustomer.TcustomerId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTcustomer", new { id = tcustomer.TcustomerId }, tcustomer);
        }

        // DELETE: api/Tcustomer/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tcustomer>> DeleteTcustomer(short id)
        {
            var tcustomer = await _context.Tcustomer.FindAsync(id);
            if (tcustomer == null)
            {
                return NotFound();
            }

            _context.Tcustomer.Remove(tcustomer);
            await _context.SaveChangesAsync();

            return tcustomer;
        }

        private bool TcustomerExists(short id)
        {
            return _context.Tcustomer.Any(e => e.TcustomerId == id);
        }
    }
}
