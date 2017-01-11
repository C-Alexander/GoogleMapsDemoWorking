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
    public class CoordinateController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CoordinateController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Coordinate
        public async Task<IActionResult> Index()
        {
            return View(await _context.CoordinateModel.ToListAsync());
        }

        // GET: Coordinate/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coordinateModel = await _context.CoordinateModel.SingleOrDefaultAsync(m => m.ID == id);
            if (coordinateModel == null)
            {
                return NotFound();
            }

            return View(coordinateModel);
        }

        // GET: Coordinate/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Coordinate/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Latitude,Longitude")] CoordinateModel coordinateModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(coordinateModel);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(coordinateModel);
        }

        // GET: Coordinate/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coordinateModel = await _context.CoordinateModel.SingleOrDefaultAsync(m => m.ID == id);
            if (coordinateModel == null)
            {
                return NotFound();
            }
            return View(coordinateModel);
        }

        // POST: Coordinate/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Latitude,Longitude")] CoordinateModel coordinateModel)
        {
            if (id != coordinateModel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(coordinateModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CoordinateModelExists(coordinateModel.ID))
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
            return View(coordinateModel);
        }

        // GET: Coordinate/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coordinateModel = await _context.CoordinateModel.SingleOrDefaultAsync(m => m.ID == id);
            if (coordinateModel == null)
            {
                return NotFound();
            }

            return View(coordinateModel);
        }

        // POST: Coordinate/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var coordinateModel = await _context.CoordinateModel.SingleOrDefaultAsync(m => m.ID == id);
            _context.CoordinateModel.Remove(coordinateModel);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool CoordinateModelExists(int id)
        {
            return _context.CoordinateModel.Any(e => e.ID == id);
        }
    }
}
