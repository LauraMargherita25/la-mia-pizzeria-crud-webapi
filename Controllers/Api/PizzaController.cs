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

            if(searchPizza != null && searchPizza != "")
            {
                pizzaList = pizzaList.Where(pizza => pizza.Name.StartsWith(searchPizza));
            }
            return Ok(pizzaList.ToList());
            
        }
    }
}
