using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlogAPI.Data;
using BlogAPI.Models.Domain.Concrete;

namespace BlogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCommentsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public SubCommentsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/SubComments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubComment>>> GetSubComment()
        {
          if (_context.SubComment == null)
          {
              return NotFound();
          }
            return await _context.SubComment.ToListAsync();
        }

        // GET: api/SubComments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SubComment>> GetSubComment(int id)
        {
          if (_context.SubComment == null)
          {
              return NotFound();
          }
            var subComment = await _context.SubComment.FindAsync(id);

            if (subComment == null)
            {
                return NotFound();
            }

            return subComment;
        }

        // PUT: api/SubComments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSubComment(int id, SubComment subComment)
        {
            if (id != subComment.Id)
            {
                return BadRequest();
            }

            _context.Entry(subComment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubCommentExists(id))
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

        // POST: api/SubComments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SubComment>> PostSubComment(SubComment subComment)
        {
          if (_context.SubComment == null)
          {
              return Problem("Entity set 'ApplicationContext.SubComment'  is null.");
          }
            _context.SubComment.Add(subComment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSubComment", new { id = subComment.Id }, subComment);
        }

        // DELETE: api/SubComments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSubComment(int id)
        {
            if (_context.SubComment == null)
            {
                return NotFound();
            }
            var subComment = await _context.SubComment.FindAsync(id);
            if (subComment == null)
            {
                return NotFound();
            }

            _context.SubComment.Remove(subComment);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SubCommentExists(int id)
        {
            return (_context.SubComment?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
