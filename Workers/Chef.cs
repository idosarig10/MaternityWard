using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MaternityWard.Tables;

namespace MaternityWard.RankSalaries
{
    class Chef : IWorker
    {
        public Senior Senior { get; }
        public DecisionTaker DecisionTaker { get; }
        public Expert Expert { get; }
        public SqliteDbContext Db { set; get; }
        public string WorkerId { get; }
        public Chef(SqliteDbContext db, string workerId)
        {
            this.Senior = new Senior(db, workerId);
            this.Db = db;
            this.WorkerId = workerId;
        }
        public float Calculate()
        {
            return this.Expert.Calculate(this.DecisionTaker.Calculate(this.Senior.Calculate(0)));
        }
    }
}