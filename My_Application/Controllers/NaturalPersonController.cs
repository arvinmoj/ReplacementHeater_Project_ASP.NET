using Data;
using Models;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace My_Application.Controllers
{
    // [Authorize]
    public class NaturalPersonController : Infrastructure.BaseControllerWithDatabase
    {
        public NaturalPersonController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        // GET: NaturalPerson
        public async Task<IActionResult> Index()
        {
            var result = await UnitOfWork.NaturalPersonRepository.GetAllAsync();

            return View(result);
        }

        // GET: NaturalPerson/Details/5
        public async Task<IActionResult> Details(Guid id)
        {

            var naturalPerson = await UnitOfWork.NaturalPersonRepository.GetByIdAsync(id);

            if (naturalPerson == null)
            {
                return NotFound();
            }

            return View(naturalPerson);
        }

        // GET: NaturalPerson/Create
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

        // POST: NaturalPerson/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NaturalPersonId,InstallerUserName,FullName,NationalCode,EmailAddress,PhoneNumber,MobileNumber,City,State,Address,PostalCode,InstallationLocation,GasometerType,GasometerNumber,PersonNumber,Attachment")] NaturalPerson naturalPerson)
        {
            if (ModelState.IsValid)
            {
                naturalPerson.NaturalPersonId = Guid.NewGuid();
                naturalPerson.UserNaturalPerson = true;
                await UnitOfWork.NaturalPersonRepository.InsertAsync(naturalPerson);
                await UnitOfWork.SaveAsync();
                return RedirectToAction(nameof(Index));
            }

            var cities = UnitOfWork.CityRepository.GetAll();
            var states = UnitOfWork.StateRepository.GetAll();
            var installers = UnitOfWork.InstallerRepository.GetAll();

            ViewData["Cities"] = new SelectList(cities, "CityName", "CityName", naturalPerson.City);
            ViewData["States"] = new SelectList(states, "StateName", "StateName", naturalPerson.State);
            ViewData["InstallerUserName"] = new SelectList(installers, "InstallerUserName", "InstallerUserName", naturalPerson.InstallerUserName);

            return View(naturalPerson);
        }

        public async Task<IActionResult> AddHeater([Bind("NaturalPersonId,InstallerUserName,FullName,NationalCode,EmailAddress,PhoneNumber,MobileNumber,City,State,Address,PostalCode,InstallationLocation,GasometerType,GasometerNumber,PersonNumber,Attachment")] NaturalPerson naturalPerson)
        {

            if (ModelState.IsValid)
            {
                naturalPerson.NaturalPersonId = Guid.NewGuid();
                naturalPerson.UserNaturalPerson = true;
                await UnitOfWork.NaturalPersonRepository.InsertAsync(naturalPerson);
                await UnitOfWork.SaveAsync();
            }

            return RedirectToAction("Create", "ReplacementHeater");
            
        }

        // GET: NaturalPerson/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
            var naturalPerson = await UnitOfWork.NaturalPersonRepository.GetByIdAsync(id);

            if (naturalPerson == null)
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

            return View(naturalPerson);
        }

        // POST: NaturalPerson/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,InstallerUserName,FullName,NationalCode,EmailAddress,PhoneNumber,MobileNumber,City,State,Address,PostalCode,InstallationLocation,GasometerType,GasometerNumber,PersonNumber,Attachment")] NaturalPerson naturalPerson)
        {
            if (id != naturalPerson.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await UnitOfWork.NaturalPersonRepository.UpdateAsync(naturalPerson);
                    await UnitOfWork.SaveAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NaturalPersonExists(naturalPerson.NaturalPersonId))
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


            ViewData["Cities"] = new SelectList(cities, "CityName", "CityName");
            ViewData["States"] = new SelectList(states, "StateName", "StateName");
            ViewData["InstallerUserName"] = new SelectList(installers, "InstallerUserName", "InstallerUserName");

            return View(naturalPerson);
        }

        // GET: NaturalPerson/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            var naturalPerson = await UnitOfWork.NaturalPersonRepository.GetByIdAsync(id);

            if (naturalPerson == null)
            {
                return NotFound();
            }

            return View(naturalPerson);
        }

        // POST: NaturalPerson/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await UnitOfWork.NaturalPersonRepository.DeleteByIdAsync(id);
            await UnitOfWork.SaveAsync();

            return RedirectToAction(nameof(Index));
        }

        private bool NaturalPersonExists(Guid id)
        {
            return UnitOfWork.NaturalPersonRepository.Any(id);
        }
    }
}