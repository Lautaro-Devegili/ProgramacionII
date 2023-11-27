using Cine_Back.Entidades.Clientes;
using Cine_Back.Entidades.Compras;
using Cine_Back.Fachada.Implementacion;
using Cine_Back.Fachada.Interfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CineWebAPI.Controllers
{
    public class CompraController : Controller
    {
        IAplicacion app;

        public CompraController()
        {
            app = new Aplicacion();
        }
        // GET: CompraController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CompraController/Details/5
        public ActionResult Details(int id)
        {
            return View();
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

        // GET: CompraController/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost("/SaveCompra")]
        public IActionResult PostFuncion(Compra c)
        {
            return Ok(app.SaveCompra(c));

        }

        // POST: CompraController/Create
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

        // GET: CompraController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CompraController/Edit/5
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

        // GET: CompraController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CompraController/Delete/5
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
