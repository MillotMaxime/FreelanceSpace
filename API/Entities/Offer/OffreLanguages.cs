namespace API.Entities
{
    public class OfferLanguages
    {
        public int Id { get; set; }
        public Offer Offre { get; set; }
        public Language Language { get; set; }
        public bool Favoris { get; set; }
    }
}