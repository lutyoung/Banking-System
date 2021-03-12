using BankingSystem.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingSystem.Interface.IRepository
{
    public interface IAccountRepository
    {
        public bool Create(Account account);

        public Account FindById(int id);

        public Account Update(Account account);

        public bool UpdateMultiple(List<Account> accounts);

        public Account FindByAccountNumber(string accountNumber);
    }
}
