using System;
using Microsoft.EntityFrameworkCore;

namespace MaternityWard
{
     class Worker
    {
        public string Id { get; set;}
        public float HourlyWage { get; set;}
        public string WorkerType { get; set;}
    }
}
