namespace MyFirstDatabase
{
    partial class dbMenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblWelcome = new Label();
            btnDbManager = new Button();
            btnDbTeamMember = new Button();
            btnDbUser = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(268, 83);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(1057, 86);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome to the Database Manager!";
            // 
            // btnDbManager
            // 
            btnDbManager.Location = new Point(432, 437);
            btnDbManager.Name = "btnDbManager";
            btnDbManager.Size = new Size(150, 46);
            btnDbManager.TabIndex = 1;
            btnDbManager.Text = "Managers";
            btnDbManager.UseVisualStyleBackColor = true;
            btnDbManager.Click += this.btnDbManager_Click;
            // 
            // btnDbTeamMember
            // 
            btnDbTeamMember.Location = new Point(702, 437);
            btnDbTeamMember.Name = "btnDbTeamMember";
            btnDbTeamMember.Size = new Size(236, 46);
            btnDbTeamMember.TabIndex = 2;
            btnDbTeamMember.Text = "Team Members";
            btnDbTeamMember.UseVisualStyleBackColor = true;
            btnDbTeamMember.Click += this.btnDbTeamMember_Click;
            // 
            // btnDbUser
            // 
            btnDbUser.Location = new Point(1069, 437);
            btnDbUser.Name = "btnDbUser";
            btnDbUser.Size = new Size(150, 46);
            btnDbUser.TabIndex = 3;
            btnDbUser.Text = "Users";
            btnDbUser.UseVisualStyleBackColor = true;
            btnDbUser.Click += this.btnDbUser_Click;
            // 
            // dbMenuForm
            // 
            AutoScaleDimensions = new SizeF(14F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1684, 842);
            Controls.Add(btnDbUser);
            Controls.Add(btnDbTeamMember);
            Controls.Add(btnDbManager);
            Controls.Add(lblWelcome);
            Name = "dbMenuForm";
            Text = "Main Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnDbManager;
        private Button btnDbTeamMember;
        private Button btnDbUser;
    }
}
