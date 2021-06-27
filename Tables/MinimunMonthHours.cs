using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaternityWard.Tables
{
    class MinimunMonthHours
    {
        [Required]
        [Key]
        public String Id { get; set; }
        [Required]
        public float Hours { get; set; }
    }

}
