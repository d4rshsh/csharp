using BusinessLogicLayerLib;
using DataAccessLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HelperLib
{
    public class EmployeeHelper
    {
        Employee_DAL dal = null;
        public EmployeeHelper()
        {
            dal = new Employee_DAL();
        }


        public bool AddEmployee(Employee_BAL employee)
        {
            return dal.InsertEmployee(employee);

        }


        public bool EditEmployee(Employee_BAL employee)
        {
            return dal.UpdateEmployee(employee);
        }
        public bool RemoveEmployee(int empid)
        {
            return dal.DeleteEmployee(empid);
        }
        public Employee_BAL SearchEmployee(int empid)
        {
            return dal.FindEmployee(empid);
        }

        public void SearchEmployee(int empid, out Employee_BAL empdata)
        {

            dal.FindEmployee(empid, out empdata);


        }

        public int countEmployees()
        {
            return dal.EmployeeCount();

        }


        public List<Employee_BAL> ShowEmployeeList()
        {
            return dal.EmployeeList();
        }
    }
}

