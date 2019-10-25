using EMS_DAL;
using EMS_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EMS_UI
{
    public partial class AddEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                DropDownListDepartment.DataSource = DAL.GetDepartments();
                DropDownListDepartment.DataBind();
                DropDownListManager.DataSource = DAL.GetEmployeeIdAndName();
                DropDownListManager.DataBind();

                RangeValidator2.MaximumValue = DateTime.Now.ToShortDateString();
                RangeValidator2.MinimumValue = DateTime.Now.AddYears(-100).ToShortDateString();
            }
        }

        protected void ButtonCreate_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee
            {
                name = TextBoxName.Text,
                email = TextBoxEmail.Text,
                gender = RadioButtonListGender.SelectedItem.Text,
                departmentno = Convert.ToInt32(DropDownListDepartment.SelectedItem.Value),
                dateofbirth = Convert.ToDateTime(TextBoxDateOfBirth.Text),
                dateofjoining= Convert.ToDateTime(TextBoxDateOfJoining.Text),
                reportingto=  Convert.ToInt32(DropDownListManager.SelectedItem.Value),
                phone=Convert.ToInt64(TextBoxPhone.Text),
                salary= Convert.ToInt32(TextBoxSalary.Text),
                commission= Convert.ToInt32(TextBoxCommission.Text),
                jobtitle=DropDownListJobtitle.SelectedItem.Text
            };
            bool result=DAL.AddEmployee(employee);
            if(result)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "redirect", "alert('employee added successfully');window.location='EmployeeList.aspx';",true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('failled to add employee');", true);
            }
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}