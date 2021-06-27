using MaternityWard.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaternityWard.RankSalaries
{
    class Senior: ISalary
    {
        public SqliteDbContext Db { set; get; }
        public string WorkerId { set; get; }
        public Senior(SqliteDbContext db, string workerId)
        {
            this.Db = db;
            this.WorkerId = workerId;
        }

        public float Calculate(float salary)
        {
            float hourlyRate = this.Db.HourlyRates.Find(WorkerId).Value;
            float bonusPercentages = this.Db.Bonuses.Find(this.GetType().Name).BonusPercentage;
            float economyPrice = this.Db.HourlyRates.Find("economy").Value;
            float monthActualWorkHours = this.Db.MonthActualWorkHours.Find(this.WorkerId).Hours;
            float hourlyRateAfterBonous = hourlyRate + (bonusPercentages / 100) * economyPrice;
            return monthActualWorkHours * hourlyRateAfterBonous + salary;
        }
    }
}
