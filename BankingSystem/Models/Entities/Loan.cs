using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingSystem.Models.Entities
{
    public class Loan : LoanOverdraftDetails
    {
        public string TypeofLoan{ get; set; }

        public double AmountLeft { get; set; }

        public DateTime LoanDate { get; }
    }
}
