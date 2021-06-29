using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MaternityWard.Tables;
using MaternityWard.RankSalaries;

namespace MaternityWard.Workers
{
    class SeniorDoctor : IWorker
    {
        public Senior Senior { get; }
        public Expert Expert { get; }

        public SqliteDbContext Db { set; get; }
        public string WorkerId { get; }
        public SeniorDoctor(SqliteDbContext db, string workerId)
        {
            this.Senior = new Senior(db, workerId);
            this.Expert = new Expert(db, workerId);
            this.Db = db;
            this.WorkerId = workerId;
        }
        public float Calculate()
        {
            return this.Expert.Calculate(this.Senior.Calculate(0));
        }
    }
}