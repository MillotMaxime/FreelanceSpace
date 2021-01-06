using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public class RecurenceSalaire
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("TimeLimit"), Column("Id")]
        public TimeLimit recurence { get; set; }
    }
}