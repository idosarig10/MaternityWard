using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MaternityWard.Tables
{
    class Worker
    {
        [Key]
        [Required]
        public string Id { get; set;}
        [Required]
        public string WorkerType { get; set;}
    }

}
