using System;
using System.Collections.Generic;
using ReportGenerator.Refactor;

namespace ReportGenerator
{
    internal class ReportGenerator
    {
        private readonly EmployeeDB _employeeDb;


        public ReportGenerator(EmployeeDB employeeDb)
        {
            if (employeeDb == null) throw new ArgumentNullException("employeeDb");
            _employeeDb = employeeDb;
        }


        public void CompileReport(ReportPrinter format)
        {
            var employees = new List<Employee>();
            Employee employee;

            _employeeDb.Reset();

            // Get all employees
            while ((employee = _employeeDb.GetNextEmployee()) != null)
            {
                employees.Add(employee);
            }

            // All employees collected - let's output them
            format.PrintReport(employees);
        }
    }
}