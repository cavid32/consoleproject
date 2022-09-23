using CSharpProect.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProect.Interfaces
{
    interface IHumanResourceManager
    {
        //public Department[] Departments();
        public void AddDepartment(string name, int workerlimit, double salarylimit);
        public Department[] GetDepartments();
        public Department EditDepartment(string oldname, string newname);
        public void AddEmployee(string name, string position,double salary,string departmentname);
        public void RemoveEmployee(int no,string departmentname);
        public Employee EditEmployee(string departmentname, int no, string fullname, double salary, string position);


    }
}
