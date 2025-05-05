namespace EmployeeManagement
{
    public partial class frmEmployeeManage : Form
    {
        public frmEmployeeManage()
        {
            InitializeComponent();
            cmbPosition.Items.Add("Team Member");
            cmbPosition.Items.Add("Manager");
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {   //check to see if any fields were left empty
            if (string.IsNullOrEmpty(tbID.Text) | string.IsNullOrEmpty(tbName.Text) | string.IsNullOrEmpty(tbEmail.Text) | string.IsNullOrEmpty(tbPhone.Text) | string.IsNullOrEmpty(tbAddress.Text) | string.IsNullOrEmpty(cmbPosition.Text) | string.IsNullOrEmpty(tbSalary.Text))
            {

                MessageBox.Show("Please ensure no fields are left empty!");

            }
            else
            {   //Check if employee id is not an integer
                if (!int.TryParse(tbID.Text, out _))
                {   //if it is not an integer show a message
                    MessageBox.Show("Employee ID must only contain numbers!" + Environment.NewLine + " Cannot be used");
                }
                else
                {  //if it is check the salary field as well
                    if (!int.TryParse(tbSalary.Text, out _))
                    {   // if the salary is not a number display a message
                        MessageBox.Show("Employee Salary must only contain numbers!" + Environment.NewLine + " Cannot be used");
                    }
                    else
                    {
                        //check if adding team member or manager
                        if (cmbPosition.Text == "Team Member")
                        {
                            //create a Team Member class
                            TeamMember newTeamMember = new TeamMember(Int32.Parse(tbID.Text), tbName.Text, tbEmail.Text, tbPhone.Text, tbAddress.Text, cmbPosition.Text, Int32.Parse(tbSalary.Text), cmbProp1.Text, cmbProp2.Text, cmbProp3.Text);

                            lvEmployees.Items.Add(newTeamMember.Display(3));
                            DatabaseHelper.InsertTeamMembers(tbName.Text, cmbProp2.Text, cmbProp3.Text, Int32.Parse(tbSalary.Text));
                        }
                        else if (cmbPosition.Text == "Manager")
                        {
                            //set bonus to years of experience time $500
                            int bonus = (Int32.Parse(cmbProp3.Text) * 500);
                            bool canHire = false;

                            //convert can hire string to boolean
                            if (cmbProp2.Text == "True")
                            {
                                canHire = true;
                            }
                            else
                            {
                                canHire = false;
                            }

                            //create a Manager class
                            Manager newManager = new Manager(Int32.Parse(tbID.Text), tbName.Text, tbEmail.Text, tbPhone.Text, tbAddress.Text, cmbPosition.Text, Int32.Parse(tbSalary.Text), cmbProp1.Text, canHire, Int32.Parse(cmbProp3.Text), bonus);

                            lvEmployees.Items.Add(newManager.Display(3));

                            DatabaseHelper.InsertManagers(tbName.Text, Int32.Parse(tbSalary.Text), Int32.Parse(cmbProp3.Text), canHire);
                        }
                    }
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // remove selected employee
            lvEmployees.SelectedItems[0].Remove();
        }

        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            //change info based on selected employee position
            if (cmbPosition.Text == "Team Member")
            {
                lbProp1.Text = "Manager:";
                lbProp2.Text = "     Team:";
                lbProp3.Text = "Location:";

                //set dropdown items to the Manager
                cmbProp1.Items.Clear();
                cmbProp1.Items.Add("Randy");
                cmbProp1.Items.Add("Katie");
                cmbProp1.Items.Add("Shai");

                //set dropdown items to the Teams
                cmbProp2.Items.Clear();
                cmbProp2.Items.Add("Sales");
                cmbProp2.Items.Add("Finance");
                cmbProp2.Items.Add("Software Development");

                //set dropdown items to the Location
                cmbProp3.Items.Clear();
                cmbProp3.Items.Add("Remote");
                cmbProp3.Items.Add("Hybrid");
                cmbProp3.Items.Add("Office");
            }
            else if (cmbPosition.Text == "Manager")
            {
                lbProp1.Text = "PayGroup:";
                lbProp2.Text = "Can Hire:";
                lbProp3.Text = "     Exper:";

                //set dropdown items to the paygroup
                cmbProp1.Items.Clear();
                cmbProp1.Items.Add("Hourly");
                cmbProp1.Items.Add("Salary");

                //set drowdown items for the can hire
                cmbProp2.Items.Clear();
                cmbProp2.Items.Add("True");
                cmbProp2.Items.Add("False");

                //set dropdown items to the experience
                cmbProp3.Items.Clear();
                cmbProp3.Items.Add(1);
                cmbProp3.Items.Add(2);
                cmbProp3.Items.Add(3);
            }
        }


        private void frmEmployeeManage_Load(object sender, EventArgs e)
        {

        }

        private void btnViewEmployees_Click(object sender, EventArgs e)
        {
            ViewEmployees viewEmployees = new ViewEmployees();
            this.Hide();
            viewEmployees.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            ViewUsers viewUsers = new ViewUsers();
            this.Hide();
            viewUsers.Show();
        }
    }
}
