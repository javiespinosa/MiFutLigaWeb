using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MiFutLiga.Models;

namespace MiFutLiga.Controllers.Equipo
{
    public class EquiposController : Controller
    {
        //private readonly MiFutLigaContext_11 _context;

        //public EquiposController(MiFutLigaContext_11 context)
        //{
        //    _context = context;
        //}

        // GET: Equipos
        //public async Task<IActionResult> Index()
        //{
        //    var miFutLigaContext = _context.Equipos.Include(e => e.idCategoriaNavigation).Include(e => e.idDivisionNavigation);
        //    return View(await miFutLigaContext.ToListAsync());
        //}

        // GET: Equipos/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var equipos = await _context.Equipos
        //        .Include(e => e.idCategoriaNavigation)
        //        .Include(e => e.idDivisionNavigation)
        //        .FirstOrDefaultAsync(m => m.idEquipo == id);
        //    if (equipos == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(equipos);
        //}

        // GET: Equipos/Create
        //public IActionResult Create()
        //{
        //    ViewData["idCategoria"] = new SelectList(_context.Categorias, "idCategoria", "idCategoria");
        //    ViewData["idDivision"] = new SelectList(_context.Divisiones, "idDivision", "idDivision");
        //    return View();
        //}

        // POST: Equipos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("idEquipo,idCategoria,idDivision,NombreEquipo,Delegado,DirTecnico,ColorCamiseta,ColorShort,Telefono,Direccion,Email,Escudo,ContentType,Auxiliar,Medico,ruta,Apoyos,fotoequipo")] Equipos equipos)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(equipos);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["idCategoria"] = new SelectList(_context.Categorias, "idCategoria", "idCategoria", equipos.idCategoria);
        //    ViewData["idDivision"] = new SelectList(_context.Divisiones, "idDivision", "idDivision", equipos.idDivision);
        //    return View(equipos);
        //}

        // GET: Equipos/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var equipos = await _context.Equipos.FindAsync(id);
        //    if (equipos == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["idCategoria"] = new SelectList(_context.Categorias, "idCategoria", "idCategoria", equipos.idCategoria);
        //    ViewData["idDivision"] = new SelectList(_context.Divisiones, "idDivision", "idDivision", equipos.idDivision);
        //    return View(equipos);
        //}

        // POST: Equipos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("idEquipo,idCategoria,idDivision,NombreEquipo,Delegado,DirTecnico,ColorCamiseta,ColorShort,Telefono,Direccion,Email,Escudo,ContentType,Auxiliar,Medico,ruta,Apoyos,fotoequipo")] Equipos equipos)
        //{
        //    if (id != equipos.idEquipo)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(equipos);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!EquiposExists(equipos.idEquipo))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["idCategoria"] = new SelectList(_context.Categorias, "idCategoria", "idCategoria", equipos.idCategoria);
        //    ViewData["idDivision"] = new SelectList(_context.Divisiones, "idDivision", "idDivision", equipos.idDivision);
        //    return View(equipos);
        //}

        // GET: Equipos/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var equipos = await _context.Equipos
        //        .Include(e => e.idCategoriaNavigation)
        //        .Include(e => e.idDivisionNavigation)
        //        .FirstOrDefaultAsync(m => m.idEquipo == id);
        //    if (equipos == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(equipos);
        //}

        // POST: Equipos/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var equipos = await _context.Equipos.FindAsync(id);
        //    _context.Equipos.Remove(equipos);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool EquiposExists(int id)
        //{
        //    return _context.Equipos.Any(e => e.idEquipo == id);
        //}
    }
}
