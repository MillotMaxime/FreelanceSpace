using System;
using System.Collections.Generic;
using API.Enum;

namespace API.DTOs
{
    public class OfferDto
    {
        public UserDto Creator { get; set; }
        public DateTime? Create { get; set; }
        public string Name { get; set; }
        public string But { get; set; }
        public string Description { get; set; }
        public string DescriptionFreelance { get; set; }
        public TypeOffer TypeOffer { get; set; }
        public TermsDto Terms { get; set; }
        public SalaryDto Salary { get; set; }
        public Boolean? BusinessValidation { get; set; }
        public Boolean? FreelanceValidation { get; set; }
        public List<OfferProgramingLanguagesDto> ProgramingLanguages { get; set; }
        public List<OfferLanguagesDto> Language { get; set; }
        
    }
}