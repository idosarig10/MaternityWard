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
        public string WorkerId { set; get; }
        public DecisionTaker(SqliteDbContext db, string workerId)
        {
            this.Db = db;
            this.WorkerId = workerId;
        }

        public float Calculate(float salary)
        {
            float monthWorkHours = this.Db.MonthWorkHours.Find(this.WorkerId).Hours;
            float monthActualWorkHours = this.Db.MonthActualWorkHours.Find(this.WorkerId).Hours;
            float monthMinimunWorkHours = this.Db.MonthMinimunWorkHours.Single(mmh => mmh.Rank == this.GetType().Name).Hours;
            float hourlyRate = this.Db.HourlyRates.Find(WorkerId).Value;
            float bonusPercentages = this.Db.Bonuses.Find(this.GetType().Name).BonusPercentage;
            float economyPrice = this.Db.HourlyRates.Find("Economy").Value;
            float hourlyRateAfterBonous = hourlyRate + (bonusPercentages / 100) * economyPrice;
            if (monthActualWorkHours < monthMinimunWorkHours)
            {
                return monthActualWorkHours * hourlyRateAfterBonous + salary;
            } else
            {
                return monthWorkHours * hourlyRateAfterBonous + salary;
            }
        }
    }
}
