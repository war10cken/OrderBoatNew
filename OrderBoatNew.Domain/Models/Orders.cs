using System;

namespace OrderBoatNew.Domain.Models
{
    public class Orders : DomainObject
    {
        public DateTime Date { get; set; }
        public string DepositPayed { get; set; }

        public int OrderId { get; set; }
        public Orders Order { get; set; }

        public decimal ContractTotalPrice { get; set; }
        public decimal ContractTotalPrice_IncVAT { get; set; }
        public string ProductionProcess { get; set; }
    }
}