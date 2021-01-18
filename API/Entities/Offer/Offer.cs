using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        public string Description { get; set; }

        public Terms Terms { get; set; }

        public Salary Salary { get; set; }

        public Penalty Penalty { get; set; }

        public Boolean BusinessValidation { get; set; }

        public Boolean FreelanceValidation { get; set; }
    }
}