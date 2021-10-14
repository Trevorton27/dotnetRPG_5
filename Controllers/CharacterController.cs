using System.Collections.Generic;
using dotnetRPG_5.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnetRPG_5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character> {
            new Character(),
            new Character {Name = "sam"}
        };
        [HttpGet]
        [Route("GetAll")]
        public ActionResult<List<Character>> Get()
        {
            return Ok(characters);
        }

        [HttpGet]
        public ActionResult<Character> GetSingleCharacter()
        {
            return Ok(characters[0]);
        }
    }
}