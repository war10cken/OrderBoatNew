namespace OrderBoatNew.Domain.Models
{
    public enum BoatTypes
    {
        Lodka,
        SParysom,
        Galera
    }
    
    public class Boat : DomainObject
    {
        public int ModelId { get; set; }
        public Model Model { get; set; }
        
        public int BoatTypeId { get; set; }
        public BoatType BoatType { get; set; }
        
        public int NumberOfRowers { get; set; }
        public bool Mast { get; set; }
        
        public int ColorId { get; set; }
        public Color Color { get; set; }

        public int WoodId { get; set; }
        public Wood Wood { get; set; }
        
        public decimal BasePrice { get; set; }
        public decimal VAT { get; set; }
    }
}