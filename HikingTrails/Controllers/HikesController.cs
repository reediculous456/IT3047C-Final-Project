using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HikingTrails.Models;

namespace HikingTrails.Controllers
{
    public class HikesController : Controller
    {
        private readonly HikingTrailsContext _context;

        public HikesController(HikingTrailsContext context)
        {
            _context = context;
        }

        // GET: Hikes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Hike.ToListAsync());
        }

        // GET: Hikes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hike = await _context.Hike
                .FirstOrDefaultAsync(m => m.HikeId == id);
            if (hike == null)
            {
                return NotFound();
            }

            return View(hike);
        }

        // GET: Hikes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Hikes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HikeId,TrailId,Trailname,UserId,Username,Date")] Hike hike)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hike);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hike);
        }

        // GET: Hikes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hike = await _context.Hike.FindAsync(id);
            if (hike == null)
            {
                return NotFound();
            }
            return View(hike);
        }

        // POST: Hikes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HikeId,TrailId,Trailname,UserId,Username,Date")] Hike hike)
        {
            if (id != hike.HikeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hike);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HikeExists(hike.HikeId))
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
            return View(hike);
        }

        // GET: Hikes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hike = await _context.Hike
                .FirstOrDefaultAsync(m => m.HikeId == id);
            if (hike == null)
            {
                return NotFound();
            }

            return View(hike);
        }

        // POST: Hikes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hike = await _context.Hike.FindAsync(id);
            _context.Hike.Remove(hike);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HikeExists(int id)
        {
            return _context.Hike.Any(e => e.HikeId == id);
        }
    }
}
