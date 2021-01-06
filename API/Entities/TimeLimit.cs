using System.ComponentModel.DataAnnotations;
using API.Enum;

namespace API.Entities
{
    public class TimeLimit
    {
        [Key]
        public int Id { get; set; }
        public int Nombre { get; set; }
        public TypeTime TypeTime { get; set; }
    }
}