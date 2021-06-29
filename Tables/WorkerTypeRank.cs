using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaternityWard.Tables
{
    class WorkerTypeRank
    {
        [Required]
        public string WorkerType { get; set; }
        [Required]
        public string Rank { get; set; }
    }

}
