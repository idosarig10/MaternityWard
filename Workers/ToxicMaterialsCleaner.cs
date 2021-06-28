using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MaternityWard.Tables;

namespace MaternityWard.RankSalaries
{
    class ToxicMaterialsCleaner : IWorker
    {
        public Junior Junior;
        public DecisionTaker DecisionTaker;
        public Risk Risk;
        public Expert Expert;
        public SqliteDbContext Db { set; get; }
        public string WorkerId { set; get; }
        public ToxicMaterialsCleaner(SqliteDbContext db, string workerId)
        {
            this.Junior = new Junior(db, workerId);
            this.DecisionTaker = new DecisionTaker(db, workerId);
            this.Risk = new Risk(db, workerId);
            this.Expert = new Expert(db, workerId);
            this.Db = db;
            this.WorkerId = workerId;
        }
        public float Calculate()
        {
            return this.Risk.Calculate(this.Expert.Calculate(this.DecisionTaker.Calculate(this.Junior.Calculate(0))));
        }
        public void AddToDb(float hourlyRate, float monthWorkHours, float monthActualWorkHours = 0)
        {
            this.Db.Workers.Add(new Worker { Id = this.WorkerId, WorkerType = this.GetType().Name});
            this.Db.HourlyRates.Add(new HourlyRate { Id = this.WorkerId, Value = hourlyRate });
            this.Db.MonthWorkHours.Add(new MonthWorkHours { WorkerId = this.WorkerId, Hours = monthWorkHours });
            this.Db.MonthActualWorkHours.Add(new MonthActualWorkHours { WorkerId = this.WorkerId, Hours = monthActualWorkHours });
            this.Db.SaveChanges();
        }
    }
}