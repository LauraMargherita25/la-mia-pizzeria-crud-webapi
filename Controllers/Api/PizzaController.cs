using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace la_mia_pizzeria_static.Controllers.Api
{
    [Route("api/Pizza")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        //[Route("get")]
        [HttpGet]
        public IActionResult GetPizze(string? searchPizza)
        {
            PizzeriaContext ctx = new PizzeriaContext();

            IQueryable<Pizza> pizzaList = ctx.Pizze;

            if (searchPizza != null && searchPizza != "")
            {
                pizzaList = pizzaList.Where(pizza => pizza.Name.StartsWith(searchPizza));
            }
            return Ok(pizzaList.ToList());

        }

        [HttpGet("{id}")]
        public IActionResult GetPizze(int id)
        {
            PizzeriaContext ctx = new PizzeriaContext();

            Pizza pizza = ctx.Pizze.Where(pizza => pizza.Id == id).FirstOrDefault();

            if (pizza == null)
            {
                return NotFound();
            }
            return Ok(pizza);

        }
    }
}
