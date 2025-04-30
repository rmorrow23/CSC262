namespace MyFirstDatabase
{
    partial class UsersFrm
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
            dgvUser = new DataGridView();
            btnMainMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // dgvUser
            // 
            dgvUser.BackgroundColor = SystemColors.WindowFrame;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Location = new Point(36, 53);
            dgvUser.Name = "dgvUser";
            dgvUser.RowHeadersWidth = 82;
            dgvUser.Size = new Size(1590, 718);
            dgvUser.TabIndex = 0;
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
            // UsersFrm
            // 
            AutoScaleDimensions = new SizeF(14F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1692, 800);
            Controls.Add(btnMainMenu);
            Controls.Add(dgvUser);
            Name = "UsersFrm";
            Text = "Users Database";
            Load += UsersFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUser;
        private Button btnMainMenu;
    }
}