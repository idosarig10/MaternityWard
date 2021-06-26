using System;
using Microsoft.EntityFrameworkCore;

namespace MaternityWard
{
     class Worker
    {
        public string Id { get; set;}
        public float hourlyWage { get; set;}
        public string workerType { get; set;}
    }
}
