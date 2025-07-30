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
    public class TopicController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TopicController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Topic>>> GetAll()
        {
            return await _context.Topics.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Topic>> Create(Topic topic)
        {
            _context.Topics.Add(topic);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAll), new { id = topic.Id }, topic);
        }
    }
}