using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaternityWard.RankSalaries
{
    class Senior: ISalary
    {
        public SqliteDbContext Db { set; get; }
        public Guid WorkerId { set; get; }
        public Senior(SqliteDbContext db, Guid workerId)
        {
            this.Db = db;
            this.WorkerId = workerId;
        }

        public float Calculate(float salary)
        {
            float hourlyWage = this.Db.Workers.Find(WorkerId).HourlyWage;
            float bonusPercentages = this.Db.RankBonuses.Find(this.GetType().Name).BonusPercentages;
            float economeyPrice = this.Db.Prices.Find("Economy").PriceValue;
            float workTimeHours = this.Db.WorkTimes.Find(this.WorkerId).Hours;
            return (workTimeHours * (hourlyWage + (economeyPrice * bonusPercentages))) + salary;
        }
    }
}
