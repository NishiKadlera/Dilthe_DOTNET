#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MvcsController : ControllerBase
    {
        private readonly FirstCoreMVCContext _context;

        public MvcsController(FirstCoreMVCContext context)
        {
            _context = context;
        }

        // GET: api/Mvcs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mvc>>> GetMvcs()
        {
            return await _context.Mvcs.ToListAsync();
        }

        // GET: api/Mvcs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Mvc>> GetMvc(int id)
        {
            var mvc = await _context.Mvcs.FindAsync(id);

            if (mvc == null)
            {
                return NotFound();
            }

            return mvc;
        }

        // PUT: api/Mvcs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMvc(int id, Mvc mvc)
        {
            if (id != mvc.Id)
            {
                return BadRequest();
            }

            _context.Entry(mvc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MvcExists(id))
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

        // POST: api/Mvcs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Mvc>> PostMvc(Mvc mvc)
        {
            _context.Mvcs.Add(mvc);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MvcExists(mvc.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMvc", new { id = mvc.Id }, mvc);
        }

        // DELETE: api/Mvcs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMvc(int id)
        {
            var mvc = await _context.Mvcs.FindAsync(id);
            if (mvc == null)
            {
                return NotFound();
            }

            _context.Mvcs.Remove(mvc);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MvcExists(int id)
        {
            return _context.Mvcs.Any(e => e.Id == id);
        }
    }
}
