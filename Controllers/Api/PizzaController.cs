using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers.Api
{
    [Route("api/Pizza")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        [Route("get")]
        [HttpGet]
        public IActionResult GetPizze()
        {
            PizzeriaContext ctx = new PizzeriaContext();
            
            IQueryable<Pizza> pizzaList = ctx.Pizze;
            return Ok(pizzaList.ToList());
            
        }
    }
}
