using System;

namespace MaternityWard
{
    class Program
    {
        static void Main(string[] args)
        {
             using (var db = new SqliteDbContext())
             {
                Worker worker = new Worker{HourlyWage=12, WorkerType="dsada", Id=Guid.NewGuid().ToString()};
                db.Add(worker);
                db.SaveChanges();
             }
        }
    }
}
