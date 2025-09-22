using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }

        //Get: Actors
        public async Task<IActionResult> Index()
        {
            var actors = await _service.GetAll();
            return View(actors);
        }

        //Get: Actors/Create
        public IActionResult Create()
        {
            return View();
        }

        //#region Chatgpt
        //// POST: Actors/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("FullName,Bio,ProfilePictureURL")] Actor actor)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(actor);
        //    }

        //    await _service.AddAsync(actor);
        //    return RedirectToAction(nameof(Index));
        //}

        //// GET: Actors/Edit/5
        //public async Task<IActionResult> Edit(int id)
        //{
        //    var actor = await _service.GetByIdAsync(id);
        //    if (actor == null) return NotFound();
        //    return View(actor);
        //}

        //// POST: Actors/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("ActorId,FullName,Bio,ProfilePictureURL")] Actor actor)
        //{
        //    if (id != actor.ActorId)
        //    {
        //        return BadRequest();
        //    }

        //    if (!ModelState.IsValid)
        //    {
        //        return View(actor);
        //    }

        //    await _service.UpdateAsync(actor);
        //    return RedirectToAction(nameof(Index));
        //}

        //// GET: Actors/Delete/5
        //public async Task<IActionResult> Delete(int id)
        //{
        //    var actor = await _service.GetByIdAsync(id);
        //    if (actor == null) return NotFound();
        //    return View(actor);
        //}

        //// POST: Actors/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    await _service.DeleteAsync(id);
        //    return RedirectToAction(nameof(Index));
        //}

        //// GET: Actors/Details/5
        //public async Task<IActionResult> Details(int id)
        //{
        //    var actor = await _service.GetByIdAsync(id);
        //    if (actor == null) return NotFound();
        //    return View(actor);
        //}
        //#endregion
    }
}
