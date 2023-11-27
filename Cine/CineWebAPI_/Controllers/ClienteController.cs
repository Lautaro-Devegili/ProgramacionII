using Cine_Back.Entidades.Clientes;
using Cine_Back.Entidades.Funciones;
using Cine_Back.Fachada.Implementacion;
using Cine_Back.Fachada.Interfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CineWebAPI.Controllers
{
    public class ClienteController : Controller
    {
        // GET: ClienteController
        IAplicacion app;

        public ClienteController()
        {
            app = new Aplicacion();
        }
        public ActionResult Index()
        {
            return View();
        }

        // GET: ClienteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClienteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost("/SaveCliente")]
        public IActionResult PostFuncion(Cliente c)
        {
            return Ok(app.SaveCliente(c));

        }

        // PUT api/<ClientesController>/5
        [HttpPut("/PutCli")]
        public IActionResult Put([FromBody] Cliente cli)
        {
            try
            {
                return Ok(app.UpdateCliente(cli));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // POST: ClienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClienteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
