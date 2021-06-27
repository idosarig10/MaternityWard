using MaternityWard.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaternityWard.RankSalaries
{
    class Expert : ISalary
    {
        public SqliteDbContext Db { set; get; }
        public Guid WorkerId { set; get; }
        public Expert(SqliteDbContext db, Guid workerId)
        {
            this.Db = db;
            this.WorkerId = workerId;
        }

        public float Calculate(float salary)
        {
            float hourlyWage = this.Db.Workers.Find(WorkerId).HourlyWage;
            RankBonus rankBonus = this.Db.RankBonuses.Find(this.GetType().Name);
            float bonusPercentages = rankBonus.BonusPercentages;
            float price = this.Db.Prices.Find(rankBonus.Rank).PriceValue;
            float workTimeHours = this.Db.WorkTimes.Find(this.WorkerId).Hours;
            return (workTimeHours * (hourlyWage + (price * bonusPercentages))) + salary;
        }
    }
}
