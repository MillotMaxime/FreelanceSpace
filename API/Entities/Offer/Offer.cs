using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using API.Enum;

namespace API.Entities
{
    public class Offer
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Buisness"), Column("Id")]
        public Business Creator { get; set; }

        public DateTime Create { get; set; }

        public string Name { get; set; }

        public string But { get; set; }

        public string Description { get; set; }

        public string DescriptionFreelance { get; set; }

        public TypeOffer TypeOffer { get; set; }

        public Terms Terms { get; set; }

        public Salary Salary { get; set; }

        public Boolean BusinessValidation { get; set; }

        public Boolean FreelanceValidation { get; set; }
    }
}