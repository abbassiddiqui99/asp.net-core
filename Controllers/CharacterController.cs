using System.Collections.Generic;
using DOTNET_RPG.Models;
using Microsoft.AspNetCore.Mvc;

namespace DOTNET_RPG.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        // private static Character knight = new Character();
        private static List<Character> characters = new List<Character> {
            new Character(),
            new Character {Name = "Sam"},
        };

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(characters);
        }
         public IActionResult GetSingle()
        {
            return Ok(characters[0]);
        }
    }
}