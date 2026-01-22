using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoBackConCSharp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationController : ControllerBase
    {
        [HttpGet]
        public decimal Get(int a, int b, Numbers numbers)
        {
            return a + b;
           // return numbers.A + numbers.B;
        }


        [HttpPost]
        public decimal Add(int a, int b)
        {
            return a - b;
        }

        [HttpPut]
        public decimal Edit(int a, int b)
        {
            return a * b;
        }


        [HttpDelete]
        public decimal Delete(int a, int b)
        {
            return a / b;
        }
    }

    public class Numbers
    {
        public decimal A { get; set; }
        public decimal  B { get; set; }
    }
}