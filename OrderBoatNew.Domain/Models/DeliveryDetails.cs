namespace OrderBoatNew.Domain.Models
{
    public class DeliveryDetails : DomainObject
    {
        public int AccessoryId { get; set; }
        public Accessory Accessory { get; set; }

        public int OrderId { get; set; }
        public Orders Order { get; set; }
    }
}