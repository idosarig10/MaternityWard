using MaternityWard.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaternityWard.RankSalaries
{
    class Risk : ISalary
    {
        public SqliteDbContext Db { set; get; }
        public string WorkerId { set; get; }
        public Risk(SqliteDbContext db, string workerId)
        {
            this.Db = db;
            this.WorkerId = workerId;
        }

        public float Calculate(float salary)
        {
            string workerType = this.Db.Workers.Find(this.WorkerId).WorkerType;
            float riskBonous = this.Db.Bonuses.Find(w   ).BonusPercentage;
            salary += (riskBonous / 100) * salary;
            return salary;
        }
    }
}
