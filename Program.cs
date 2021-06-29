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
                string command;
                while (true)
                {
                    Console.WriteLine("what whould you like to do?");
                    Console.WriteLine("1. add worker");
                    Console.WriteLine("2. report worker work time");
                    Console.WriteLine("3. calculate worker salary");
                    Console.WriteLine("everything else to exit");
                    command = Console.ReadLine();
                    switch (command)
                    {
                        case "1":
                            ConsoleApplicationInterface.AddWorker(db, assembly);
                            break;
                        case "2":
                            ConsoleApplicationInterface.AddWorkTime(db);
                            break;
                        case "3":
                            ConsoleApplicationInterface.CalculateSalary(db, assembly);
                            break;
                        default:
                            return;
                    }
                }
            };
        }
    }
}
