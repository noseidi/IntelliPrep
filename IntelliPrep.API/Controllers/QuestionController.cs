using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntelliPrep.API.Data;
using IntelliPrep.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IntelliPrep.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuestionController : ControllerBase
    {
        private readonly IntelliPrepDbContext _context;

        public QuestionController(IntelliPrepDbContext context)
        {
            _context = context;
        }

        // GET: api/Question
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Question>>> GetQuestions()
        {
            return await _context.Questions
                .Include(q => q.Test)
                    .ThenInclude(t => t.Topic)
                .ToListAsync();
        }

        // GET: api/Question/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Question>> GetQuestion(int id)
        {
            var question = await _context.Questions
                .Include(q => q.Test)
                    .ThenInclude(t => t.Topic)
                .FirstOrDefaultAsync(q => q.Id == id);

            if (question == null)
            {
                return NotFound();
            }

            return question;
        }

        // POST: api/Question
        [HttpPost]
        public async Task<ActionResult<Question>> CreateQuestion(Question question)
        {
            _context.Questions.Add(question);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetQuestion), new { id = question.Id }, question);
        }

        // PUT: api/Question/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateQuestion(int id, Question question)
        {
            if (id != question.Id)
                return BadRequest();

            _context.Entry(question).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuestionExists(id))
                    return NotFound();
                else
                    throw;
            }

            return NoContent();
        }

        // DELETE: api/Question/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuestion(int id)
        {
            var question = await _context.Questions.FindAsync(id);
            if (question == null)
                return NotFound();

            _context.Questions.Remove(question);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool QuestionExists(int id)
        {
            return _context.Questions.Any(q => q.Id == id);
        }
    }
}