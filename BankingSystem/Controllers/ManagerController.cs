using BankingSystem.Interface.IService;
using BankingSystem.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingSystem.Controllers
{
    public class ManagerController : Controller
    {
        private readonly IManagerService _managerService;

        public ManagerController(IManagerService managerService)
        {
            _managerService = managerService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_managerService.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Manager manager)
        {
            if (ModelState.IsValid)
            {
                _managerService.AddManager(manager);
            }
            //return View();
            return RedirectToAction(nameof(Index));

        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var manager= _managerService.GetManager(id.Value);
            if (manager == null)
            {
                return NotFound();
            }

            return View(manager);
        }

        [HttpPost]
        public IActionResult Edit(int id, Manager manager)
        {
            if (id != manager.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _managerService.UpdateManager(manager);
                return RedirectToAction(nameof(Index));
            }
            return View(manager);
        }

            [HttpGet]
        public IActionResult Details(int? id)
        {
            return View(_managerService.GetManager(id.Value));
        }
    }
}
