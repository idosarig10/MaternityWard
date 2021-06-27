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
        public string WorkerId { get; set; }
        [Required]
        public string Rank { get; set; }
        [Required]
        public Worker Worker { get; set; }
    }

}
