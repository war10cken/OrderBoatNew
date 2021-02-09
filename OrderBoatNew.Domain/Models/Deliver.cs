using System;

namespace OrderBoatNew.Domain.Models
{
    public class Deliver : DomainObject
    {
        public DateTime Date { get; set; }
        
        public int ManagerId { get; set; }
        public Managers Manager { get; set; }
        
        public int CustomerId { get; set; }
        public Customers Customer { get; set; }

        public int BoatId { get; set; }
        public Boat Boat { get; set; }

        public string DeliveryAddress { get; set; }
        public string City { get; set; }
    }
}