using BankingSystem.Interface.IRepository;
using BankingSystem.Models;
using BankingSystem.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingSystem.Domain.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankContext _bankContext;

        public AccountRepository(BankContext bankContext)
        {
            _bankContext = bankContext;
        }

        public bool Create(Account account)
        {
            _bankContext.Accounts.Add(account);
            _bankContext.SaveChanges();
            return true;
        }

        public Account FindByAccountNumber(string accountNumber)
        {
            throw new NotImplementedException();
        }

        public Account FindById(int id)
        {
            return _bankContext.Accounts.FirstOrDefault(a => a.AccountHolderId == id);
        }

        public Account Update(Account account)
        {
            _bankContext.Accounts.Update(account);
            _bankContext.SaveChanges();
            return account;
        }

        public bool UpdateMultiple(List<Account> accounts)
        {
            _bankContext.Accounts.UpdateRange(accounts);
            _bankContext.SaveChanges();
            return true;
        }
    }
}
