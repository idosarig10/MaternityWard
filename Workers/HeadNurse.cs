using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MaternityWard.Tables;
using MaternityWard.RankSalaries;

namespace MaternityWard.Workers
{
    class HeadNurse : IWorker
    {
        public Senior Senior { get; }
        public DecisionTaker DecisionTaker { get; }
        public SqliteDbContext Db { set; get; }
        public string WorkerId { get; }
        public HeadNurse(SqliteDbContext db, string workerId)
        {
            this.DecisionTaker = new DecisionTaker(db, WorkerId);
            this.Senior = new Senior(db, workerId);
            this.Db = db;
            this.WorkerId = workerId;
        }
        public float Calculate()
        {
            return this.DecisionTaker.Calculate(this.Senior.Calculate(0));
        }
    }
}