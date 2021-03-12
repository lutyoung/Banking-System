using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankingSystem.Models.Entities
{
    public class AccountHolder : Details
    {
        public AccountHolder()
        {
            Loans = new List<Loan>();
            OverDrafts = new List<OverDraft>();
        }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string Address { get; set; }

        public Account Account { get; set; }

        public IList<Loan> Loans  { get; set; }

        public IList<OverDraft> OverDrafts { get; set; }
    }
}
