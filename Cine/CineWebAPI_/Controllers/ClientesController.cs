using Cine_Back.Entidades.Clientes;
using Cine_Back.Fachada.Implementacion;
using Cine_Back.Fachada.Interfaz;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CineWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        IAplicacion app;

        public ClientesController()
        {
            app = new Aplicacion();
        }
        // GET: api/<ClientesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        // GET: api/<ClientesController>
        [HttpGet("/Sex")]
        public IActionResult GetSexos()
        {
            List<Sexo> lst = null;
            try
            {
                lst = app.GetSexos();
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error y tal");
            }
        }

        [HttpGet("/Clientes")]
        public IActionResult GetClientes()
        {
            List<Cliente> lst = null;
            try
            {
                lst = app.GetClientes();
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error y tal");
            }
        }

        // GET: api/<ClientesController>
        [HttpGet("/Docs")]
        public IActionResult GetTiposDoc()
        {
            List<TipoDoc> lst = null;
            try
            {
                lst = app.GetTiposDoc();
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error y tal");
            }
        }
        // GET api/<ClientesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ClientesController>
        [HttpPost("/PostCli")]
        public IActionResult PostCliente(Cliente cli)
        {
            try
            {
                var result = app.SaveCliente(cli);
                return Ok(result);
            } catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // DELETE api/<ClientesController>/5
        [HttpDelete("/DeteleCli")]
        public IActionResult Delete(int id)
        {
            try
            {
                var result = app.EliminarCliente(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
