using BankingSystem.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingSystem.Models
{
    public class LoanOverdraftDetails : BaseEntity
    {
        public AccountHolder AccountHolder { get; set; }

        public int AccountHolderId { get; set; }

        public double Amount { get; set; }

        public int Status { get; set; }
    }
}
