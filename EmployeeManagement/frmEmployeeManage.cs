namespace EmployeeManagement
{
    public partial class frmEmployeeManage : Form
    {
        public frmEmployeeManage()
        {
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {   //check to see if any fields were left empty
            if (string.IsNullOrEmpty(tbID.Text) | string.IsNullOrEmpty(tbName.Text) | string.IsNullOrEmpty(tbEmail.Text) | string.IsNullOrEmpty(tbPhone.Text)| string.IsNullOrEmpty(tbAddress.Text) | string.IsNullOrEmpty(tbPosition.Text) | string.IsNullOrEmpty(tbSalary.Text))
            {
                
                    MessageBox.Show("Please ensure no fields are left empty!");
               
            }
            else
            {   //Check if employee id is not an integer
                if (!int.TryParse(tbID.Text, out _))
                {   //if it is not an integer show a message
                    MessageBox.Show("Employee ID must only contain numbers!" + Environment.NewLine + " Cannot be used");                    
                }
                else {  //if it is check the salary field as well
                    if (!int.TryParse(tbSalary.Text, out _))
                    {   // if the salary is not a number display a message
                        MessageBox.Show("Employee Salary must only contain numbers!" + Environment.NewLine + " Cannot be used");
                    }
                    else { 
                        //if all checks are passed add the employee to the list

                        //create an employee class
                        Employee newEmployee = new Employee(Int32.Parse(tbID.Text), tbName.Text, tbEmail.Text, tbPhone.Text, tbAddress.Text, tbPosition.Text, Int32.Parse(tbSalary.Text));

                        lvEmployees.Items.Add(newEmployee.Id + " " + newEmployee.Name + " " + newEmployee.Salary);
                    }
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // remove selected employee
            lvEmployees.SelectedItems[0].Remove();
        }
    }
}
