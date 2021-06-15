using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class OfferProgramingLanguages
    {
        public int Id { get; set; }
        public Offer Offre { get; set; }
        public ProgramingLanguage ProgramingLanguage { get; set; }
        public bool Favoris { get; set; }
        public int YearExperience { get; set; }
    }
}