using Data;
using Models;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace My_Application.Controllers
{
    public class InstallerController : Infrastructure.BaseControllerWithDatabase
    {
        public InstallerController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        // GET: Installer
        public async Task<IActionResult> Index()
        {
            var result = await UnitOfWork.InstallerRepository.GetAllAsync();
            return View(result);
        }

        // GET: Installer/Details/5
        public async Task<IActionResult> Details(Guid id)
        {
      
            var installer = await UnitOfWork.InstallerRepository.GetByIdAsync(id);
                
            if (installer == null)
            {
                return NotFound();
            }

            return View(installer);
        }

        // GET: Installer/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Installer/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InstallerId,FullName,InstallerUserName,UserNumber,BirthPlace,NationalCode,BirthDay,Gender,EmailAddress,PhoneNumber,MobileNumber,Address")] Installer installer)
        {
            if (ModelState.IsValid)
            {
                installer.InstallerId = Guid.NewGuid();
                await UnitOfWork.InstallerRepository.InsertAsync(installer);
                await UnitOfWork.SaveAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(installer);
        }

        // GET: Installer/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
            var installer = await UnitOfWork.InstallerRepository.GetByIdAsync(id);

            if (installer == null)
            {
                return NotFound();
            }

            return View(installer);
        }

        // POST: Installer/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,FullName,InstallerUserName,UserNumber,BirthPlace,NationalCode,BirthDay,Gender,EmailAddress,PhoneNumber,MobileNumber,Address")] Installer installer)
        {
            if (id != installer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await UnitOfWork.InstallerRepository.UpdateAsync(installer);
                    await UnitOfWork.SaveAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InstallerExists(installer.InstallerId))
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
            return View(installer);
        }

        // GET: Installer/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            var installer = await UnitOfWork.InstallerRepository.GetByIdAsync(id);
            if (installer == null)
            {
                return NotFound();
            }

            return View(installer);
        }

        // POST: Installer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await UnitOfWork.InstallerRepository.DeleteByIdAsync(id);
            await UnitOfWork.SaveAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InstallerExists(Guid id)
        {
            return UnitOfWork.InstallerRepository.Any(id);
        }
    }
}
