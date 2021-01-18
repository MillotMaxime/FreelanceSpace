using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}