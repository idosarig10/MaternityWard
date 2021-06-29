using MaternityWard.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaternityWard.RankSalaries
{
    class InternshipDoctorBreech : IWorker
    {
        public SqliteDbContext Db { set; get; }
        public string WorkerId { get; }

        public Junior Junior { get; };
        public Expert Expert { get; };
        public InternshipDoctorBreech(SqliteDbContext db, string workerId)
        {
            this.Junior = new Junior(db, workerId);
            this.Expert = new Expert(db, workerId);
            this.Db = db;
            this.WorkerId = WorkerId;
        }
        public float Calculate()
        {
            return this.Expert.Calculate(this.Junior.Calculate(0));
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
