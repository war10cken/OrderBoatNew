namespace OrderBoatNew.Domain.Models
{
    public class Accessory : DomainObject
    {
        public string AccName { get; set; }
        public string DescriptionOfAccessory { get; set; }
        public decimal Price { get; set; }
        public decimal VAT { get; set; }
        public int Inventory { get; set; }
        public int OrderLevel { get; set; }
        public int OrderBatch { get; set; }

        public int PartnerId { get; set; }
        public Partners Partner { get; set; }
    }
}