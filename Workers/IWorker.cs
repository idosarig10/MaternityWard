using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MaternityWard.RankSalaries;

namespace MaternityWard.Workers
{

    interface IWorker
    {
        public SqliteDbContext Db { set; get; }
        public string WorkerId { get; }
        public float Calculate();
    }
}
