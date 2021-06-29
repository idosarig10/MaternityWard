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
                ConsoleApplicationInterface.CalculateSalary(db, assembly);
                //while (true)
                //{ 
                
                //}
            };
        }
    }
}
