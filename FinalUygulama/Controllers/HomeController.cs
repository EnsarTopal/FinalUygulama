using FinalUygulama.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FinalUygulama.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


namespace FinalUygulama.Controllers
{
    public class HomeController : Controller
    {
        private readonly FinalUygulamaContext _context;

        public HomeController(FinalUygulamaContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var sorgu = (from haber in _context.Haber
                         orderby haber.HaberID descending
                         select haber).Take(5);

            return View(await sorgu.ToListAsync());
        }

        public async Task<IActionResult> Detay(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var haber = await _context.Haber
                .FirstOrDefaultAsync(m => m.HaberID == id);
            if (haber == null)
            {
                return NotFound();
            }

            return View(haber);
        }
        public IActionResult Contact()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
