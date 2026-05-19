using Microsoft.AspNetCore.Mvc;
using ProyectoBackConCSharp.Services;

namespace ProyectoBackConCSharp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class PeopleController : ControllerBase
    {
        private IPeopleService _peopleService;

        public PeopleController([FromKeyedServices("peopleService")] IPeopleService peopleService)
        {
            _peopleService = peopleService;
        }

        [HttpGet("all")]
        public List<People> GetPeople() => Repository.People;

        [HttpGet("{id}")]
        public ActionResult<People> Get(int id)
        {
            var people = Repository.People.FirstOrDefault(p => p.ID == id);

            if (people == null)
            {
                return NotFound();
            }

            return Ok(people);
        }


        [HttpGet("search/{search}")]
        public List<People> Get(string search) =>
            Repository.People.Where(p => p.Name.ToUpper().Contains(search.ToUpper())).ToList();


        [HttpPost]
        public IActionResult Add(People people)
        {

            if (!_peopleService.Validate(people))
            {

                return BadRequest();
            }
            Repository.People.Add(people);

            return NoContent();
        }


    }


    public class Repository
    {
        public static List<People> People = new List<People>
        {
            new People ()
            {
                ID = 1, Name = "Sofi", Birthdate = new DateTime (2002,02,01)
            },
            new People ()
            {
               ID = 2, Name = "lAURA", Birthdate=new DateTime (2003,04,02)
            },
            new People ()
            {
                ID = 3, Name = "PAO", Birthdate=new DateTime (2002,07,02)
            }
        };
    }


    public class People
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public DateTime Birthdate { get; set; }

    }

}
