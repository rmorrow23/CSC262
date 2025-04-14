namespace EmployeeManagement
{
    partial class frmEmployeeManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeManage));
            pictureBox1 = new PictureBox();
            lblEMS = new Label();
            lblEID = new Label();
            tbID = new TextBox();
            tbName = new TextBox();
            btnAddEmployee = new Button();
            lblName = new Label();
            lblEmail = new Label();
            lblAddress = new Label();
            lblPhone = new Label();
            lblSalary = new Label();
            tbEmail = new TextBox();
            tbAddress = new TextBox();
            tbPhone = new TextBox();
            tbSalary = new TextBox();
            label5 = new Label();
            btnRemove = new Button();
            lblPosition = new Label();
            tbPosition = new TextBox();
            lvEmployees = new ListView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.ems;
            pictureBox1.Location = new Point(25, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblEMS
            // 
            lblEMS.AutoSize = true;
            lblEMS.BackColor = Color.Transparent;
            lblEMS.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEMS.ForeColor = SystemColors.ControlLightLight;
            lblEMS.Location = new Point(123, 40);
            lblEMS.Name = "lblEMS";
            lblEMS.Size = new Size(769, 71);
            lblEMS.TabIndex = 1;
            lblEMS.Text = "Employee Management System";
            // 
            // lblEID
            // 
            lblEID.AutoSize = true;
            lblEID.BackColor = SystemColors.WindowFrame;
            lblEID.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEID.ForeColor = SystemColors.ControlLightLight;
            lblEID.Location = new Point(6, 230);
            lblEID.Name = "lblEID";
            lblEID.Size = new Size(242, 71);
            lblEID.TabIndex = 2;
            lblEID.Text = "          ID:";
            // 
            // tbID
            // 
            tbID.BackColor = SystemColors.ActiveCaptionText;
            tbID.BorderStyle = BorderStyle.FixedSingle;
            tbID.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbID.ForeColor = SystemColors.ControlLight;
            tbID.Location = new Point(244, 230);
            tbID.Name = "tbID";
            tbID.Size = new Size(400, 78);
            tbID.TabIndex = 3;
            // 
            // tbName
            // 
            tbName.BackColor = SystemColors.ActiveCaptionText;
            tbName.BorderStyle = BorderStyle.FixedSingle;
            tbName.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbName.ForeColor = SystemColors.ControlLight;
            tbName.Location = new Point(244, 299);
            tbName.Name = "tbName";
            tbName.Size = new Size(400, 78);
            tbName.TabIndex = 4;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Location = new Point(135, 758);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(273, 68);
            btnAddEmployee.TabIndex = 5;
            btnAddEmployee.Text = "Add Employee";
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = SystemColors.WindowFrame;
            lblName.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = SystemColors.ControlLightLight;
            lblName.Location = new Point(6, 301);
            lblName.Name = "lblName";
            lblName.Size = new Size(242, 71);
            lblName.TabIndex = 6;
            lblName.Text = "    Name:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = SystemColors.WindowFrame;
            lblEmail.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = SystemColors.ControlLightLight;
            lblEmail.Location = new Point(6, 372);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(242, 71);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "     Email:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = SystemColors.WindowFrame;
            lblAddress.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.ForeColor = SystemColors.ControlLightLight;
            lblAddress.Location = new Point(6, 512);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(242, 71);
            lblAddress.TabIndex = 8;
            lblAddress.Text = " Address:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.BackColor = SystemColors.WindowFrame;
            lblPhone.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.ForeColor = SystemColors.ControlLightLight;
            lblPhone.Location = new Point(6, 441);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(250, 71);
            lblPhone.TabIndex = 9;
            lblPhone.Text = "    Phone:";
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.BackColor = SystemColors.WindowFrame;
            lblSalary.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSalary.ForeColor = SystemColors.ControlLightLight;
            lblSalary.Location = new Point(6, 654);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(240, 71);
            lblSalary.TabIndex = 10;
            lblSalary.Text = "    Salary:";
            // 
            // tbEmail
            // 
            tbEmail.BackColor = SystemColors.ActiveCaptionText;
            tbEmail.BorderStyle = BorderStyle.FixedSingle;
            tbEmail.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.ForeColor = SystemColors.ControlLight;
            tbEmail.Location = new Point(244, 365);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(400, 78);
            tbEmail.TabIndex = 12;
            // 
            // tbAddress
            // 
            tbAddress.BackColor = SystemColors.ActiveCaptionText;
            tbAddress.BorderStyle = BorderStyle.FixedSingle;
            tbAddress.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbAddress.ForeColor = SystemColors.ControlLight;
            tbAddress.Location = new Point(244, 510);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(400, 78);
            tbAddress.TabIndex = 13;
            // 
            // tbPhone
            // 
            tbPhone.BackColor = SystemColors.ActiveCaptionText;
            tbPhone.BorderStyle = BorderStyle.FixedSingle;
            tbPhone.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPhone.ForeColor = SystemColors.ControlLight;
            tbPhone.Location = new Point(244, 439);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(400, 78);
            tbPhone.TabIndex = 14;
            // 
            // tbSalary
            // 
            tbSalary.BackColor = SystemColors.ActiveCaptionText;
            tbSalary.BorderStyle = BorderStyle.FixedSingle;
            tbSalary.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSalary.ForeColor = SystemColors.ControlLight;
            tbSalary.Location = new Point(244, 647);
            tbSalary.Name = "tbSalary";
            tbSalary.Size = new Size(400, 78);
            tbSalary.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(970, 142);
            label5.Name = "label5";
            label5.Size = new Size(472, 71);
            label5.TabIndex = 16;
            label5.Text = "Current Employees";
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(984, 744);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(257, 68);
            btnRemove.TabIndex = 17;
            btnRemove.Text = "Remove Employee";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.BackColor = SystemColors.WindowFrame;
            lblPosition.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPosition.ForeColor = SystemColors.ControlLightLight;
            lblPosition.Location = new Point(6, 583);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(242, 71);
            lblPosition.TabIndex = 18;
            lblPosition.Text = " Position:";
            // 
            // tbPosition
            // 
            tbPosition.BackColor = SystemColors.ActiveCaptionText;
            tbPosition.BorderStyle = BorderStyle.FixedSingle;
            tbPosition.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPosition.ForeColor = SystemColors.ControlLight;
            tbPosition.Location = new Point(244, 581);
            tbPosition.Name = "tbPosition";
            tbPosition.Size = new Size(400, 78);
            tbPosition.TabIndex = 19;
            // 
            // lvEmployees
            // 
            lvEmployees.BackColor = Color.FromArgb(64, 64, 64);
            lvEmployees.Location = new Point(755, 230);
            lvEmployees.Name = "lvEmployees";
            lvEmployees.Size = new Size(687, 508);
            lvEmployees.TabIndex = 20;
            lvEmployees.UseCompatibleStateImageBehavior = false;
            lvEmployees.View = View.List;
            // 
            // frmEmployeeManage
            // 
            AutoScaleDimensions = new SizeF(14F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1500, 888);
            Controls.Add(lvEmployees);
            Controls.Add(tbEmail);
            Controls.Add(tbName);
            Controls.Add(tbPhone);
            Controls.Add(tbSalary);
            Controls.Add(tbPosition);
            Controls.Add(lblPosition);
            Controls.Add(tbAddress);
            Controls.Add(btnRemove);
            Controls.Add(tbID);
            Controls.Add(label5);
            Controls.Add(lblSalary);
            Controls.Add(lblPhone);
            Controls.Add(lblAddress);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(btnAddEmployee);
            Controls.Add(lblEID);
            Controls.Add(lblEMS);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmEmployeeManage";
            Text = "Employees";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblEMS;
        private Label lblEID;
        private TextBox tbID;
        private TextBox tbName;
        private Button btnAddEmployee;
        private Label lblName;
        private Label lblEmail;
        private Label lblAddress;
        private Label lblPhone;
        private Label lblSalary;
        private TextBox tbEmail;
        private TextBox tbAddress;
        private TextBox tbPhone;
        private TextBox tbSalary;
        private Label label5;
        private Button btnRemove;
        private Label lblPosition;
        private TextBox tbPosition;
        private ListView lvEmployees;
    }
}
