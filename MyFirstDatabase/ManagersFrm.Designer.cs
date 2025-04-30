namespace MyFirstDatabase
{
    partial class ManagersFrm
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
            dgvManager = new DataGridView();
            btnMainMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvManager).BeginInit();
            SuspendLayout();
            // 
            // dgvManager
            // 
            dgvManager.BackgroundColor = SystemColors.WindowFrame;
            dgvManager.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvManager.Location = new Point(36, 53);
            dgvManager.Name = "dgvManager";
            dgvManager.RowHeadersWidth = 82;
            dgvManager.Size = new Size(1590, 718);
            dgvManager.TabIndex = 0;
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
            // ManagersDbFrm
            // 
            AutoScaleDimensions = new SizeF(14F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1692, 800);
            Controls.Add(btnMainMenu);
            Controls.Add(dgvManager);
            Name = "ManagersDbFrm";
            Text = "Managers Database";
            Load += ManagersFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvManager).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvManager;
        private Button btnMainMenu;
    }
}