using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingSystem.Models.Entities
{
    public class OverDraft : LoanOverdraftDetails
    {

        public double AmountLeft { get; set; }

        public DateTime OverdraftDate { get; }
    }
}
