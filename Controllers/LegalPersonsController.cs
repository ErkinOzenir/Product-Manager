using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductManagementApp.Models;

namespace ProductManagementApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LegalPersonsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public LegalPersonsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/LegalPersons
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LegalPerson>>> GetLegalPersons()
        {
            return await _context.LegalPersons.ToListAsync();
        }

        // GET: api/LegalPersons/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LegalPerson>> GetLegalPerson(int id)
        {
            var legalPerson = await _context.LegalPersons.FindAsync(id);

            if (legalPerson == null)
            {
                return NotFound();
            }

            return legalPerson;
        }

        // POST: api/LegalPersons
        [HttpPost]
        public async Task<ActionResult<LegalPerson>> PostLegalPerson(LegalPerson legalPerson)
        {
            _context.LegalPersons.Add(legalPerson);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetLegalPerson), new { id = legalPerson.Id }, legalPerson);
        }

        // PUT: api/LegalPersons/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLegalPerson(int id, LegalPerson legalPerson)
        {
            if (id != legalPerson.Id)
            {
                return BadRequest();
            }

            _context.Entry(legalPerson).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LegalPersonExists(id))
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

        // DELETE: api/LegalPersons/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLegalPerson(int id)
        {
            var legalPerson = await _context.LegalPersons.FindAsync(id);
            if (legalPerson == null)
            {
                return NotFound();
            }

            _context.LegalPersons.Remove(legalPerson);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LegalPersonExists(int id)
        {
            return _context.LegalPersons.Any(e => e.Id == id);
        }
    }
}
