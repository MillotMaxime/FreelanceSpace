using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Penalty
    {
        [Key]
        public int id { get; set; }

        public TauxHorraire TauxHorraire { get; set; }
    }
}