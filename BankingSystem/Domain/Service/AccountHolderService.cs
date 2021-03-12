using BankingSystem.Interface.IRepository;
using BankingSystem.Interface.IService;
using BankingSystem.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingSystem.Domain.Service
{
    public class AccountHolderService : IAccountHolderService
    {
        private readonly IAccountHolderRepository _accountHolderRepository;
        private readonly IAccountRepository _accountRepository;

        public AccountHolderService(IAccountHolderRepository accountHolderRepository, IAccountRepository accountRepository)
        {
            _accountHolderRepository = accountHolderRepository;
            _accountRepository = accountRepository;
        }

        public AccountHolder AddAccountHolder(AccountHolder accountHolder)
        {
            AccountHolder createdAccountHolder = _accountHolderRepository.AddAccountHolder(accountHolder);
            CreateAccount(createdAccountHolder.Id);
            return createdAccountHolder;
        }

        public void DeleteAccountHolder(int id)
        {
            _accountHolderRepository.DeleteAccountHolder(id);
        }

        public AccountHolder GetAccountHolder(int id)
        {
            return _accountHolderRepository.GetAccountHolder(id);
        }

        public List<AccountHolder> GetAll()
        {
            return _accountHolderRepository.GetAll();
        }

        public AccountHolder GetDetails(int id)
        {
            return _accountHolderRepository.GetDetails(id);
        }

        public AccountHolder UpdateAccountHolder(AccountHolder accountHolder)
        {
            return _accountHolderRepository.UpdateAccountHolder(accountHolder);
        }

   

        public bool CreateAccount(int accountHolderId)
        {
            string accountNumber = GenerateAccountNumber();

            Account newAccount = new Account
            {
                AccountHolderId = accountHolderId,
                AccountNumber = accountNumber,
                AccountBalance = 0.00,
                Pin = 0,
                AccountStatus = 1
            };

            bool hasCreate = _accountRepository.Create(newAccount);


            return hasCreate;

        }

        protected string GenerateAccountNumber()
        {
            Random random = new Random();

            string firstFive = random.Next(1, 10000).ToString("00000");
            string secondFive = random.Next(1, 10000).ToString("00000");

            string generatedNumber = $"{firstFive}{secondFive}";

            return generatedNumber;
        }
    }
}
