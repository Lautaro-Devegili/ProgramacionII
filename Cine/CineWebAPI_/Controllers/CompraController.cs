using Cine_Back.Entidades.Compras;
using Cine_Back.Fachada.Implementacion;
using Cine_Back.Fachada.Interfaz;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CineWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompraController : ControllerBase
    {
        IAplicacion app;
        public CompraController()
        {
            app = new Aplicacion();
        }
        // GET: api/<CompraController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        // GET: api/<CompraController>
        [HttpGet("/Descuentos")]
        public IActionResult GetDescuentos()
        {
            List<Descuento> lst = null;
            try
            {
                lst = app.GetDescuentos();
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error y tal");
            }
        }

        [HttpGet("/FormasPago")]
        public IActionResult GetFormasPago()
        {
            List<FormaPago> lst = null;
            try
            {
                lst = app.GetFormasPago();
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error y tal");
            }
        }

        [HttpGet("/Compras")]
        public IActionResult GetCompras()
        {
            List<Compra> lst = null;
            try
            {
                lst = app.GetCompras();
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error y tal");
            }
        }

        // GET api/<CompraController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CompraController>
        [HttpPost("/PostCompra")]
        public IActionResult Post([FromBody] Compra c)
        {
            try
            {
                var result = app.SaveCompra(c);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // PUT api/<CompraController>
        [HttpPut("/PutCompra")]
        public IActionResult Put([FromBody] Compra comp)
        {
            try
            {
                var result = app.UpdateEstadoCompra(comp.NroCompra);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // PUT api/<CompraController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CompraController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
