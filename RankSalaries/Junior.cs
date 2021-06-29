using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MaternityWard.Tables;

namespace MaternityWard.RankSalaries
{
    class Junior : ISalary
    {
        public SqliteDbContext Db { set; get; }
        public string WorkerId { set; get; }
        public Junior(SqliteDbContext db, string workerId)
        {
            this.Db = db;
            this.WorkerId = workerId;
        }

        public float Calculate(float salary)
        {
            float hourlyRate = this.Db.HourlyRates.Find(this.WorkerId).Value;
            float monthHours = this.Db.MonthWorkHours.Find(this.WorkerId).Hours;
            return salary + hourlyRate * monthHours;
        }
    }
}
