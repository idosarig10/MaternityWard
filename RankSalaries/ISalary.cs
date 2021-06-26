using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaternityWard.RankSalaries
{
    interface ISalary
    {
        public SqliteDbContext Db { set; get; }
        public Guid WorkerId { set; get; }
        public float Calculate(float salary);
    }
}
