using System;
using Services;

namespace DecouplingCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var dependency = new DependencyResolutions.SqlQueryReturn().ResolveDependency(Settings.Default.Location);
            string SQLQuery = new SqlQueryService(dependency).ReturnSqlQuey();
            Console.WriteLine(SQLQuery);
            Console.ReadLine();
        }
    }
}
