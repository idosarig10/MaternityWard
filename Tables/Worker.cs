using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MaternityWard.Tables
{
    class Worker
    {
        [Required]
        public Guid Id { get; set;}
        [Required]
        public float HourlyWage { get; set;}
        [Required]
        public string WorkerType { get; set;}
    }

}
