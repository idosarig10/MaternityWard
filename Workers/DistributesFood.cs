using MaternityWard.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaternityWard.RankSalaries
{
    class DistributesFood: IWorker
    {
        public SqliteDbContext Db { set; get; }
        public string WorkerId { set; get; }

        public Junior Junior;
        public DistributesFood(SqliteDbContext db, string workerId)
        {
            this.Junior = new Junior(db, workerId);
            this.Db = db;
            this.WorkerId = WorkerId;
        }
        public float Calculate()
        {
            return this.Junior.Calculate(0);
        }

        public void AddToDb(float hourlyRate, float monthWorkHours, float monthActualWorkHours = 0)
        {
            this.Db.Workers.Add(new Worker { Id = this.WorkerId, WorkerType = this.GetType().Name });
            this.Db.HourlyRates.Add(new HourlyRate { Id = this.WorkerId, Value = hourlyRate });
            this.Db.MonthWorkHours.Add(new MonthWorkHours { WorkerId = this.WorkerId, Hours = monthWorkHours });
            this.Db.MonthActualWorkHours.Add(new MonthActualWorkHours { WorkerId = this.WorkerId, Hours = monthActualWorkHours });
            this.Db.SaveChanges();
        }
    }
}
