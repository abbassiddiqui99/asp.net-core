using System.Collections.Generic;
using System.Linq;
using DOTNET_RPG.Models;
using DOTNET_RPG.Services.CharacterServices;
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
            new Character { Id = 1, Name = "Sam"},
        };
        private readonly ICharacterServices _characterService;

        public CharacterController(ICharacterServices characterService)
        {
            _characterService = characterService;

        }

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(characters);
        }
        [HttpGet("{id}")]
        public IActionResult GetSingle(int id)
        {
            return Ok(characters.FirstOrDefault(c => c.Id == id));
        }
        [HttpPost]
        public IActionResult AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return Ok(characters);
        }
    }
}