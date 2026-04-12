using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Net.NetworkInformation;

namespace ProyectoBackConCSharp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class PeopleController : ControllerBase
    {

        [HttpGet("all")]
        public List<People> GetPeople () => Repository.People;

        [HttpGet("{id}")]
        public People Get(int id) => Repository.People.First(p => p.ID == id);

        [HttpGet("search/{search}")]
        public List<People> Get(string search) =>
            Repository.People.Where(p => p.Name.ToUpper().Contains(search.ToUpper())).ToList();
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

        public DateTime Birthdate {  get; set; }

    }

}
