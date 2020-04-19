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
    public class TcontrollerController : ControllerBase
    {
        private readonly DBContext _context;

        public TcontrollerController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tcontroller
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tcontroller>>> GetTcontroller()
        {
            return await _context.Tcontroller.ToListAsync();
        }

        // GET: api/Tcontroller/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tcontroller>> GetTcontroller(short id)
        {
            var tcontroller = await _context.Tcontroller.FindAsync(id);

            if (tcontroller == null)
            {
                return NotFound();
            }

            return tcontroller;
        }

        // PUT: api/Tcontroller/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTcontroller(short id, Tcontroller tcontroller)
        {
            if (id != tcontroller.TcontrollerId)
            {
                return BadRequest();
            }

            _context.Entry(tcontroller).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TcontrollerExists(id))
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

        // POST: api/Tcontroller
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tcontroller>> PostTcontroller(Tcontroller tcontroller)
        {
            _context.Tcontroller.Add(tcontroller);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TcontrollerExists(tcontroller.TcontrollerId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTcontroller", new { id = tcontroller.TcontrollerId }, tcontroller);
        }

        // DELETE: api/Tcontroller/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tcontroller>> DeleteTcontroller(short id)
        {
            var tcontroller = await _context.Tcontroller.FindAsync(id);
            if (tcontroller == null)
            {
                return NotFound();
            }

            _context.Tcontroller.Remove(tcontroller);
            await _context.SaveChangesAsync();

            return tcontroller;
        }

        private bool TcontrollerExists(short id)
        {
            return _context.Tcontroller.Any(e => e.TcontrollerId == id);
        }
    }
}
