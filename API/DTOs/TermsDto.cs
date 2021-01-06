using System;

namespace API.DTOs
{
    public class TermsDto
    {
        public String Begin { get; set; }
        public TimeLimitDto End { get; set; }
        public TimeLimitDto TimeSpent { get; set; }
    }
}