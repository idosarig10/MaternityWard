using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaternityWard.RankSalaries
{
    class Cleaner: IWorker
    {
        public Junior Junior;
        public Cleaner(SqliteDbContext db, string workerId)
        {
            this.Junior = new Junior(db, workerId);
        }
        public float Calculate()
        {
            return this.Junior.Calculate(0);
        }
    }
}
