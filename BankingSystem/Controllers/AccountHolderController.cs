using BankingSystem.Interface.IService;
using BankingSystem.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingSystem.Controllers
{
    public class AccountHolderController : Controller
    {

        private readonly IAccountHolderService _accountHolderService;

        public AccountHolderController(IAccountHolderService accountHolderService)
        {
            _accountHolderService = accountHolderService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_accountHolderService.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(AccountHolder accountHolder)
        {
            if (ModelState.IsValid)
            {
                _accountHolderService.AddAccountHolder(accountHolder);
            }
            //return View();
            return RedirectToAction(nameof(Index));

        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var accountHolder = _accountHolderService.GetAccountHolder(id.Value);
            if (accountHolder == null)
            {
                return NotFound();
            }

            return View(accountHolder);
        }

        [HttpPost]
        public IActionResult Edit(int id, AccountHolder accountHolder)
        {
            if (id != accountHolder.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _accountHolderService.UpdateAccountHolder(accountHolder);
                return RedirectToAction(nameof(Index));
            }
            return View(accountHolder);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var accountHolder = _accountHolderService.GetAccountHolder(id.Value);
            if (accountHolder == null)
            {
                return NotFound();
            }
            return View(accountHolder);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _accountHolderService.DeleteAccountHolder(id);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            return View(_accountHolderService.GetDetails(id.Value));
        }

        
    }
}
