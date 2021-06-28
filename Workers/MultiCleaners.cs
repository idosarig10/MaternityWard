using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MaternityWard.Tables;

namespace MaternityWard.RankSalaries
{
    class MultiCleaners : IWorker
    {
        public Senior Senior { set; get; }
        public SqliteDbContext Db { set; get; }
        public string WorkerId { set; get; }
        public MultiCleaners(SqliteDbContext db, string workerId)
        {
            this.Senior = new Senior(db, workerId);
            this.Db = db;
            this.WorkerId = workerId;
        }
        public float Calculate()
        {
            return this.Senior.Calculate(0);
        }
        public void AddToDb(float hourlyRate, float monthActualWorkHours = 0)
        {
            this.Db.Workers.Add(new Worker { Id = this.WorkerId, WorkerType = this.GetType().Name});
            this.Db.HourlyRates.Add(new HourlyRate { Id = this.WorkerId, Value = hourlyRate });
            this.Db.MonthActualWorkHours.Add(new MonthActualWorkHours { WorkerId = this.WorkerId, Hours = monthActualWorkHours });
            this.Db.SaveChanges();
        }
    }
}