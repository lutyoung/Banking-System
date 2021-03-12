using BankingSystem.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingSystem.Interface.IService
{
    public interface IAccountHolderService
    {
        public List<AccountHolder> GetAll();


        public AccountHolder AddAccountHolder(AccountHolder accountHolder);

        public AccountHolder GetAccountHolder(int id);

        public AccountHolder UpdateAccountHolder(AccountHolder accountHolder);

        public void DeleteAccountHolder(int id);

        public AccountHolder GetDetails(int id);

       
    }
}
