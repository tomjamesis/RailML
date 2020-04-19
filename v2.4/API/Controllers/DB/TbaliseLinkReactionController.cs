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
    public class TbaliseLinkReactionController : ControllerBase
    {
        private readonly DBContext _context;

        public TbaliseLinkReactionController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TbaliseLinkReaction
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TbaliseLinkReaction>>> GetTbaliseLinkReaction()
        {
            return await _context.TbaliseLinkReaction.ToListAsync();
        }

        // GET: api/TbaliseLinkReaction/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TbaliseLinkReaction>> GetTbaliseLinkReaction(byte id)
        {
            var tbaliseLinkReaction = await _context.TbaliseLinkReaction.FindAsync(id);

            if (tbaliseLinkReaction == null)
            {
                return NotFound();
            }

            return tbaliseLinkReaction;
        }

        // PUT: api/TbaliseLinkReaction/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTbaliseLinkReaction(byte id, TbaliseLinkReaction tbaliseLinkReaction)
        {
            if (id != tbaliseLinkReaction.TbaliseLinkReactionId)
            {
                return BadRequest();
            }

            _context.Entry(tbaliseLinkReaction).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TbaliseLinkReactionExists(id))
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

        // POST: api/TbaliseLinkReaction
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TbaliseLinkReaction>> PostTbaliseLinkReaction(TbaliseLinkReaction tbaliseLinkReaction)
        {
            _context.TbaliseLinkReaction.Add(tbaliseLinkReaction);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TbaliseLinkReactionExists(tbaliseLinkReaction.TbaliseLinkReactionId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTbaliseLinkReaction", new { id = tbaliseLinkReaction.TbaliseLinkReactionId }, tbaliseLinkReaction);
        }

        // DELETE: api/TbaliseLinkReaction/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TbaliseLinkReaction>> DeleteTbaliseLinkReaction(byte id)
        {
            var tbaliseLinkReaction = await _context.TbaliseLinkReaction.FindAsync(id);
            if (tbaliseLinkReaction == null)
            {
                return NotFound();
            }

            _context.TbaliseLinkReaction.Remove(tbaliseLinkReaction);
            await _context.SaveChangesAsync();

            return tbaliseLinkReaction;
        }

        private bool TbaliseLinkReactionExists(byte id)
        {
            return _context.TbaliseLinkReaction.Any(e => e.TbaliseLinkReactionId == id);
        }
    }
}
