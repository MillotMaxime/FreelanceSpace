namespace API.Entities
{
    public class OffreLanguagesSpeak
    {
        public int Id { get; set; }
        public Offre Offre { get; set; }
        public LanguageSpeak Speak { get; set; }
        public bool Favoris { get; set; }
    }
}