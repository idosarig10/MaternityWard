using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaternityWard.Tables
{
    class WorkerRanks
    {
        [Required]
        [ForeignKey("Worker")]
        public Guid WorkerId { get; set; }
        [Required]
        public String Rank { get; set; }
        [Required]
        public Worker Worker { get; set; }
    }

}
