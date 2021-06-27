using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MaternityWard.Tables
{
    class HourlyRate
    {
        [Required]
        [Key]
        public string Id { get; set; }
        [Required]
        public float Value { get; set; }
    }
}
