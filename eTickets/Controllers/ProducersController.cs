﻿using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IProducersService _service;
        // private readonly AppDbContext _context;
        // public ProducersController(AppDbContext context)

        public ProducersController(IProducersService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            // var allProducers = await _context.Producers.ToListAsync();

            var allProducers = await _service.GetAllAsync();
            return View(allProducers);
        }
        //Get:Producer/Details/ID
        public async Task<IActionResult> Details(int id)
        {
            var producerDetails=await _service.GetByIdAsync(id);    
            if(producerDetails==null) return View("NotFound");
            return View(producerDetails);
        }
        //Get:Producer/Create(get and post methods)
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePictureURL,FullName,Bio")] Producer producer)
        {
            if (!ModelState.IsValid) return View(producer);

            await _service.AddAsync(producer);
            return RedirectToAction(nameof(Index));
        }
        //Get:Producer/Edit(get and post methods)
        public async Task<IActionResult> Edit(int id)
        {
            var producerDetais = await _service.GetByIdAsync(id);
            if (producerDetais == null) return View("NotFound");
            return View(producerDetais);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id,[Bind("Id,ProfilePictureURL,FullName,Bio")] Producer producer)
        {
            if (!ModelState.IsValid) return View(producer);

            if (id == producer.Id)
            {
                await _service.UpdateAsync(id, producer);
                return RedirectToAction(nameof(Index));
            }
            return View(producer);
            
        }
        //Get:Producer/Delete(get and delete methods)
        public async Task<IActionResult> Delete(int id)
        {
            var producerDetais = await _service.GetByIdAsync(id);
            if (producerDetais == null) return View("NotFound");
            return View(producerDetais);
        }

        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producerDetais = await _service.GetByIdAsync(id);
            if (producerDetais == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));

        }
    }
}
