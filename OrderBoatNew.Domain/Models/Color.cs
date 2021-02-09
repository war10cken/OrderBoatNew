namespace OrderBoatNew.Domain.Models
{
    public class Color : DomainObject
    {
        public string Name { get; set; }
        public bool ForAdditionalMoney { get; set; }
        public decimal Price { get; set; }
    }
}