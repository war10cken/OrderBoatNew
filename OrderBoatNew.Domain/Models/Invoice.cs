using System;

namespace OrderBoatNew.Domain.Models
{
    public class Invoice : DomainObject
    {
        public int ContractId { get; set; }
        public Orders Order { get; set; }

        public bool Settled { get; set; }
        public decimal Sum { get; set; }
        public decimal Sum_incVAT { get; set; }
        public DateTime Date { get; set; }
    }
}