namespace MyFirstDatabase
{
    public partial class dbMenuForm : Form
    {
        public dbMenuForm()
        {
            InitializeComponent();
        }
        private void btnDbManager_Click(object sender, EventArgs e)
            
        {
            //create instance of manager form
            ManagersFrm frmManagers = new ManagersFrm();
            //hide this form
            this.Hide();
            //show manager form
            frmManagers.Show();
        }
        private void btnDbTeamMember_Click(object sender, EventArgs e)
        {
            //create instance of TeamMember form
            TeamMembersFrm frmTeamMembers = new TeamMembersFrm();
            //hide this form
            this.Hide();
            //show team member form
            frmTeamMembers.Show();
        }
        private void btnDbUser_Click(object sender, EventArgs e)
        {
            //create instance of user form
           UsersFrm frmUsers = new UsersFrm();
            //hide this form
            this.Hide();
            //show user form
            frmUsers.Show();
        }
    }
}
