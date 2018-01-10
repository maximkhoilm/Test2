using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
  
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        
        public IActionResult Index()
        {
            List<Test> _ls = new List<Test>();
            _ls.Add(new Test { ID = 1, Name = "A" });
            return Ok(_ls);
        }
    }

    public class Test
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}