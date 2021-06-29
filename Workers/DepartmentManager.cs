using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MaternityWard.Tables;

namespace MaternityWard.RankSalaries
{
    class DepartmentManager : IWorker
    {
        public DecisionTaker DecisionTaker;
        public Manager Manager;
        public Risk Risk;
        public SqliteDbContext Db { set; get; }
        public string WorkerId { set; get; }
        public DepartmentManager(SqliteDbContext db, string workerId)
        {
            this.DecisionTaker = new DecisionTaker(db, workerId);
            this.Manager = new Manager(db, workerId);
            this.Risk = new Risk(db, workerId);
            this.Db = db;
            this.WorkerId = workerId;
        }
        public float Calculate()
        {
            return this.Risk.Calculate(this.Manager.Calculate(this.DecisionTaker.Calculate(0)));
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