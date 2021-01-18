using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public class Penalty
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("TimeLimit"), Column("Id")] 
        public TauxHorraire TauxHorraire { get; set; }
    }
}