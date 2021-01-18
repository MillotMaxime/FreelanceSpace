using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public class Terms
    {
        [Key]
        public int Id { get; set; }
        
        public DateTime? Begin { get; set; }

        [ForeignKey("Time"), Column("Id")] 
        public Time End { get; set; }
       
    }
}