using Microsoft.AspNetCore.Mvc;
using RESTTemplate.Model;
using RESTTemplate.Services;

namespace RESTTemplate.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {

        private readonly ILogger<PersonController> _logger; // Auxilia a apresentar mensagens de log no console
        private IPersonService _personService; // Chamada do Service no nosso Controller


        public PersonController(ILogger<PersonController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        /*
         * -------------------------
         * HTTP GET (READ) ALL DATA
         * -------------------------
        */

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personService.FindAll()); // M�todo criado no PersonServiceImplementation
        }

        /*
         * ---------------------
         * HTTP GET (READ) BY ID
         * ---------------------
        */

        [HttpGet("{id}")] // {} significa que ele vai receber esse valor pela requisi��o
        public IActionResult Get(long id)
        {
            var person = _personService.FindbyID(id); // M�todo criado no PersonServiceImplementation
            if (person == null) return NotFound(); // Caso n�o tenha o registro, retorna 404 NOT FOUND no Postman

            return Ok(person);
        }

        /*
         * -------------------
         * HTTP POST (CREATE)
         * -------------------
        */

        [HttpPost]
        public IActionResult Post([FromBody] Person person) // [FromBody] significa que ele vai pegar o Body da requisi��o e transforma no objeto Person
        {
            if (person == null) return BadRequest(); // Caso n�o tenha sido passado um Body, ele deve dar um 400 BAD REQUEST no Postman
            return Ok(_personService.Create(person)); // M�todo criado no PersonServiceImplementation
        }

        /*
         * ------------------
         * HTTP PUT (UPDATE)
         * ------------------
        */

        [HttpPut]
        public IActionResult Put([FromBody] Person person) // [FromBody] significa que ele vai pegar o Body da requisi��o e transforma no objeto Person
        {
            if (person == null) return BadRequest(); // Caso n�o tenha sido passado um Body, ele deve dar um 400 BAD REQUEST no Postman
            return Ok(_personService.Update(person)); // M�todo criado no PersonServiceImplementation
        }

        /*
         * ---------------------
         * HTTP DELETE (DELETE)
         * ---------------------
        */

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
           _personService.Delete(id); // M�todo criado no PersonServiceImplementation
            return NoContent(); // Quando remover ele n�o vai retornar nada ao response do Postman
        }
    }
}
