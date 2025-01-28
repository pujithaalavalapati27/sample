using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpDTO;
using EmpDLL;

namespace EmpBLL
{
    public class employeeBLL
    {
        private employeeDLL employeeDAL = new employeeDLL();

        public List<employeeDTO> GetAllEmployees()
        {
            return employeeDAL.GetAllEmployees();
        }
        public List<employeeDTO> GetAllJoinedEmployee()
        {
            return employeeDAL.GetAllJoinedEmployee();
        }
        public employeeDTO GetEmployeeById(int id)
        {
            return employeeDAL.GetEmployeeById(id);
        }

        public bool AddEmployee(employeeDTO employee)
        {
            return employeeDAL.AddEmployee(employee);
        }

        public bool UpdateEmployee(employeeDTO employee)
        {
            return employeeDAL.UpdateEmployee(employee);
        }

        public bool DeleteEmployee(int id)
        {
            return employeeDAL.DeleteEmployee(id);
        }
    }
}
