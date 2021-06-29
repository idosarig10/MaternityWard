using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MaternityWard.RankSalaries;

namespace MaternityWard.Workers
{
    class DeputyHeadOfDepartment : IWorker
    {
        public DecisionTaker DecisionTaker;
        public Manager Manager;
        public SqliteDbContext Db { set; get; }
        public string WorkerId { get; }
        public DeputyHeadOfDepartment(SqliteDbContext db, string workerId)
        {
            this.DecisionTaker = new DecisionTaker(db, workerId);
            this.Manager = new Manager(db, workerId);
            this.Db = db;
            this.WorkerId = workerId;
        }
        public float Calculate()
        {
            return this.Manager.Calculate(this.DecisionTaker.Calculate(0));
        }
    }
}