using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaternityWard.RankSalaries
{
    class ToxicMaterialsCleaner : IWorker
    {
        public Junior Junior;
        public DecisionTaker DecisionTaker;
        public Risk Risk;

        public ToxicMaterialsCleaner(SqliteDbContext db, string workerId)
        {
            this.Junior = new Junior(db, workerId);
            this.DecisionTaker = new DecisionTaker(db, workerId);
            this.Risk = new Risk(db, workerId);
        }
        public float Calculate()
        {
            return this.Risk.Calculate(this.DecisionTaker.Calculate(this.Junior.Calculate(0)));
        }
    }
}
