//using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using test2.Interfaces;
using test2.Models;
using test2.Services;

namespace test2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : Controller
    {
        private readonly ITestServices _service;

        public TestController(ITestServices service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult GetAll() 
        {

            return Ok();
        }

        [HttpGet("/initial")]
        public ActionResult Initial() 
        {
            Random rnd = new Random();
            rnd.Next();
            var name1 = "asd";

            var x = new TestModel { Name = "qwe" };
            _service.TestInitial(x);

            return Ok(x);
        }
    }


}
