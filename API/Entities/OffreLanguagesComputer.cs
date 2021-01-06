using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class OffreLanguagesComputer
    {
        public int Id { get; set; }
        public Offre Offre { get; set; }
        public ComputerLanguage ComputerLanguage { get; set; }
        public bool Favoris { get; set; }
    }
}