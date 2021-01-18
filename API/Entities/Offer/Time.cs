using System.ComponentModel.DataAnnotations;
using API.Enum;

namespace API.Entities
{
    public class Time
    {
        [Key]
        public int Id { get; set; }
        public int Valeur { get; set; }
        public TypeTime TypeTaux { get; set; }
    }
}