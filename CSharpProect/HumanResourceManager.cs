using CSharpProect.Interfaces;
using CSharpProect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpProect
{
    class HumanResourceManager : IHumanResourceManager

    {
        public void AddDepartment(string name, int workerlimit, double salarylimit)
        {
            Department department = new Department();
            department.Name = name;
            department.WorkerLimit = workerlimit;
            department.SalaryLimit = salarylimit;

            Department.AllDepartment = (Department[])Department.AllDepartment.Concat(new Department[] { department });
        }

        public void AddEmployee(string name, string position, double salary, string departmentname)
        {
            throw new NotImplementedException();
        }

        public Department EditDepartment(string oldname, string newname)
        {
            throw new NotImplementedException();
        }

        public Employee EditEmployee(string departmentname, int no, string fullname, double salary, string position)
        {
            throw new NotImplementedException();
        }

        public Department[] GetDepartments()
        {
            throw new NotImplementedException();
        }

        public void RemoveEmployee(int no, string departmentname)
        {
            throw new NotImplementedException();
        }
    }
}
