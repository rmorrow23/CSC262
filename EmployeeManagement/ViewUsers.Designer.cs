namespace EmployeeManagement
{
    partial class ViewUsers
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
            lblEMS = new Label();
            pictureBox = new PictureBox();
            dgvUser = new DataGridView();
            lblUsers = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // lblEMS
            // 
            lblEMS.AutoSize = true;
            lblEMS.BackColor = Color.Transparent;
            lblEMS.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEMS.ForeColor = SystemColors.ControlLightLight;
            lblEMS.Location = new Point(133, 42);
            lblEMS.Margin = new Padding(4, 0, 4, 0);
            lblEMS.Name = "lblEMS";
            lblEMS.Size = new Size(769, 71);
            lblEMS.TabIndex = 7;
            lblEMS.Text = "Employee Management System";
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.Transparent;
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox.Image = Properties.Resources.ems;
            pictureBox.Location = new Point(33, 42);
            pictureBox.Margin = new Padding(4, 2, 4, 2);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(92, 85);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 6;
            pictureBox.TabStop = false;
            // 
            // dgvUser
            // 
            dgvUser.BackgroundColor = SystemColors.WindowFrame;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Location = new Point(33, 180);
            dgvUser.Name = "dgvUser";
            dgvUser.RowHeadersWidth = 82;
            dgvUser.Size = new Size(1078, 616);
            dgvUser.TabIndex = 8;
            // 
            // lblUsers
            // 
            lblUsers.AutoSize = true;
            lblUsers.BackColor = SystemColors.WindowFrame;
            lblUsers.Location = new Point(34, 145);
            lblUsers.Name = "lblUsers";
            lblUsers.Size = new Size(78, 36);
            lblUsers.TabIndex = 9;
            lblUsers.Text = "Users";
            // 
            // ViewUsers
            // 
            AutoScaleDimensions = new SizeF(14F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1148, 872);
            Controls.Add(dgvUser);
            Controls.Add(lblUsers);
            Controls.Add(lblEMS);
            Controls.Add(pictureBox);
            Name = "ViewUsers";
            Text = "View Users";
            Load += ViewUsers_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEMS;
        private PictureBox pictureBox;
        private DataGridView dgvUser;
        private Label lblUsers;
    }
}