using System;
using System.Collections.Generic;

namespace API.DTOs
{
    public class OfferDto
    {
        public UserDto Creator { get; set; }
        public DateTime? Create { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TermsDto Terms { get; set; }
        public SalaryDto Salary { get; set; }
        public PenaltyDto Penalty { get; set; }
        public Boolean BusinessValidation { get; set; }
        public Boolean FreelanceValidation { get; set; }
        public List<OfferProgramingLanguagesDto> ComputerLanguage { get; set; }
        public List<OfferLanguagesDto> LanguageSpeak { get; set; }
        
    }
}