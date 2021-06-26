using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaternityWard.RankSalaries
{
    class Junior: ISalary
    {
        public SqliteDbContext Db { set; get; }
        public Guid WorkerId { set; get; }
        public Junior(SqliteDbContext db, Guid workerId)
        {
            this.Db = db;
            this.WorkerId = workerId;
        }

        public float Calculate(float salary)
        {
            float hourlyWage = this.Db.Workers.Find(WorkerId.ToString()).HourlyWage;
            float monthHours = this.Db.MonthWorkHours.Single(mwh => mwh.Worker.Id == WorkerId).Hours;
            return salary + hourlyWage * monthHours;
        }
    }
}
