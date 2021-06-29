using System;
using System.Linq;
using System.Reflection;
using MaternityWard.RankSalaries;
using MaternityWard.Tables;
namespace MaternityWard
{
    class Program
    {
        static void Main(string[] args)
        {
             using (var db = new SqliteDbContext())
             {

                Assembly assembly = Assembly.GetExecutingAssembly();
                ConsoleApplicationInterface.AddWorker(db, assembly);
                //Guid x = new Guid("6798c85d-9ba1-44a4-92b2-6be8a4a26aa5");
                //Senior senior = new Senior(db, x);
                //Worker worker = new Worker{ Id=x, HourlyWage=40, WorkerType="Cleaner"};
                //db.Add(worker);
                //db.SaveChanges();
                //Console.WriteLine(senior.Calculate(0));
                //ToxicMaterialsCleaner toxicMaterialsCleaner = new ToxicMaterialsCleaner(db, "Mr. ToxicMaterialsCleaner");
                //var c = toxicMaterialsCleaner.Calculate();

            };
        }
    }
}
