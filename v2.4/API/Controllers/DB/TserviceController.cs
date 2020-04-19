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
    public class TserviceController : ControllerBase
    {
        private readonly DBContext _context;

        public TserviceController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tservice
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tservice>>> GetTservice()
        {
            return await _context.Tservice.ToListAsync();
        }

        // GET: api/Tservice/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tservice>> GetTservice(long id)
        {
            var tservice = await _context.Tservice.FindAsync(id);

            if (tservice == null)
            {
                return NotFound();
            }

            return tservice;
        }

        // PUT: api/Tservice/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTservice(long id, Tservice tservice)
        {
            if (id != tservice.TserviceId)
            {
                return BadRequest();
            }

            _context.Entry(tservice).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TserviceExists(id))
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

        // POST: api/Tservice
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tservice>> PostTservice(Tservice tservice)
        {
            _context.Tservice.Add(tservice);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TserviceExists(tservice.TserviceId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTservice", new { id = tservice.TserviceId }, tservice);
        }

        // DELETE: api/Tservice/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tservice>> DeleteTservice(long id)
        {
            var tservice = await _context.Tservice.FindAsync(id);
            if (tservice == null)
            {
                return NotFound();
            }

            _context.Tservice.Remove(tservice);
            await _context.SaveChangesAsync();

            return tservice;
        }

        private bool TserviceExists(long id)
        {
            return _context.Tservice.Any(e => e.TserviceId == id);
        }
    }
}
