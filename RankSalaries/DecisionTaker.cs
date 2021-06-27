using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MaternityWard.Tables;

namespace MaternityWard.RankSalaries
{
    class DecisionTaker : ISalary
    {
        public SqliteDbContext Db { set; get; }
        public Guid WorkerId { set; get; }
        public DecisionTaker(SqliteDbContext db, Guid workerId)
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
            float minimunMonthHours = this.Db.MinimunMonthHours.Find(this.WorkerId.ToString()).Hours;
            return (workTimeHours > minimunMonthHours ? 200 : 0 * (hourlyWage + (price * bonusPercentages))) + salary;
        }
    }
}
