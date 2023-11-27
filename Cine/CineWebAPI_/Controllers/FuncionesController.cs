using Cine_Back.Datos;
using Cine_Back.Fachada.Implementacion;
using Cine_Back.Fachada.Interfaz;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CineWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionesController : ControllerBase
    {
        IAplicacion app;
        public FuncionesController()
        {
            app = new Aplicacion();
        }
        // GET: api/<FuncionesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<FuncionesController>/5
        /*[HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FuncionesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<FuncionesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }*/

        // DELETE api/<FuncionesController>/5
        [HttpDelete("/DeleteFunc")]
        public IActionResult Delete(int codFuncion)
        {
            try
            {
                Parametro pa = new Parametro();
                pa.Valor = codFuncion;
                pa.Nombre = "@codFuncion";
                return Ok(app.BorrarFuncion(pa));
            } catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }
    }
}
