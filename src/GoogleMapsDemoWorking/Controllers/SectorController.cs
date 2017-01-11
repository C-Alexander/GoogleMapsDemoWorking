using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GoogleMapsDemoWorking.Data;
using GoogleMapsDemoWorking.Models.GoogleMapsDemoModels;

namespace GoogleMapsDemoWorking.Controllers
{
    public class SectorController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SectorController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Sector
        public async Task<IActionResult> Index()
        {
            return View(await _context.SectorViewModel.ToListAsync());
        }

        // GET: Sector/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sectorViewModel = await _context.SectorViewModel.SingleOrDefaultAsync(m => m.ID == id);
            if (sectorViewModel == null)
            {
                return NotFound();
            }

            return View(sectorViewModel);
        }

        // GET: Sector/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sector/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Blocked")] SectorViewModel sectorViewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sectorViewModel);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(sectorViewModel);
        }

        // GET: Sector/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sectorViewModel = await _context.SectorViewModel.SingleOrDefaultAsync(m => m.ID == id);
            if (sectorViewModel == null)
            {
                return NotFound();
            }
            return View(sectorViewModel);
        }

        // POST: Sector/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Blocked")] SectorViewModel sectorViewModel)
        {
            if (id != sectorViewModel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sectorViewModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SectorViewModelExists(sectorViewModel.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(sectorViewModel);
        }

        // GET: Sector/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sectorViewModel = await _context.SectorViewModel.SingleOrDefaultAsync(m => m.ID == id);
            if (sectorViewModel == null)
            {
                return NotFound();
            }

            return View(sectorViewModel);
        }

        // POST: Sector/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sectorViewModel = await _context.SectorViewModel.SingleOrDefaultAsync(m => m.ID == id);
            _context.SectorViewModel.Remove(sectorViewModel);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool SectorViewModelExists(int id)
        {
            return _context.SectorViewModel.Any(e => e.ID == id);
        }
    }
}
