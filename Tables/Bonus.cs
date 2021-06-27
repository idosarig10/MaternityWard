using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaternityWard.Tables
{
    class Bonus
    {
        [Required]
        [Key]
        public string Id { get; set; }
        [Required]
        public float BonusPercentage { get; set; }
    }
}