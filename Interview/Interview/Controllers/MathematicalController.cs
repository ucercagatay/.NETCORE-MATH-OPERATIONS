using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Interview.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MathematicalController : Controller
    {

        // GET: /<controller>/
        [Route("summary")]
        [HttpPost]
        public ActionResult Summary(MathDTO math)
        {
            var summary = math.numberOne + math.numberTwo;
            return Json(summary);
        }
        [Route("subtract")]
        [HttpPost]
        public IActionResult Subtract(MathDTO math)
        {
            var subtract = math.numberOne - math.numberTwo;

            return Json(subtract);
        }

        [Route("multiply")]
        [HttpPost]
        public IActionResult Multiply(MathDTO math)
        {
         
            var multiply = math.numberOne * math.numberTwo;

            return Json(multiply);
        }

        [Route("divide")]
        [HttpPost]
        public IActionResult Divide(MathDTO math)
        {
           
            double divide = math.numberOne / math.numberTwo;

            return Json(divide);
        }
    }
}

