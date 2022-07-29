using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using la_mia_pizzeria_static;
using la_mia_pizzeria_static.Models;

namespace la_mia_pizzeria_static.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {

        // POST: api/Message
        [HttpPost]
        public IActionResult Post([FromForm] Message message)
        {
            //if (!ModelState.IsValid)
            //{
            //    return UnprocessableEntity(ModelState);
            //}

            //using (PizzeriaContext ctx = new PizzeriaContext())
            //{
            //    ctx.Messages.Add(message);
            //    ctx.SaveChanges();
            //    return Ok();
            //}

            return Ok();
        }
    }
}
