using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MiFutLiga.Models;

namespace MiFutLiga.Controllers.Categoria
{
    public class CategoriasController : Controller
    {
        private readonly MiFutLigaContext _context;

        public CategoriasController(MiFutLigaContext context)
        {
            _context = context;
        }

        // GET: Categorias
        public async Task<IActionResult> Index()
        {

            return View(await _context.Categorias.ToListAsync());
        }

        // GET: Categorias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categorias = await _context.Categorias
                .FirstOrDefaultAsync(m => m.idCategoria == id);
            if (categorias == null)
            {
                return NotFound();
            }

            return View(categorias);
        }

        // GET: Categorias/Create
        public IActionResult Create()
        {
            Categorias model = new Categorias();
            return PartialView("~/Views/Categorias/Create.cshtml", model);
            //return View();
        }

        // POST: Categorias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Categorias categorias)
        {
            try
            {
                categorias.Agregado = DateTime.Now;
                categorias.Modificado = null;
                categorias.Eliminado = false;
                //Como se esta creando el registro verificamos que su id sea 0 para calcular uno nuevo
                if (categorias.idCategoria == 0)
                {
                    //como marca un error de secuencia de datos primero verificamos que existan registros para obtener el id siguiente
                    if (_context.Categorias.Count() > 0)
                        //si existen registros obtenermos el maximo id y le sumamos uno
                        categorias.idCategoria = _context.Categorias.Max(Cate => Cate.idCategoria) + 1;
                    else
                        //en caso de que no existan registros el primer id sera 1
                        categorias.idCategoria = 1;
                }

                if (!ModelState.IsValid)
                    throw new Exception("Modelo Invalido, algunos valores no se cargaron con el valor correcto");

                _context.Add(categorias);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return RedirectToAction(nameof(Index));
            //return View(categorias);
        }

        // GET: Categorias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categorias = await _context.Categorias.FindAsync(id);
            if (categorias == null)
            {
                return NotFound();
            }
            return View(categorias);
        }

        // POST: Categorias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idCategoria,NombreCategoria,Abierta")] Categorias categorias)
        {
            if (id != categorias.idCategoria)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(categorias);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoriasExists(categorias.idCategoria))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(categorias);
        }

        // GET: Categorias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categorias = await _context.Categorias
                .FirstOrDefaultAsync(m => m.idCategoria == id);
            if (categorias == null)
            {
                return NotFound();
            }

            return View(categorias);
        }

        // POST: Categorias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var categorias = await _context.Categorias.FindAsync(id);
            _context.Categorias.Remove(categorias);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoriasExists(int id)
        {
            return _context.Categorias.Any(e => e.idCategoria == id);
        }
    }

}
