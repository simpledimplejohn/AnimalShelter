using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;
using System.Linq;

namespace AnimalShelter.Controllers
{
  public class PaginationModel
  {
    public List<Animal> Data { get; set; }
    public int Total { get; set; }
    public int PerPage { get; set; }
    public int Page { get; set; }
    public string PreviousPage { get; set; }
    public string NextPage { get; set; }
  }

  [Route("api/[controller]")] //setting the url you have to go to [placeholder for controller name] animals in this case
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private readonly AnimalShelterContext _db;

    public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }
    
    // GET: api/Animals/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Animal>> GetAnimal(int id) //like details view, get all the info
    {
        var animal = await _db.Animals.FindAsync(id);

        if (animal == null)
        {
            return NotFound();
        }

        return animal;
    }
    // where you search
    // GET api/animals
// PAGINATION UPDATE
    [HttpGet] //similar to our index, async means wrap in Task, retruning an action result IEnumerable = list that we then loop through
    public async Task<ActionResult<PaginationModel>> Get(string species, string gender, string name, int page, int perPage)
    {
      var query = _db.Animals.AsQueryable(); //collect list of all animals from database returned as a LINQ object that is queryable

      if (species != null)
      {
        query = query.Where(entry => entry.Species == species); //where accepts a function that checks for a match
      }

      if (gender != null)
      {
        query = query.Where(query => query.Gender == gender);
      }

      if (name != null)
      {
        query = query.Where(query => query.Name == name);
      }
      List<Animal> animals = await query.ToListAsync();

      if (perPage == 0) perPage = 2;

      int total = animals.Count;
      List<Animal> animalsPage = new List<Animal>();

      if (page < (total / perPage))
      {
        animalsPage = animals.GetRange(page * perPage, perPage);
      }

      if (page == (total / perPage))
      {
        animalsPage = animals.GetRange(page * perPage, total - (page * perPage));
      }

      return new PaginationModel()
      {
        Data = animalsPage,
        Total = total,
        PerPage = perPage,
        Page = page,
        PreviousPage = page == 0 ? $"/api/animals?page={page}" : $"/api/animals?page={page - 1}",
        NextPage = $"/api/animals?page={page + 1}",
      };
    }

    // POST api/animals
    [HttpPost] //creating a new animal, like our create method
    public async Task<ActionResult<Animal>> Post(Animal animal) 
    {
      _db.Animals.Add(animal);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetAnimal), new { id = animal.AnimalId }, animal);
    }
    
    // Forms have GET and POST only, PUT = Edit existing content 
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Animal animal)
    {
      if (id != animal.AnimalId)
      {
        return BadRequest();
      }

      _db.Entry(animal).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!AnimalExists(id))
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
    // DELETE: api/Animals/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAnimal(int id)
    {
      var animal = await _db.Animals.FindAsync(id);
      if (animal == null)
      {
        return NotFound();
      }

      _db.Animals.Remove(animal);
      await _db.SaveChangesAsync();

      return NoContent();
    }
    private bool AnimalExists(int id)
    {
      return _db.Animals.Any(e => e.AnimalId == id);
    }
  }
}