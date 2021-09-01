using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NollzRecipes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetDishes()
        {
            string[] dishes = { "Sushi", "Burgers", "Noodles" };
          

            if (dishes.Any())
                return NotFound();
            return Ok(dishes);
        }

        [HttpPost]
        public ActionResult CreateNewRecipes()
        {
            return BadRequest();
        }

        [HttpDelete]
        public ActionResult DeleteNewRecipes()
        {
            bool badThingsHappened = false;

            if (badThingsHappened)
                return BadRequest();

            return NoContent();
        }

        [HttpPut]
        public ActionResult UpdateNewRecipes()
        {
            return NoContent();
        }

    }
}
