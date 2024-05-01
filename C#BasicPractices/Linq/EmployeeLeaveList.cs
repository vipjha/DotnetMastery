using System;
using System.ComponentModel.DataAnnotations;
using Linq;

namespace Linq
{
    public class EmployeeLeaveList
    {
        List<Employee> employeeList = new List<Employee>
        {
            new Employee {Id =1, Name = "Vipin",  Degination= "Software Engg"},
            new Employee {Id =2, Name = "Vipin1",  Degination= "Software Engg"},
            new Employee {Id =3, Name = "Vipin2",  Degination= "Software Engg"},
            new Employee {Id =4, Name = "Vipin3",  Degination= "Software Engg"},
        };
        List<EmpLeave> empList = new List<EmpLeave>
        {
            new EmpLeave {LeaveId =1, LeaveType = "CL",  LeaveDate= DateTime.Parse("2024-03-05"), EmpId = 1},
            new EmpLeave {LeaveId =2, LeaveType = "CL",  LeaveDate= DateTime.Parse("2024-04-05"), EmpId = 2},
            new EmpLeave {LeaveId =3, LeaveType = "FL",  LeaveDate= DateTime.Parse("2024-02-05"), EmpId = 2},
            new EmpLeave {LeaveId =4, LeaveType = "HL",  LeaveDate= DateTime.Parse("2024-04-05"), EmpId = 3},
        };

        public void GetEmployeeLeaveList()
        {
            DateTime startDate = new DateTime(2024, 3, 1);
            DateTime endDate = new DateTime(2024, 4, 30);

            var employeesTakingLeave = empList.Where(leave => leave.LeaveDate >= startDate && leave.LeaveDate <= endDate)
                .Join(employeeList, leave => leave.EmpId,emp => emp.Id,(leave, emp) => emp).Distinct().ToList();


            var employeesWithLeave = (from emp in employeeList
                                      join leave in empList on emp.Id equals leave.EmpId
                                      where leave.LeaveType == "CL" &&
                                            leave.LeaveDate.Day >= 3 && leave.LeaveDate.Day <= 4
                                      select emp).Distinct();

            

            Console.WriteLine("Employees who took leave between March and April:");
            foreach (var employee in employeesTakingLeave)
            {
                Console.WriteLine("ID: {0}, Name: {1}, Designation: {2}", employee.Id, employee.Name, employee.Degination);
            }
        }
    }
}
