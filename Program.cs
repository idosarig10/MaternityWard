using System;

namespace MaternityWard
{
    class Program
    {
        static void Main(string[] args)
        {
             using (var db = new SqliteDbContext())
             {
                 Worker workerTable = new Worker{hourlyWage=12, workerType="dsada", Id="ddas"};
                 db.Add(workerTable);
                 db.SaveChanges();
             }
        }
    }
}
