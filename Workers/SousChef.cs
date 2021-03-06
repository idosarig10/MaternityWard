using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MaternityWard.Tables;
using MaternityWard.RankSalaries;

namespace MaternityWard.Workers
{
    class SousChef : IWorker
    {
        public Senior Senior { get; }
        public Expert Expert { get; }
        public SqliteDbContext Db { set; get; }
        public string WorkerId { get; }
        public SousChef(SqliteDbContext db, string workerId)
        {
            this.Senior = new Senior(db, workerId);
            this.Db = db;
            this.WorkerId = workerId;
        }
        public float Calculate()
        {
            return this.Senior.Calculate(0);
        }
    }
}