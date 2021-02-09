using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBoatNew.Domain.Models
{
    public class Account : DomainObject
    {
        public int UserId { get; set; }
        public User AccountHolder { get; set; }

        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }

        public int ContractId { get; set; }
        public Orders Order { get; set; }

        public bool Settled { get; set; }
        public decimal Sum { get; set; }
        public decimal Sum_IncVAT { get; set; }
        public DateTime Date { get; set; }
    }
}