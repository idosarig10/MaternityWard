using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaternityWard.Tables
{
    class WorkTime
    {
        [Required]
        [Key]
        [ForeignKey("Worker")]
        public Guid WorkerId { get; set; }
        [Required]
        public float Hours { get; set; }
        [Required]
        public Worker Worker { get; set; }

    }

}
