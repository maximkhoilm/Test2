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
        public static string[] a;
        public IActionResult Index()
        {
            return Ok(a);
        }
    }
}