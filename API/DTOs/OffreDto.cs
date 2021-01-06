using System;
using System.Collections.Generic;

namespace API.DTOs
{
    public class OffreDto
    {
        public UserDto Creator { get; set; }
        public DateTime Create { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public SalaryDto Salary { get; set; }
        public SalaryPenaltyDto Penalty { get; set; }
        public TermsDto Terms { get; set; }
        public Boolean BusinessValidation { get; set; }
        public Boolean FreelanceValidation { get; set; }
        public List<ComputerLanguageOffreDto> ComputerLanguage { get; set; }
        public List<LanguageSpeakOffreDto> LanguageSpeak { get; set; }
        
    }
}