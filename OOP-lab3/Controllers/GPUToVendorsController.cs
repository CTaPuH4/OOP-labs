using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OOP_lab3.Data;
using OOP_lab3.Models;

namespace OOP_lab3.Controllers
{
    public class GPUToVendorsController : Controller
    {
        private readonly ApplicationDB _context;

        public GPUToVendorsController(ApplicationDB context)
        {
            _context = context;
        }

        // GET: GPUToVendors
        public async Task<IActionResult> Index()
        {
            var applicationDB = _context.GPUToVendors.Include(g => g.GPU).Include(g => g.Vendor);
            return View(await applicationDB.ToListAsync());
        }

        // GET: GPUToVendors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gPUToVendor = await _context.GPUToVendors
                .Include(g => g.GPU)
                .Include(g => g.Vendor)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (gPUToVendor == null)
            {
                return NotFound();
            }

            return View(gPUToVendor);
        }

        // GET: GPUToVendors/Create
        public IActionResult Create()
        {
            ViewData["GPUID"] = new SelectList(_context.GPUs, "Id", "Id");
            ViewData["VendorID"] = new SelectList(_context.Vendors, "Id", "Id");
            return View();
        }

        // POST: GPUToVendors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,GPUID,VendorID")] GPUToVendor gPUToVendor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gPUToVendor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GPUID"] = new SelectList(_context.GPUs, "Id", "Id", gPUToVendor.GPUID);
            ViewData["VendorID"] = new SelectList(_context.Vendors, "Id", "Id", gPUToVendor.VendorID);
            return View(gPUToVendor);
        }

        // GET: GPUToVendors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gPUToVendor = await _context.GPUToVendors.FindAsync(id);
            if (gPUToVendor == null)
            {
                return NotFound();
            }
            ViewData["GPUID"] = new SelectList(_context.GPUs, "Id", "Id", gPUToVendor.GPUID);
            ViewData["VendorID"] = new SelectList(_context.Vendors, "Id", "Id", gPUToVendor.VendorID);
            return View(gPUToVendor);
        }

        // POST: GPUToVendors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,GPUID,VendorID")] GPUToVendor gPUToVendor)
        {
            if (id != gPUToVendor.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gPUToVendor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GPUToVendorExists(gPUToVendor.ID))
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
            ViewData["GPUID"] = new SelectList(_context.GPUs, "Id", "Id", gPUToVendor.GPUID);
            ViewData["VendorID"] = new SelectList(_context.Vendors, "Id", "Id", gPUToVendor.VendorID);
            return View(gPUToVendor);
        }

        // GET: GPUToVendors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gPUToVendor = await _context.GPUToVendors
                .Include(g => g.GPU)
                .Include(g => g.Vendor)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (gPUToVendor == null)
            {
                return NotFound();
            }

            return View(gPUToVendor);
        }

        // POST: GPUToVendors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gPUToVendor = await _context.GPUToVendors.FindAsync(id);
            if (gPUToVendor != null)
            {
                _context.GPUToVendors.Remove(gPUToVendor);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GPUToVendorExists(int id)
        {
            return _context.GPUToVendors.Any(e => e.ID == id);
        }
    }
}
