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
        public string WorkerId { get; }
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
    }
}