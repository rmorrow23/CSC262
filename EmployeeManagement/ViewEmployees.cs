using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class ViewEmployees : Form
    {
        public ViewEmployees()
        {
            InitializeComponent();
        }

        private void ViewEmployees_Load(object sender, EventArgs e)
        {
            dgvManager.DataSource = DatabaseHelper.GetManagers();
            dgvTeamMember.DataSource = DatabaseHelper.GetTeamMembers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEmployeeManage employeeManagement = new frmEmployeeManage();
            this.Hide();
            employeeManagement.Show();
        }
    }
}
