using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MaternityWard.RankSalaries;

namespace MaternityWard.Workers
{
    class CleanersShiftManager : IWorker
    {
        public DecisionTaker DecisionTaker { get; }
        public SqliteDbContext Db { set; get; }
        public string WorkerId { get; }
        public CleanersShiftManager(SqliteDbContext db, string workerId)
        {
            this.DecisionTaker = new DecisionTaker(db, workerId);
            this.Db = db;
            this.WorkerId = workerId;
        }
        public float Calculate()
        {
            return this.DecisionTaker.Calculate(0);
        }
    }
}