using DB;
using DB.DataAccess.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TESIS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicoController : ControllerBase
    {
        private readonly IRepositoryAsync<Medico> _repository;
        public MedicoController(IRepositoryAsync<Medico> repository)
        {
            _repository = repository;
        }
        // GET: api/<MedicoController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _repository.GetAll();
            return Ok(data);
        }

        // GET api/<MedicoController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _repository.GetByID(id);
            return Ok(data);
        }

        // POST api/<MedicoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MedicoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MedicoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
