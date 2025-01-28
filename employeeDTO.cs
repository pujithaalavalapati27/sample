using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpDTO
{
    public class employeeDTO
    {
        public int ID{ get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Country{ get; set; }
        public int ProjectID {  get; set; }
        public string ManagerName {  get; set; }
        public string Employee_Role {  get; set; }
        public int Employee_Salary {  get; set; }

    }
}
