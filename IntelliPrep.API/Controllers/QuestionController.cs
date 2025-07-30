using IntelliPrep.API.Data;
using IntelliPrep.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IntelliPrep.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuestionController : ControllerBase
    {
        private readonly AppDbContext _context;
        public QuestionController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetQuestions()
        {
            var questions = await _context.Questions.Include(q => q.Topic).ToListAsync();
            return Ok(questions);
        }

        [HttpPost]
        public async Task<IActionResult> AddQuestion([FromBody] Question question)
        {
            _context.Questions.Add(question);
            await _context.SaveChangesAsync();
            return Ok(question);
        }
    }
}