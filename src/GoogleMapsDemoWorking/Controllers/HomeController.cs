using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoogleMapsDemoWorking.Data;
using GoogleMapsDemoWorking.Models.GoogleMapsDemoModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GoogleMapsDemoWorking.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            foreach (SectorViewModel model in _context.SectorViewModel.ToList())
            {
                model.Coordinates = _context.CoordinateModel.Where(p => p.SectorView == model.ID).ToList();
            }
            ViewBag.Sectors = _context.SectorViewModel.ToList();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
