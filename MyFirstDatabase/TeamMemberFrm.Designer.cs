namespace MyFirstDatabase
{
    partial class TeamMembersFrm
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
            dgvTeamMember = new DataGridView();
            btnMainMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTeamMember).BeginInit();
            SuspendLayout();
            // 
            // dgvTeamMember
            // 
            dgvTeamMember.BackgroundColor = SystemColors.WindowFrame;
            dgvTeamMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeamMember.Location = new Point(36, 53);
            dgvTeamMember.Name = "dgvTeamMember";
            dgvTeamMember.RowHeadersWidth = 82;
            dgvTeamMember.Size = new Size(1590, 718);
            dgvTeamMember.TabIndex = 0;
            // 
            // btnMainMenu
            // 
            btnMainMenu.Location = new Point(2, 1);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(181, 46);
            btnMainMenu.TabIndex = 1;
            btnMainMenu.Text = "Main Menu";
            btnMainMenu.UseVisualStyleBackColor = true;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // TeamMembersFrm
            // 
            AutoScaleDimensions = new SizeF(14F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1692, 800);
            Controls.Add(btnMainMenu);
            Controls.Add(dgvTeamMember);
            Name = "TeamMembersFrm";
            Text = "Team Members Database";
            Load += TeamMembersFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTeamMember).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTeamMember;
        private Button btnMainMenu;
    }
}