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
        public string WorkerId { set; get; }
        public Expert(SqliteDbContext db, string workerId)
        {
            this.Db = db;
            this.WorkerId = workerId;
        }

        public float Calculate(float salary)
        {
            float hourlyRate = this.Db.HourlyRates.Find(WorkerId).Value;
            float bonusPercentages = this.Db.Bonuses.Find(this.GetType().Name).BonusPercentage;
            float lawPrice = this.Db.HourlyRates.Find("Law").Value;
            float monthActualWorkHours = this.Db.MonthActualWorkHours.Find(this.WorkerId).Hours;
            float hourlyRateAfterBonous = hourlyRate + (bonusPercentages / 100) * lawPrice;
            return monthActualWorkHours * hourlyRateAfterBonous + salary;
        }
    }
}
