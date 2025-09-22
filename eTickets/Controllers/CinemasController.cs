using eTickets.Data;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _context;

        public CinemasController(AppDbContext context)
        {
            _context = context;
        }

        //Get: Cinemas
        public async Task<IActionResult> Index()
        {
            var allCinemas = await _context.Cinemas.ToListAsync();
            return View(allCinemas);
        }
        //#region Chatgpt
        //// GET: Cinemas/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Cinemas/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Name,Logo,Description")] Cinema cinema)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(cinema);
        //    }

        //    _context.Cinemas.Add(cinema);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //// GET: Cinemas/Edit/5
        //public async Task<IActionResult> Edit(int id)
        //{
        //    var cinema = await _context.Cinemas.FindAsync(id);
        //    if (cinema == null) return NotFound();
        //    return View(cinema);
        //}

        //// POST: Cinemas/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("CinemaId,Name,Logo,Description")] Cinema cinema)
        //{
        //    if (id != cinema.CinemaId)
        //    {
        //        return BadRequest();
        //    }

        //    if (!ModelState.IsValid)
        //    {
        //        return View(cinema);
        //    }

        //    try
        //    {
        //        _context.Update(cinema);
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!CinemaExists(cinema.CinemaId))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }
        //    return RedirectToAction(nameof(Index));
        //}

        //// GET: Cinemas/Delete/5
        //public async Task<IActionResult> Delete(int id)
        //{
        //    var cinema = await _context.Cinemas.FindAsync(id);
        //    if (cinema == null) return NotFound();
        //    return View(cinema);
        //}

        //// POST: Cinemas/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var cinema = await _context.Cinemas.FindAsync(id);
        //    if (cinema != null)
        //    {
        //        _context.Cinemas.Remove(cinema);
        //        await _context.SaveChangesAsync();
        //    }
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool CinemaExists(int id)
        //{
        //    return _context.Cinemas.Any(e => e.CinemaId == id);
        //}
        //#endregion
    }
}
