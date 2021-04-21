using HikingTrails.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HikingTrails.Controllers
{
    public class UsersController : Controller
    {
        private readonly HikingTrailsContext _context;

        public UsersController(HikingTrailsContext context)
        {
            _context = context;
        }

        // GET: Hikers
        public async Task<IActionResult> Index()
        {
            return View(await _context.User.ToListAsync());
        }

        // GET: Hikers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hiker = await _context.User
                .Include(m => m.Hikes)
                .ThenInclude(m => m.Trail)
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (hiker == null)
            {
                return NotFound();
            }

            return View(hiker);
        }

        // GET: Hikers/Create
        public IActionResult Create()
        {
            ViewBag.Trails = _context.Trail.ToList();
            return View();
        }

        // POST: Hikers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HikerId,LastName,FirstName,Age,Bio,SelectedHikes")] User hiker)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hiker);
                await _context.SaveChangesAsync();

                foreach (int TrailId in hiker.SelectedHikes)
                {
                    _context.Hike.Add(new Hike()
                    {
                        TrailId = TrailId,
                        UserId = hiker.UserId
                    });
                }
                await _context.SaveChangesAsync();
                TempData["UserMessage"] = $"User successfully created!";
                return RedirectToAction(nameof(Index));
            }
            return View(hiker);
        }

        // GET: Hikers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hiker = await _context.User.FindAsync(id);
            if (hiker == null)
            {
                return NotFound();
            }

            hiker.SelectedHikes = _context.Hike.Where(h => h.UserId == hiker.UserId).Select(h => h.TrailId).ToList();
            ViewBag.Trails = _context.Trail.ToList();

            return View(hiker);
        }

        // POST: Hikers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,LastName,FirstName,Age,Bio,SelectedHikes")] User hiker)
        {
            if (id != hiker.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    List<Hike> existingHikes = _context.Hike.Where(h => h.UserId == hiker.UserId).ToList();

                    foreach (int TrailId in hiker.SelectedHikes)
                    {
                        if (existingHikes.Where(h => h.TrailId == TrailId).Count() == 0)
                        {
                            _context.Hike.Add(new Hike()
                            {
                                TrailId = TrailId,
                                UserId = hiker.UserId
                            });
                        }
                    }



                    foreach (Hike hike in existingHikes)
                    {
                        if (hiker.SelectedHikes.Where(TrailId => TrailId == hike.TrailId).Count() == 0)
                        {
                            _context.Hike.Remove(hike);
                        }
                    }

                    _context.Update(hiker);
                    await _context.SaveChangesAsync();
                    TempData["UserMessage"] = $"User successfully edited!";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HikerExists(hiker.UserId))
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
            return View(hiker);
        }

        // GET: Hikers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hiker = await _context.User
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (hiker == null)
            {
                return NotFound();
            }
            TempData["UserMessage"] = $"User successfully deleted!";
            return View(hiker);
        }

        // POST: Hikers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hiker = await _context.User.FindAsync(id);
            _context.User.Remove(hiker);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HikerExists(int id)
        {
            return _context.User.Any(e => e.UserId == id);
        }
    }
}
