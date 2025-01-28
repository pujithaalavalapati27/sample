using EmpBLL;
using EmpDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class index : System.Web.UI.Page
    {
        public employeeBLL empBLL;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                BindEmployeeList();
            }
        }
        private void BindEmployeeList()
        {
            empBLL = new employeeBLL();
            List<employeeDTO> employees = empBLL.GetAllJoinedEmployee();
            gvEmployees.DataSource = employees;
            gvEmployees.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            empBLL = new employeeBLL();
            employeeDTO newEmployee = new employeeDTO
            {
                Name = TextBox2.Text,
                Email = TextBox3.Text,
                Country = TextBox4.Text,
                ProjectID = Convert.ToInt32(TextBox5.Text),
                ManagerName = TextBox6.Text,
            };

            bool success = empBLL.AddEmployee(newEmployee);
            if (success)
            {
                BindEmployeeList();
            }
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            empBLL = new employeeBLL();

            int Id = Convert.ToInt32(TextBox1.Text);

            employeeDTO updatedEmployee = new employeeDTO
            {
                ID = Id,  
                Name = TextBox2.Text,
                Email = TextBox3.Text,
                Country = TextBox4.Text,
                ManagerName = TextBox6.Text,
            };

           
            bool success = empBLL.UpdateEmployee(updatedEmployee);

            if (success)
            {
                
                BindEmployeeList();
            }
            
        }
        protected void gvEmployees_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {

        }

        protected void gvEmployees_RowDeleting(object sender, System.Web.UI.WebControls.GridViewDeleteEventArgs e)
        {
            empBLL = new employeeBLL();
            int ID= Convert.ToInt32(gvEmployees.DataKeys[e.RowIndex].Value);
            empBLL.DeleteEmployee(ID);
            BindEmployeeList();
        }

     
    }
}