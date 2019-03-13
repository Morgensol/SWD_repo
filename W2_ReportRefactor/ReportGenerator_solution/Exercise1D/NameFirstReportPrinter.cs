using System;
using System.Collections.Generic;

namespace Exercise1D
{
    class NameFirstReportPrinter : ReportPrinter
    {
        public void PrintReport(List<Employee> employeeList)
        {
            Console.WriteLine("Name-first report");
            foreach (var e in employeeList)
            {
                Console.WriteLine("------------------");
                Console.WriteLine("Name: {0}", e.Name);
                Console.WriteLine("Salary: {0}", e.Salary);
                Console.WriteLine("------------------");
            }
        }
    }
}
