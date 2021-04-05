using Data;
using Models;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace My_Application.Controllers
{
    public class ReplacementHeaterController : Infrastructure.BaseControllerWithDatabase
    {
        public ReplacementHeaterController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await UnitOfWork.ReplacementHeaterRepository.GetAllAsync();
            return View(result);
        }

        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            var replacementHeater = await UnitOfWork.ReplacementHeaterRepository.GetByIdAsync(id);

            if (replacementHeater == null)
            {
                return NotFound();
            }

            return View(replacementHeater);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var legalPeople = UnitOfWork.LegalPersonRepository.GetAll().ToString();
            var naturalPeople = UnitOfWork.NaturalPersonRepository.GetAll().ToString();

            ViewData["NameCEO"] = new SelectList(legalPeople, "NameCEO", "NameCEO");
            ViewData["FullName"] = new SelectList(naturalPeople, "FullName", "FullName");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HeaterInstalledType,NameCEO,FullName,HeaterScrapType,Model,Capacity,HeaterScrapSerialNumber,HeaterInstalledSerialNumber,InstallationDate,InstallationTime")] ReplacementHeater replacementHeater)
        {
            if (ModelState.IsValid)
            {
                replacementHeater.ReplacementHeaterId = Guid.NewGuid();
                await UnitOfWork.ReplacementHeaterRepository.InsertAsync(replacementHeater);
                await UnitOfWork.SaveAsync();
                return RedirectToAction(nameof(Index));
            }

            var legalPeople = UnitOfWork.LegalPersonRepository.GetAll().ToString();
            var naturalPeople = UnitOfWork.NaturalPersonRepository.GetAll().ToString();

            ViewData["NameCEO"] = new SelectList(legalPeople, "NameCEO", "NameCEO", replacementHeater.NameCEO);
            ViewData["FullName"] = new SelectList(naturalPeople, "FullName", "FullName", replacementHeater.FullName);

            return View(replacementHeater);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
        
            var replacementHeater = await UnitOfWork.ReplacementHeaterRepository.GetByIdAsync(id);

            if (replacementHeater == null)
            {
                return NotFound();
            }

            var legalPeople = UnitOfWork.LegalPersonRepository.GetAll().ToString();
            var naturalPeople = UnitOfWork.NaturalPersonRepository.GetAll().ToString();

            ViewData["NameCEO"] = new SelectList(legalPeople, "NameCEO", "NameCEO");
            ViewData["FullName"] = new SelectList(naturalPeople, "FullName", "FullName");
            return View(replacementHeater);
        }

        
        [HttpPost , ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,NameCEO,FullName,HeaterScrapType,Model,Capacity,HeaterScrapSerialNumber,HeaterInstalledSerialNumber,InstallationDate,InstallationTime")] ReplacementHeater replacementHeater)
        {
            if (id != replacementHeater.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await UnitOfWork.ReplacementHeaterRepository.UpdateAsync(replacementHeater);
                    await UnitOfWork.SaveAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReplacementHeaterExists(replacementHeater.ReplacementHeaterId))
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


            var legalPeople = UnitOfWork.LegalPersonRepository.GetAll().ToString();
            var naturalPeople = UnitOfWork.NaturalPersonRepository.GetAll().ToString();


            ViewData["NameCEO"] = new SelectList(legalPeople, "NameCEO", "NameCEO", replacementHeater.NameCEO);
            ViewData["FullName"] = new SelectList(naturalPeople, "FullName", "FullName", replacementHeater.FullName);

            return View(replacementHeater);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var replacementHeater = await UnitOfWork.ReplacementHeaterRepository.GetByIdAsync(id);

            if (replacementHeater == null)
            {
                return NotFound();
            }

            return View(replacementHeater);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await UnitOfWork.ReplacementHeaterRepository.DeleteByIdAsync(id);
            await UnitOfWork.SaveAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReplacementHeaterExists(Guid id)
        {
            return UnitOfWork.ReplacementHeaterRepository.Any(id);
        }
    }
}