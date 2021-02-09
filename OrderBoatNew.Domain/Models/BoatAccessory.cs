namespace OrderBoatNew.Domain.Models
{
    public class BoatAccessory : DomainObject
    {
        public int AccessoryId { get; set; }
        public Accessory Accessory { get; set; }

        public int BoatId { get; set; }
        public Boat Boat { get; set; }
    }
}