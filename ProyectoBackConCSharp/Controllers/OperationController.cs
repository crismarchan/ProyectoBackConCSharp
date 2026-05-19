using Microsoft.AspNetCore.Mvc;

namespace ProyectoBackConCSharp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationController : ControllerBase
    {
        [HttpGet]
        //public decimal Get(int a, int b, Numbers numbers)
        public decimal Get(int a, int b)
        {
            return a + b;
            //return numbers.A + numbers.B;
        }


        [HttpPost]
        public decimal Add(Numbers numbers, [FromHeader] string Host,
           [FromHeader(Name = "Content-Length")] string ContentLength,
           [FromHeader(Name = "X-Some")] string xSome)
        {
            Console.WriteLine($"Host es {Host}");
            Console.WriteLine($"Content-Length es {ContentLength}");
            Console.WriteLine($"X-Some es {xSome}");
            return numbers.A - numbers.B;
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
        public decimal B { get; set; }
    }
}