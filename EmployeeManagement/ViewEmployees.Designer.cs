namespace EmployeeManagement
{
    partial class ViewEmployees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvManager = new DataGridView();
            teamMemberBindingSource = new BindingSource(components);
            dgvTeamMember = new DataGridView();
            lblManagers = new Label();
            lblTeamMembers = new Label();
            lblEMS = new Label();
            pictureBox = new PictureBox();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvManager).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teamMemberBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTeamMember).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // dgvManager
            // 
            dgvManager.BackgroundColor = SystemColors.WindowFrame;
            dgvManager.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvManager.Location = new Point(32, 192);
            dgvManager.Name = "dgvManager";
            dgvManager.RowHeadersWidth = 82;
            dgvManager.Size = new Size(1030, 793);
            dgvManager.TabIndex = 0;
            // 
            // teamMemberBindingSource
            // 
            teamMemberBindingSource.DataSource = typeof(TeamMember);
            // 
            // dgvTeamMember
            // 
            dgvTeamMember.BackgroundColor = SystemColors.WindowFrame;
            dgvTeamMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeamMember.Location = new Point(1063, 192);
            dgvTeamMember.Name = "dgvTeamMember";
            dgvTeamMember.RowHeadersWidth = 82;
            dgvTeamMember.Size = new Size(1266, 793);
            dgvTeamMember.TabIndex = 1;
            // 
            // lblManagers
            // 
            lblManagers.AutoSize = true;
            lblManagers.BackColor = SystemColors.WindowFrame;
            lblManagers.Location = new Point(33, 157);
            lblManagers.Name = "lblManagers";
            lblManagers.Size = new Size(128, 36);
            lblManagers.TabIndex = 2;
            lblManagers.Text = "Managers";
            // 
            // lblTeamMembers
            // 
            lblTeamMembers.AutoSize = true;
            lblTeamMembers.BackColor = SystemColors.WindowFrame;
            lblTeamMembers.Location = new Point(1064, 157);
            lblTeamMembers.Name = "lblTeamMembers";
            lblTeamMembers.Size = new Size(190, 36);
            lblTeamMembers.TabIndex = 3;
            lblTeamMembers.Text = "Team Members";
            // 
            // lblEMS
            // 
            lblEMS.AutoSize = true;
            lblEMS.BackColor = Color.Transparent;
            lblEMS.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEMS.ForeColor = SystemColors.ControlLightLight;
            lblEMS.Location = new Point(143, 47);
            lblEMS.Margin = new Padding(4, 0, 4, 0);
            lblEMS.Name = "lblEMS";
            lblEMS.Size = new Size(769, 71);
            lblEMS.TabIndex = 5;
            lblEMS.Text = "Employee Management System";
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.Transparent;
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox.Image = Properties.Resources.ems;
            pictureBox.Location = new Point(43, 47);
            pictureBox.Margin = new Padding(4, 2, 4, 2);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(92, 85);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 4;
            pictureBox.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(2078, 72);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(199, 46);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add Employee";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // ViewEmployees
            // 
            AutoScaleDimensions = new SizeF(14F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2341, 1093);
            Controls.Add(btnAdd);
            Controls.Add(lblEMS);
            Controls.Add(pictureBox);
            Controls.Add(dgvTeamMember);
            Controls.Add(dgvManager);
            Controls.Add(lblTeamMembers);
            Controls.Add(lblManagers);
            Name = "ViewEmployees";
            Text = "View Employees";
            Load += ViewEmployees_Load;
            ((System.ComponentModel.ISupportInitialize)dgvManager).EndInit();
            ((System.ComponentModel.ISupportInitialize)teamMemberBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTeamMember).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvManager;
        private BindingSource teamMemberBindingSource;
        private DataGridView dgvTeamMember;
        private Label lblManagers;
        private Label lblTeamMembers;
        private Label lblEMS;
        private PictureBox pictureBox;
        private Button btnAdd;
    }
}