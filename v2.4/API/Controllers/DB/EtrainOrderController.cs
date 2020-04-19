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
    public class EtrainOrderController : ControllerBase
    {
        private readonly DBContext _context;

        public EtrainOrderController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EtrainOrder
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EtrainOrder>>> GetEtrainOrder()
        {
            return await _context.EtrainOrder.ToListAsync();
        }

        // GET: api/EtrainOrder/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EtrainOrder>> GetEtrainOrder(long id)
        {
            var etrainOrder = await _context.EtrainOrder.FindAsync(id);

            if (etrainOrder == null)
            {
                return NotFound();
            }

            return etrainOrder;
        }

        // PUT: api/EtrainOrder/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEtrainOrder(long id, EtrainOrder etrainOrder)
        {
            if (id != etrainOrder.EtrainOrderId)
            {
                return BadRequest();
            }

            _context.Entry(etrainOrder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EtrainOrderExists(id))
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

        // POST: api/EtrainOrder
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EtrainOrder>> PostEtrainOrder(EtrainOrder etrainOrder)
        {
            _context.EtrainOrder.Add(etrainOrder);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EtrainOrderExists(etrainOrder.EtrainOrderId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEtrainOrder", new { id = etrainOrder.EtrainOrderId }, etrainOrder);
        }

        // DELETE: api/EtrainOrder/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EtrainOrder>> DeleteEtrainOrder(long id)
        {
            var etrainOrder = await _context.EtrainOrder.FindAsync(id);
            if (etrainOrder == null)
            {
                return NotFound();
            }

            _context.EtrainOrder.Remove(etrainOrder);
            await _context.SaveChangesAsync();

            return etrainOrder;
        }

        private bool EtrainOrderExists(long id)
        {
            return _context.EtrainOrder.Any(e => e.EtrainOrderId == id);
        }
    }
}
