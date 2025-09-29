using eTickets.Data;
using eTickets.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IProducersService _service;

        public ProducersController(IProducersService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await _service.GetAllAsync();
            return View(allProducers);
        }
        /*
         * using eTickets.Data;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _context;

        public ProducersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Producers
        public async Task<IActionResult> Index()
        {
            var allProducers = await _context.Producers.ToListAsync();
            return View(allProducers);
        }

        // GET: Producers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Producers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")] Producer producer)
        {
            if (!ModelState.IsValid)
                return View(producer);

            _context.Add(producer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Producers/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var producer = await _context.Producers.FirstOrDefaultAsync(p => p.ProducerId == id);
            if (producer == null)
                return NotFound();

            return View(producer);
        }

        // GET: Producers/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var producer = await _context.Producers.FindAsync(id);
            if (producer == null)
                return NotFound();

            return View(producer);
        }

        // POST: Producers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProducerId,FullName,ProfilePictureURL,Bio")] Producer producer)
        {
            if (id != producer.ProducerId)
                return NotFound();

            if (!ModelState.IsValid)
                return View(producer);

            try
            {
                _context.Update(producer);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Producers.Any(p => p.ProducerId == id))
                    return NotFound();
                throw;
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: Producers/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var producer = await _context.Producers.FirstOrDefaultAsync(p => p.ProducerId == id);
            if (producer == null)
                return NotFound();

            return View(producer);
        }

        // POST: Producers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producer = await _context.Producers.FindAsync(id);
            if (producer != null)
            {
                _context.Producers.Remove(producer);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}

         */
    }
}
