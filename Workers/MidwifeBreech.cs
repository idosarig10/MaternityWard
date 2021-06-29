using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MaternityWard.Tables;
using MaternityWard.RankSalaries;

namespace MaternityWard.Workers
{
    class MidwifeBreech : IWorker
    {
        public Expert Expert { get; }
        public SqliteDbContext Db { set; get; }
        public string WorkerId { get; }
        public MidwifeBreech(SqliteDbContext db, string workerId)
        {
            this.Expert = new Expert(db, workerId);
            this.Db = db;
            this.WorkerId = workerId;
        }
        public float Calculate()
        {
            return this.Expert.Calculate(0);
        }
    }
}