using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using REST_BOT.Models;

namespace REST_BOT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DayPlannersController : ControllerBase
    {
        private readonly DayPlannerContext _context;

        public DayPlannersController(DayPlannerContext context)
        {
            _context = context;
        }

        // GET: api/DayPlanners
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DayPlanner>>> GetDayPlanners()
        {
          if (_context.planners == null)
            {
                return NotFound();
          }
            return await _context.planners.ToListAsync();
        }

        // GET: api/DayPlanners/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DayPlanner>> GetDayPlanner(int id)
        {
          if (_context.planners == null)
          {
              return NotFound();
          }
            var dayPlanner = await _context.planners.FindAsync(id);

            if (dayPlanner == null)
            {
                return NotFound();
            }

            return dayPlanner;
        }

        // PUT: api/DayPlanners/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDayPlanner(int id, DayPlanner dayPlanner)
        {
            if (id != dayPlanner.Id)
            {
                return BadRequest();
            }

            _context.Entry(dayPlanner).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DayPlannerExists(id))
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

        // POST: api/DayPlanners
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DayPlanner>> PostDayPlanner(DayPlanner dayPlanner)
        {
            
            Response.Headers.Add("Access-Control-Allow-Origin", "*");
            _context.planners.Add(dayPlanner);
            await _context.SaveChangesAsync();

            //    return CreatedAtAction("PostTodoItem", new { id = todoItem.Id }, todoItem);
            return CreatedAtAction(nameof(PostDayPlanner), new { id = dayPlanner.Id }, dayPlanner);
        }

        // DELETE: api/DayPlanners/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDayPlanner(int id)
        {
            if (_context.planners == null)
            {
                return NotFound();
            }
            var dayPlanner = await _context.planners.FindAsync(id);
            if (dayPlanner == null)
            {
                return NotFound();
            }

            _context.planners.Remove(dayPlanner);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DayPlannerExists(int id)
        {
            return (_context.planners?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
