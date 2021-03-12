using BankingSystem.Interface.IRepository;
using BankingSystem.Models;
using BankingSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingSystem.Domain.Repository
{
    public class AccountHolderRepository : IAccountHolderRepository
    {
        private readonly BankContext _bankContext;
        public AccountHolderRepository(BankContext bankContext)
        {
            _bankContext = bankContext;
        }

        public AccountHolder AddAccountHolder(AccountHolder accountHolder)
        {
            _bankContext.AccountHolders.Add(accountHolder);
            _bankContext.SaveChanges();
            return accountHolder;
        }

        public void DeleteAccountHolder(int id)
        {
            var accountHolder = _bankContext.AccountHolders.Find(id);
            if (accountHolder != null)
            {
                _bankContext.AccountHolders.Remove(accountHolder);
                _bankContext.SaveChanges();
            }
        }

        public AccountHolder GetAccountHolder(int id)
        {
           return _bankContext.AccountHolders.Find(id);
        }

        public int CreateAccountHolder(AccountHolder accountHolder)
        {
            try
            {
                _bankContext.AccountHolders.Add(accountHolder);
                _bankContext.SaveChanges();
                return accountHolder.Id;


            }
            catch (Exception ea)
            {
                Console.WriteLine($"err2: {ea.Message}");
            }



            return 0;

        }

        public List<AccountHolder> GetAll()
        {
            return _bankContext.AccountHolders.ToList();
        }

        public AccountHolder GetDetails(int id)
        {
            var accountHolder = _bankContext.AccountHolders
                .Where(ach => ach.Id == id)
                .Include(ach => ach.Account).FirstOrDefault();
            return accountHolder;

        }

        public AccountHolder UpdateAccountHolder(AccountHolder accountHolder)
        {
            _bankContext.AccountHolders.Update(accountHolder);
            _bankContext.SaveChanges();
            return accountHolder;
        }
    }
}
