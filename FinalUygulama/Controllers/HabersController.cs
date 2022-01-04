using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalUygulama.Data;
using FinalUygulama.Models;

namespace FinalUygulama.Controllers
{
    public class HabersController : Controller
    {
        private readonly FinalUygulamaContext _context;

        public HabersController(FinalUygulamaContext context)
        {
            _context = context;
        }

        // GET: Habers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Haber.ToListAsync());
        }

        // GET: Habers/Details/5
        public async Task<IActionResult> Details(long? id)
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

        // GET: Habers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Habers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HaberID,HaberBaslik,HaberAciklama,HaberDetay,HaberResimYolu,Kategori,HaberTarihi")] Haber haber)
        {
            if (ModelState.IsValid)
            {
                _context.Add(haber);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(haber);
        }

        // GET: Habers/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var haber = await _context.Haber.FindAsync(id);
            if (haber == null)
            {
                return NotFound();
            }
            return View(haber);
        }

        // POST: Habers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("HaberID,HaberBaslik,HaberAciklama,HaberDetay,HaberResimYolu,Kategori,HaberTarihi")] Haber haber)
        {
            if (id != haber.HaberID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(haber);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HaberExists(haber.HaberID))
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
            return View(haber);
        }

        // GET: Habers/Delete/5
        public async Task<IActionResult> Delete(long? id)
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

        // POST: Habers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var haber = await _context.Haber.FindAsync(id);
            _context.Haber.Remove(haber);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HaberExists(long id)
        {
            return _context.Haber.Any(e => e.HaberID == id);
        }
    }
}
