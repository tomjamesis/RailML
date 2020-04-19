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
    public class TtrackNodeController : ControllerBase
    {
        private readonly DBContext _context;

        public TtrackNodeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TtrackNode
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TtrackNode>>> GetTtrackNode()
        {
            return await _context.TtrackNode.ToListAsync();
        }

        // GET: api/TtrackNode/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TtrackNode>> GetTtrackNode(string id)
        {
            var ttrackNode = await _context.TtrackNode.FindAsync(id);

            if (ttrackNode == null)
            {
                return NotFound();
            }

            return ttrackNode;
        }

        // PUT: api/TtrackNode/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTtrackNode(string id, TtrackNode ttrackNode)
        {
            if (id != ttrackNode.TtrackNodeId)
            {
                return BadRequest();
            }

            _context.Entry(ttrackNode).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TtrackNodeExists(id))
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

        // POST: api/TtrackNode
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TtrackNode>> PostTtrackNode(TtrackNode ttrackNode)
        {
            _context.TtrackNode.Add(ttrackNode);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TtrackNodeExists(ttrackNode.TtrackNodeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTtrackNode", new { id = ttrackNode.TtrackNodeId }, ttrackNode);
        }

        // DELETE: api/TtrackNode/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TtrackNode>> DeleteTtrackNode(string id)
        {
            var ttrackNode = await _context.TtrackNode.FindAsync(id);
            if (ttrackNode == null)
            {
                return NotFound();
            }

            _context.TtrackNode.Remove(ttrackNode);
            await _context.SaveChangesAsync();

            return ttrackNode;
        }

        private bool TtrackNodeExists(string id)
        {
            return _context.TtrackNode.Any(e => e.TtrackNodeId == id);
        }
    }
}
