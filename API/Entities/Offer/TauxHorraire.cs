using System.ComponentModel.DataAnnotations;
using API.Enum;

namespace API.Entities
{
    public class TauxHorraire
    {
        [Key]
        public int Id { get; set; }
        public int Valeur { get; set; }
        public TypeTaux TypeTaux { get; set; }
    }
}