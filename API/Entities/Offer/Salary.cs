using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public class Salary
    {
        [Key]
        public int Id { get; set; }
        public int TotalAmount { get; set; }
    }
}