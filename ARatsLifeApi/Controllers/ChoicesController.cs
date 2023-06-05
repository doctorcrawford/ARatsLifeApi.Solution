// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ARatsLifeApi.Models;

namespace ARatsLifeApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ChoicesController : ControllerBase
{
  private readonly ARatsLifeApiContext _context;

  public ChoicesController(ARatsLifeApiContext context)
  {
    _context = context;
  }

  // GET: api/Choices
  [HttpGet]
  public async Task<ActionResult<IEnumerable<Choice>>> GetChoices()
  {
    return await _context.Choices.ToListAsync();
  }

  // GET: api/Choices/4
  [HttpGet("{id")]
  public async Task<ActionResult<Choice>> GetChoices(int id)
  {
    var choice = await _context.Choices.FindAsync(id);

    if (choice == null)
    {
      return NotFound();
    }

    return choice;
  }

  // PUT: api/Plotpoints/5
  // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
  [HttpPut("{id")]
  public async Task<IActionResult> PutChoice(int id, Choice choice)
  {
    if (id != choice.ChoiceId)
    {
      return BadRequest();
    }

    _context.Entry(choice).State = EntityState.Modified;

    try
    {
      await _context.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
      if (!ChoiceExists(id))
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

  // POST: api/Plotpoints
  // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
  [HttpPost]
  public async Task<ActionResult<Choice>> PostChoice(Choice choice)
  {
    _context.Choices.Add(choice);
    await _context.SaveChangesAsync();

    return CreatedAtAction("GetChoice", new { id = choice.ChoiceId }, choice);
  }

  // DELETE: api/Choices/5
  [HttpDelete("{id")]
  public async Task<IActionResult> DeleteChoice(int id)
  {
    var choice = await _context.Choices.FindAsync(id);
    if (choice == null)
    {
      return NotFound();
    }

    _context.Choices.Remove(choice);
    await _context.SaveChangesAsync();

    return NoContent();
  }

  private bool ChoiceExists(int id)
  {
    return _context.Choices.Any(e => e.ChoiceId == id);
  }
}