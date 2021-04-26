using Data;
using Models;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace My_Application.Controllers
{
    // [Authorize]
    public class LegalPersonController : Infrastructure.BaseControllerWithDatabase
    {
        public LegalPersonController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        // GET: LegalPerson
        public async Task<IActionResult> Index()
        {
            var result = await UnitOfWork.LegalPersonRepository.GetAllAsync();

            return View(result);
        }

        // GET: LegalPerson/Details/5
        public async Task<IActionResult> Details(Guid id)
        {
            var legalPerson = await UnitOfWork.LegalPersonRepository.GetByIdAsync(id);

            if (legalPerson == null)
            {
                return NotFound();
            }

            return View(legalPerson);
        }

        // GET: LegalPerson/Create
        public IActionResult Create()
        {
            var cities = UnitOfWork.CityRepository.GetAll();
            var states = UnitOfWork.StateRepository.GetAll();
            var installers = UnitOfWork.InstallerRepository.GetAll();

            ViewData["Cities"] = new SelectList(cities, "CityName", "CityName");
            ViewData["States"] = new SelectList(states, "StateName", "StateName");
            ViewData["InstallerUserName"] = new SelectList(installers, "InstallerUserName", "InstallerUserName");

            return View();
        }

        // POST: LegalPerson/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LegalPersonId,InstallerUserName,CompanyName,NameCEO,EmailAddress,PhoneNumber,City,State,Region,Address,NationalCode,RegistrationNumber,EconomicCode,RecipientName,InstallationLocation,GasometerType,GasometerNumber,PersonNumber,Attachment")] LegalPerson legalPerson)
        {
            if (ModelState.IsValid)
            {
                legalPerson.LegalPersonId = Guid.NewGuid();
                await UnitOfWork.LegalPersonRepository.InsertAsync(legalPerson);
                await UnitOfWork.SaveAsync();
                return RedirectToAction(nameof(Index));
            }

            var cities = UnitOfWork.CityRepository.GetAll();
            var states = UnitOfWork.StateRepository.GetAll();
            var installers = UnitOfWork.InstallerRepository.GetAll();

            ViewData["Cities"] = new SelectList(cities, "CityName", "CityName", legalPerson.City);
            ViewData["States"] = new SelectList(states, "StateName", "StateName", legalPerson.State);
            ViewData["InstallerUserName"] = new SelectList(installers, "InstallerUserName", "InstallerUserName", legalPerson.InstallerUserName);

            return View(legalPerson);
        }

        // GET: LegalPerson/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {

            var legalPerson = await UnitOfWork.LegalPersonRepository.GetByIdAsync(id);

            if (legalPerson == null)
            {
                return NotFound();
            }

            //ViewBag.Cities = _context.Cities.ToList();

            var cities = UnitOfWork.CityRepository.GetAll();
            var states = UnitOfWork.StateRepository.GetAll();
            var installers = UnitOfWork.InstallerRepository.GetAll();


            ViewData["Cities"] = new SelectList(cities, "CityName", "CityName");
            ViewData["States"] = new SelectList(states, "StateName", "StateName");
            ViewData["InstallerUserName"] = new SelectList(installers, "InstallerUserName", "InstallerUserName");

            return View(legalPerson);
        }

        // POST: LegalPerson/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,InstallerUserName,CompanyName,NameCEO,EmailAddress,PhoneNumber,City,State,Region,Address,NationalCode,RegistrationNumber,EconomicCode,RecipientName,InstallationLocation,GasometerType,GasometerNumber,PersonNumber,Attachment")] LegalPerson legalPerson)
        {
            if (id != legalPerson.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await UnitOfWork.LegalPersonRepository.UpdateAsync(legalPerson);
                    await UnitOfWork.SaveAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LegalPersonExists(legalPerson.LegalPersonId))
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

            var cities = UnitOfWork.CityRepository.GetAll();
            var states = UnitOfWork.StateRepository.GetAll();
            var installers = UnitOfWork.InstallerRepository.GetAll();

            ViewData["Cities"] = new SelectList(cities, "CityName", "CityName", legalPerson.City);
            ViewData["States"] = new SelectList(states, "StateName", "StateName", legalPerson.State);
            ViewData["InstallerUserName"] = new SelectList(installers, "InstallerUserName", "InstallerUserName", legalPerson.InstallerUserName);

            return View(legalPerson);
        }

        public JsonResult GetStateList(Guid id)
        {
            List<State> list = new List<State>();
            list = UnitOfWork.StateRepository.States(id);
            list.Insert(0, new State { IdState = Guid.NewGuid(), StateName = "Plese select state" });

            return Json(new SelectList(list, "IdState", "StateName"));
        }

        // GET: LegalPerson/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            var legalPerson = await UnitOfWork.LegalPersonRepository.GetByIdAsync(id);
            if (legalPerson == null)
            {
                return NotFound();
            }

            return View(legalPerson);
        }

        // POST: LegalPerson/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await UnitOfWork.LegalPersonRepository.DeleteByIdAsync(id);
            await UnitOfWork.SaveAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LegalPersonExists(Guid id)
        {
            return UnitOfWork.LegalPersonRepository.Any(id);
        }
    }
}