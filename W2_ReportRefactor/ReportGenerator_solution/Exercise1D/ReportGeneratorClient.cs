using System;

namespace Exercise1D
{
    internal class ReportGeneratorClient
    {
        private static void Main()
        {
            var db = new EmployeeDB();

            // Add some employees
            db.AddEmployee(new Employee("Anne", 3000));
            db.AddEmployee(new Employee("Berit", 2000));
            db.AddEmployee(new Employee("Christel", 1000));

            var reportGenerator = new ReportGenerator(db);

            // Create a default (name-first) report
            ReportPrinter printer = new NameFirstReportPrinter();
            reportGenerator.CompileReport(printer);

            Console.WriteLine("");
            Console.WriteLine("");

            // Create a salary-first report
            printer = new SalaryFirstReportPrinter();
            reportGenerator.CompileReport(printer);
        }
    }
}