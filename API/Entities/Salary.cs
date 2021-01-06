using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public class Salary
    {
        [Key]
        public int id { get; set; }
        
        public int Montant { get; set; }

        [ForeignKey("TimeLimit"), Column("Id")]        
        public TimeLimit Recurence { get; set; }
    }
}