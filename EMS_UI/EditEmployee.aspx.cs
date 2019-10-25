using EMS_DAL;
using EMS_DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EMS_UI
{
    public partial class EditEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownListDepartment.DataSource = DAL.GetDepartments();
                DropDownListDepartment.DataBind();
               
                DropDownListManager.DataSource = DAL.GetEmployeeIdAndName();
                DropDownListManager.DataBind();
                DropDownListManager.Items.Add(new ListItem("--Select--","0"));
                DropDownListManager.SelectedValue = "0";

                RangeValidator2.MaximumValue = DateTime.Now.ToShortDateString();
                RangeValidator2.MinimumValue = DateTime.Now.AddYears(-100).ToShortDateString();
            }
        }

        protected void ButtonGetEmpID_Click(object sender, EventArgs e)
        {
            DataSet employee = DAL.GetEmployeeById(Convert.ToInt32(TextBoxEmpID.Text));

            if (employee.Tables[0].Rows.Count==0)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Employee does not exist');", true);
            }
            else
            {
                DataRow empRow = employee.Tables[0].Rows[0];
                TextBoxName.Text = empRow["name"].ToString();
                TextBoxEmail.Text= empRow["email"].ToString();
                RadioButtonListGender.SelectedValue= empRow["gender"].ToString();
                DropDownListDepartment.SelectedValue = empRow["departmentno"].ToString();
                TextBoxDateOfBirth.Text= Convert.ToDateTime(empRow["dateofbirth"]).ToString("yyyy-MM-dd");
                TextBoxDateOfJoining.Text= Convert.ToDateTime(empRow["dateofjoining"]).ToString("yyyy-MM-dd");
                if (!string.IsNullOrEmpty(empRow["reportingto"].ToString()))
                {
                    DropDownListManager.SelectedValue = empRow["reportingto"].ToString();
                }
                TextBoxPhone.Text= empRow["phone"].ToString();
                TextBoxSalary.Text=string.Format("{0:0}", empRow["salary"]);
                TextBoxCommission.Text= string.Format("{0:0}", empRow["commission"]);
                DropDownListJobtitle.SelectedItem.Text= empRow["jobtitle"].ToString();
            }
        }

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee
            {
                Number = Convert.ToInt32(TextBoxEmpID.Text),
                name = TextBoxName.Text,
                email = TextBoxEmail.Text,
                gender = RadioButtonListGender.SelectedItem.Text,
                departmentno = Convert.ToInt32(DropDownListDepartment.SelectedItem.Value),
                dateofbirth = Convert.ToDateTime(TextBoxDateOfBirth.Text),
                dateofjoining = Convert.ToDateTime(TextBoxDateOfJoining.Text),
                reportingto = Convert.ToInt32(DropDownListManager.SelectedItem.Value),
                phone = Convert.ToInt64(TextBoxPhone.Text),
                salary = Convert.ToInt32(TextBoxSalary.Text),
                commission = Convert.ToInt32(TextBoxCommission.Text),
                jobtitle = DropDownListJobtitle.SelectedItem.Text
            };
            bool result = DAL.UpdateEmployee(employee);
            if (result)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "redirect", "alert('employee updated successfully');window.location='EmployeeList.aspx';", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('failled to update employee');", true);
            }
        }
    }
}