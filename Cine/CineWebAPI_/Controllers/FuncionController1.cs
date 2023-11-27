using Cine_Back.Fachada.Implementacion;
using Cine_Back.Fachada.Interfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Cine_Back.Entidades.Funciones;
using Cine_Back.Entidades.Clientes;
using Cine_Back.Datos;
using System;

namespace CineWebAPI.Controllers
{
    public class FuncionController1 : Controller
    {
        private IAplicacion app;
        // GET: FuncionController
        public ActionResult Index()
        {
            return View();
        }
        public FuncionController1()
        {
            app = new Aplicacion();
        }

        // GET: FuncionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FuncionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FuncionController/Create
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

        [HttpGet("/NextFuncionId")]
        public IActionResult GetNextFuncionId()
        {
            try
            {
                int id = app.GetNextFuncionId();
                return Ok(id);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error y tal");
            }
        }

        [HttpGet("/Funciones")]
        public IActionResult GetFunciones()
        {
            List<Funcion> lst = null;
            try
            {
                lst = app.GetFunciones();
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error y tal");
            }
        }

        [HttpGet("/Peliculas")]
        public IActionResult GetPeliculas()
        {
            List<Pelicula> lst = null;
            try
            {
                lst = app.GetPeliculas();
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error y tal");
            }
        }

        [HttpGet("/Salas")]
        public IActionResult GetSalas()
        {
            List<Sala> lst = null;
            try
            {
                lst = app.GetSalas();
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error y tal");
            }
        }

        [HttpGet("/Formatos")]
        public IActionResult GetFormatos()
        {
            List<Formato> lst = null;
            try
            {
                lst = app.GetFormatos();
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error y tal");
            }
        }

        // GET: FuncionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FuncionController/Edit/5
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

        // GET: FuncionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FuncionController/Delete/5

        /*[HttpDelete("/DeleteFuncion")] 
        public IActionResult DeleteFunc(int codFuncion)
        {
            Parametro pa = new Parametro();
            pa.Valor = codFuncion;
            pa.Nombre = "@codFuncion";
            return Ok(app.BorrarFuncion(pa));

        }*/

        [HttpPost("/PostFuncion")]
        public IActionResult PostFuncion([FromBody] Funcion fun)
        {
            try
            {
                return Ok(app.SaveFuncion(fun));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }



        // PUT api/<ClientesController>/5
        [HttpPut("/PutFunc")]
        public IActionResult Put([FromBody] Funcion fun)
        {
            try
            {
                return Ok(app.UpdateFuncion(fun));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
