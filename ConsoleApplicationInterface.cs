using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using MaternityWard.Tables;
using System.Reflection;
using System.Linq;
using MaternityWard.Workers;

namespace MaternityWard
{
    static class ConsoleApplicationInterface
    {
        public static void AddWorker(SqliteDbContext db, Assembly assembly)
        {
            Console.WriteLine("Enter worker Id:");
            string workerId = Console.ReadLine();
            Console.WriteLine("Enter worker hourlyRate:");
            float hourlyRate = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter how much hours the worker work in month:");
            float monthWorkHours = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter how much hours the worker actually work in so far this month:");
            float monthActualWorkHours = float.Parse(Console.ReadLine());
            Console.WriteLine("Choose worker type:");
            System.Type[] workersTypes = assembly.GetTypes().Where(t => String.Equals(t.Namespace, "MaternityWard.Workers", StringComparison.Ordinal)).ToArray();
            for (int i = 0; i < workersTypes.Length; i++)
            {
                Console.WriteLine(i.ToString() + ". " + workersTypes[i].Name) ;
            }
            int workerTypeIndex = int.Parse(Console.ReadLine());
            string workerType = workersTypes[workerTypeIndex].Name;
            db.Workers.Add(new Worker { Id = workerId, WorkerType = workerType });
            db.HourlyRates.Add(new HourlyRate { Id = workerId, Value = hourlyRate });
            db.MonthWorkHours.Add(new MonthWorkHours { WorkerId = workerId, Hours = monthWorkHours });
            db.MonthActualWorkHours.Add(new MonthActualWorkHours { WorkerId = workerId, Hours = monthActualWorkHours });
            db.SaveChanges();
            Console.WriteLine("Done");
        }


        public static void AddWorkTime(SqliteDbContext db)
        {
            Console.WriteLine("Choose worker Id:");
            List<string> workersIds = db.Workers.Select(worker => worker.Id).ToList();
            for (int i = 0; i < workersIds.Count; i++)
            {
                Console.WriteLine(i.ToString() + ". " + workersIds[i]);
            }
            int workerIdIndex = int.Parse(Console.ReadLine());
            string workerId = workersIds[workerIdIndex];
            Console.WriteLine("Enter start time:");
            DateTime startTime = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter end time:");
            DateTime endTime = DateTime.Parse(Console.ReadLine());
            float duration = (float)(endTime - startTime).TotalHours;
            MonthActualWorkHours monthActualWorkHours = db.MonthActualWorkHours.Find(workerId);
            monthActualWorkHours.Hours += duration;
            db.SaveChanges();
            Console.WriteLine("Done");
        }

        public static void CalculateSalary(SqliteDbContext db, Assembly assembly)
        {
            Console.WriteLine("Choose worker Id:");
            List<Worker> workers = db.Workers.ToList();
            for (int i = 0; i < workers.Count; i++)
            {
                Console.WriteLine(i.ToString() + ". " + workers[i].Id);
            }
            int workerIdIndex = int.Parse(Console.ReadLine());
            Worker worker = workers[workerIdIndex];
            System.Type workerTypeClass = assembly.GetTypes().First(t => String.Equals(t.Namespace, "MaternityWard.Workers", StringComparison.Ordinal) && t.Name.Equals(worker.WorkerType));
            IWorker workerInstance = (IWorker)Activator.CreateInstance(workerTypeClass, db, worker.Id);
            Console.WriteLine(workerInstance.Calculate());
        }
    }
}
