using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaternityWard.Tables
{
    class MonthMinimunWorkHours
    {
        [Required]
        [Key]
        public string Rank { get; set; }
        [Required]
        public float Hours { get; set; }
    }
}
