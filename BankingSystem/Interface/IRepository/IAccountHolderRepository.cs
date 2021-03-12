using BankingSystem.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingSystem.Interface.IRepository
{
    public interface IAccountHolderRepository
    {
        public List<AccountHolder> GetAll();

        public AccountHolder GetAccountHolder(int id);

        public AccountHolder AddAccountHolder(AccountHolder accountHolder);

        public AccountHolder UpdateAccountHolder(AccountHolder accountHolder);

        public void DeleteAccountHolder(int id);

        //public bool Exists(int id);

        public int CreateAccountHolder(AccountHolder accountHolder);

        public AccountHolder GetDetails(int id);
    }
}
