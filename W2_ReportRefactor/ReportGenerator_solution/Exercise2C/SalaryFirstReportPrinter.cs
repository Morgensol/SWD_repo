using System;
using System.Collections.Generic;

namespace Exercise2C
{
    class SalaryFirstReportPrinter : ReportPrinter
    {
        public void PrintReport(List<Employee> employeeList)
        {
            Console.WriteLine("Salary-first report");
            foreach (var e in employeeList)
            {
                Console.WriteLine("------------------");
                Console.WriteLine("Salary: {0}", e.Salary);
                Console.WriteLine("Name: {0}", e.Name);
                Console.WriteLine("Age: {0}", e.Age);
                Console.WriteLine("------------------");
            }
        }
    }
}
