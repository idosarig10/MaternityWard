using MaternityWard.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MaternityWard.RankSalaries;

namespace MaternityWard.Workers
{
    class Pharmacists : IWorker
    {
        public SqliteDbContext Db { set; get; }
        public string WorkerId { get; }

        public Junior Junior;
        public Pharmacists(SqliteDbContext db, string workerId)
        {
            this.Junior = new Junior(db, workerId);
            this.Db = db;
            this.WorkerId = WorkerId;
        }
        public float Calculate()
        {
            return this.Junior.Calculate(0);
        }
    }
}
