using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaternityWard.RankSalaries
{

    interface IWorker
    {
        public SqliteDbContext Db { set; get; }
        public string WorkerId { set; get; }
        public float Calculate();
    }
}
