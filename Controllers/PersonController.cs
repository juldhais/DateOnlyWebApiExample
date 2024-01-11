using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DateOnlyWebApiExample.Controllers;

[ApiController]
[Route("persons")]
public class PersonController(DataContext dataContext) : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult<Person>> Create(Person person, CancellationToken ct)
    {
        dataContext.Add(person);
        await dataContext.SaveChangesAsync(ct);

        return StatusCode(StatusCodes.Status201Created, person);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Person>> Get(int id, CancellationToken ct)
    {
        var person = await dataContext.Person
            .FirstOrDefaultAsync(x => x.Id == id, ct);

        return Ok(person);
    }
}
