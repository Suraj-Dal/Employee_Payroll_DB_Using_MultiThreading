using System.Collections.Generic;
using AutoMapper;
using EmployeePayroll;
namespace EmployeePayrollTest
{
    public class Tests
    {
        [Test]
        public void GivenListOfMultipleEmployee_AddIntoDataBase_TestTimeWithout_MutltiThreading()
        {
            List<EmployeeProfile> employeeProfiles = new List<EmployeeProfile>();
            employeeProfiles.Add(new EmployeeProfile(id: 10, name: "Kiran", salary: 21000, dateTime: DateTime.Now, gender: "M", phone: 9876538274, address: "Pune", dept: "IT", basicPay: 21000, deductions: 1200, taxablePay: 1000, incomeTax: 2100, netPay:19000));
            employeeProfiles.Add(new EmployeeProfile(id: 11, name: "Hrishikesh", salary: 23000, dateTime: DateTime.Now, gender: "M", phone: 9973758748, address: "Pune", dept: "Sales", basicPay: 23000, deductions: 1400, taxablePay: 1300, incomeTax: 2300, netPay: 21000));
            employeeProfiles.Add(new EmployeeProfile(id: 12, name: "Vrinda", salary: 24000, dateTime: DateTime.Now, gender: "F", phone: 9674558768, address: "Delhi", dept: "Marketing", basicPay: 24000, deductions: 1500, taxablePay: 1400, incomeTax: 2400, netPay: 22000));
            employeeProfiles.Add(new EmployeeProfile(id: 13, name: "Laxmi", salary: 25000, dateTime: DateTime.Now, gender: "F", phone: 987674325, address: "Bangalore", dept: "IT", basicPay: 25000, deductions: 1600, taxablePay: 1500, incomeTax: 2500, netPay: 23000));

            PayrollSystem payroll = new PayrollSystem();
            DateTime startTime = DateTime.Now;
            payroll.addEmployee(employeeProfiles);
            DateTime endTime = DateTime.Now;
            Console.WriteLine("Time required to add multiple employees without using Thread: "+ (endTime - startTime));
        }
    }
}