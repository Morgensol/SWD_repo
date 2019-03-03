using System;

namespace Exercise2C
{
    internal class ReportGeneratorClient
    {
        private static void Main()
        {
            var db = new EmployeeDB();

            // Add some employees
            db.AddEmployee(new Employee("Anne", 3000, 25));
            db.AddEmployee(new Employee("Berit", 2000, 35));
            db.AddEmployee(new Employee("Christel", 1000, 45));

            var reportGenerator = new ReportGenerator(db);

            // Create a default (name-first) report
            ReportPrinter printer = new NameFirstReportPrinter();
            reportGenerator.CompileReport(printer);

            Console.WriteLine("");
            Console.WriteLine("");

            // Create a salary-first report
            printer = new SalaryFirstReportPrinter();
            reportGenerator.CompileReport(printer);

            Console.WriteLine("");
            Console.WriteLine("");

            printer = new AgeFirstReportPrinter();
            reportGenerator.CompileReport(printer);
        }
    }
}