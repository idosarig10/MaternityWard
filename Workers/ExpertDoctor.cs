using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MaternityWard.Tables;

namespace MaternityWard.RankSalaries
{
    class ExpertDoctor : IWorker
    {
        public Senior Senior;
        public Expert Expert;
        public DecisionTaker DecisionTaker { get; }
        public SqliteDbContext Db { set; get; }
        public string WorkerId { get; }
        public ExpertDoctor(SqliteDbContext db, string workerId)
        {
            this.DecisionTaker = new DecisionTaker(db, workerId);
            this.Senior = new Senior(db, workerId);
            this.Expert = new Expert(db, workerId);
            this.Db = db;
            this.WorkerId = workerId;
        }
        public float Calculate()
        {
            return this.Expert.Calculate(this.Senior.Calculate(this.DecisionTaker.Calculate(0)));
        }
    }
}