using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmloyeeInformation
{
    public partial class EmployeeInformationUi : Form
    {
        Employee aEmployee = new Employee();

        public EmployeeInformationUi()
        {
            InitializeComponent();
        }

   

        private void employeeRetrieveButton_Click(object sender, EventArgs e)
        {

            employeeIdTextBox.Text = aEmployee.id;
            employeeNameTextBox.Text = aEmployee.name;
            employeeSalaryTextBox.Text = aEmployee.salary.ToString();
        }

        private void employeeInformatioShowButton_Click(object sender, EventArgs e)
        {
           

            aEmployee.id = employeeIdTextBox.Text;
            aEmployee.name = employeeNameTextBox.Text;
            aEmployee.salary = double.Parse(employeeSalaryTextBox.Text);
            GetTextBoxesClear();

            MessageBox.Show("Mr."+aEmployee.GetEmployeeName()+", your id is "+aEmployee.id+" and your salary is "+aEmployee.GetEmployeeSalary());

        }

        private void GetTextBoxesClear()
        {
            employeeIdTextBox.Text = "";
            employeeNameTextBox.Text = "";
            employeeSalaryTextBox.Text = "";
        }
    }
}
