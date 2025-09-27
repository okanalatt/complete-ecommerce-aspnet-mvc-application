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

        // GET: Actors
        // Tüm aktörleri listeleyen sayfa
        public async Task<IActionResult> Index()
        {
            var actors = await _service.GetAllAsync();
            return View(actors);
        }

        // GET: Actors/Create
        // Yeni aktör ekleme sayfasını açar
        public IActionResult Create()
        {
            return View();
        }

        // POST: Actors/Create
        // Yeni aktör ekleme formundan gelen verileri veritabanına kaydeder
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FullName,Bio,ProfilePictureURL")] Actor actorDto)
        {
            if (!ModelState.IsValid)
            {
                return View(actorDto);
            }

            var actor = new Actor
            {
                FullName = actorDto.FullName,
                Bio = actorDto.Bio,
                ProfilePictureURL = actorDto.ProfilePictureURL,
                Actor_Movies = new List<Actor_Movie>()
            };

            await _service.AddAsync(actor);

            // Başarılı mesaj göstermek için ViewData kullanıyoruz
            ViewData["SuccessMessage"] = "Actor eklendi!";
            ModelState.Clear();
            return View(new Actor());
        }

        // GET: Actors/Edit/5
        // Düzenlenecek aktör bilgilerini getirir
        public async Task<IActionResult> Edit(int id)
        {
            var actordetails = await _service.GetByIdAsync(id);
            if (actordetails == null) return View("NotFound");
            return View(actordetails);
        }

        // POST: Actors/Edit/5
        // Aktör bilgilerini günceller
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ActorId,FullName,Bio,ProfilePictureURL")] Actor actor)
        {
            if (!ModelState.IsValid) return View(actor);

            if (id != actor.ActorId) return BadRequest();

            await _service.UpdateAsync(id, actor);
            return RedirectToAction(nameof(Index));
        }

        // GET: Actors/Details/5
        // Bir aktörün detay sayfasını açar
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);
        }

        // GET: Actors/Delete/5
        // Silinecek aktörün bilgilerini gösterir (onay sayfası)
        public async Task<IActionResult> Delete(int id)
        {
            var actor = await _service.GetByIdAsync(id);
            if (actor == null) return View("NotFound");
            return View(actor);
        }

        // POST: Actors/Delete/5
        // Aktörü veritabanından siler
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actor = await _service.GetByIdAsync(id);
            if (actor == null) return View("NotFound");
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
