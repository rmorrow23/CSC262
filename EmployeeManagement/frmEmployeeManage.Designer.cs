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
            lvEmployees = new ListView();
            cmbPosition = new ComboBox();
            lbProp1 = new Label();
            lbProp2 = new Label();
            lbProp3 = new Label();
            cmbProp2 = new ComboBox();
            cmbProp1 = new ComboBox();
            cmbProp3 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.ems;
            pictureBox1.Location = new Point(12, 19);
            pictureBox1.Margin = new Padding(2, 1, 2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 40);
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
            lblEMS.Location = new Point(62, 19);
            lblEMS.Margin = new Padding(2, 0, 2, 0);
            lblEMS.Name = "lblEMS";
            lblEMS.Size = new Size(389, 37);
            lblEMS.TabIndex = 1;
            lblEMS.Text = "Employee Management System";
            // 
            // lblEID
            // 
            lblEID.AutoSize = true;
            lblEID.BackColor = SystemColors.WindowFrame;
            lblEID.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEID.ForeColor = SystemColors.ControlLightLight;
            lblEID.Location = new Point(3, 109);
            lblEID.Margin = new Padding(2, 0, 2, 0);
            lblEID.Name = "lblEID";
            lblEID.Size = new Size(119, 37);
            lblEID.TabIndex = 2;
            lblEID.Text = "          ID:";
            // 
            // tbID
            // 
            tbID.BackColor = SystemColors.ActiveCaptionText;
            tbID.BorderStyle = BorderStyle.FixedSingle;
            tbID.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbID.ForeColor = SystemColors.ControlLight;
            tbID.Location = new Point(122, 109);
            tbID.Margin = new Padding(2, 1, 2, 1);
            tbID.Name = "tbID";
            tbID.Size = new Size(201, 43);
            tbID.TabIndex = 3;
            // 
            // tbName
            // 
            tbName.BackColor = SystemColors.ActiveCaptionText;
            tbName.BorderStyle = BorderStyle.FixedSingle;
            tbName.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbName.ForeColor = SystemColors.ControlLight;
            tbName.Location = new Point(122, 141);
            tbName.Margin = new Padding(2, 1, 2, 1);
            tbName.Name = "tbName";
            tbName.Size = new Size(201, 43);
            tbName.TabIndex = 4;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Location = new Point(85, 474);
            btnAddEmployee.Margin = new Padding(2, 1, 2, 1);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(136, 32);
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
            lblName.Location = new Point(3, 142);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(122, 37);
            lblName.TabIndex = 6;
            lblName.Text = "    Name:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = SystemColors.WindowFrame;
            lblEmail.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = SystemColors.ControlLightLight;
            lblEmail.Location = new Point(3, 176);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(123, 37);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "     Email:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = SystemColors.WindowFrame;
            lblAddress.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.ForeColor = SystemColors.ControlLightLight;
            lblAddress.Location = new Point(3, 242);
            lblAddress.Margin = new Padding(2, 0, 2, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(124, 37);
            lblAddress.TabIndex = 8;
            lblAddress.Text = " Address:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.BackColor = SystemColors.WindowFrame;
            lblPhone.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.ForeColor = SystemColors.ControlLightLight;
            lblPhone.Location = new Point(3, 208);
            lblPhone.Margin = new Padding(2, 0, 2, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(126, 37);
            lblPhone.TabIndex = 9;
            lblPhone.Text = "    Phone:";
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.BackColor = SystemColors.WindowFrame;
            lblSalary.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSalary.ForeColor = SystemColors.ControlLightLight;
            lblSalary.Location = new Point(3, 309);
            lblSalary.Margin = new Padding(2, 0, 2, 0);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(122, 37);
            lblSalary.TabIndex = 10;
            lblSalary.Text = "    Salary:";
            // 
            // tbEmail
            // 
            tbEmail.BackColor = SystemColors.ActiveCaptionText;
            tbEmail.BorderStyle = BorderStyle.FixedSingle;
            tbEmail.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.ForeColor = SystemColors.ControlLight;
            tbEmail.Location = new Point(122, 172);
            tbEmail.Margin = new Padding(2, 1, 2, 1);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(201, 43);
            tbEmail.TabIndex = 12;
            // 
            // tbAddress
            // 
            tbAddress.BackColor = SystemColors.ActiveCaptionText;
            tbAddress.BorderStyle = BorderStyle.FixedSingle;
            tbAddress.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbAddress.ForeColor = SystemColors.ControlLight;
            tbAddress.Location = new Point(122, 241);
            tbAddress.Margin = new Padding(2, 1, 2, 1);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(201, 43);
            tbAddress.TabIndex = 13;
            // 
            // tbPhone
            // 
            tbPhone.BackColor = SystemColors.ActiveCaptionText;
            tbPhone.BorderStyle = BorderStyle.FixedSingle;
            tbPhone.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPhone.ForeColor = SystemColors.ControlLight;
            tbPhone.Location = new Point(122, 207);
            tbPhone.Margin = new Padding(2, 1, 2, 1);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(201, 43);
            tbPhone.TabIndex = 14;
            // 
            // tbSalary
            // 
            tbSalary.BackColor = SystemColors.ActiveCaptionText;
            tbSalary.BorderStyle = BorderStyle.FixedSingle;
            tbSalary.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSalary.ForeColor = SystemColors.ControlLight;
            tbSalary.Location = new Point(122, 306);
            tbSalary.Margin = new Padding(2, 1, 2, 1);
            tbSalary.Name = "tbSalary";
            tbSalary.Size = new Size(201, 43);
            tbSalary.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(596, 71);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(240, 37);
            label5.TabIndex = 16;
            label5.Text = "Current Employees";
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(636, 474);
            btnRemove.Margin = new Padding(2, 1, 2, 1);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(128, 32);
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
            lblPosition.Location = new Point(3, 275);
            lblPosition.Margin = new Padding(2, 0, 2, 0);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(125, 37);
            lblPosition.TabIndex = 18;
            lblPosition.Text = " Position:";
            // 
            // lvEmployees
            // 
            lvEmployees.BackColor = Color.FromArgb(64, 64, 64);
            lvEmployees.ForeColor = SystemColors.Info;
            lvEmployees.Location = new Point(377, 109);
            lvEmployees.Margin = new Padding(2, 1, 2, 1);
            lvEmployees.Name = "lvEmployees";
            lvEmployees.Size = new Size(632, 348);
            lvEmployees.TabIndex = 20;
            lvEmployees.UseCompatibleStateImageBehavior = false;
            lvEmployees.View = View.List;
            // 
            // cmbPosition
            // 
            cmbPosition.BackColor = SystemColors.ActiveCaptionText;
            cmbPosition.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPosition.ForeColor = SystemColors.Info;
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(122, 274);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(201, 38);
            cmbPosition.TabIndex = 21;
            cmbPosition.SelectedIndexChanged += cmbPosition_SelectedIndexChanged;
            // 
            // lbProp1
            // 
            lbProp1.AutoSize = true;
            lbProp1.BackColor = SystemColors.WindowFrame;
            lbProp1.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbProp1.ForeColor = SystemColors.ControlLightLight;
            lbProp1.Location = new Point(3, 346);
            lbProp1.Margin = new Padding(2, 0, 2, 0);
            lbProp1.Name = "lbProp1";
            lbProp1.Size = new Size(122, 37);
            lbProp1.TabIndex = 22;
            lbProp1.Text = "               ";
            // 
            // lbProp2
            // 
            lbProp2.AutoSize = true;
            lbProp2.BackColor = SystemColors.WindowFrame;
            lbProp2.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbProp2.ForeColor = SystemColors.ControlLightLight;
            lbProp2.Location = new Point(3, 383);
            lbProp2.Margin = new Padding(2, 0, 2, 0);
            lbProp2.Name = "lbProp2";
            lbProp2.Size = new Size(122, 37);
            lbProp2.TabIndex = 24;
            lbProp2.Text = "               ";
            // 
            // lbProp3
            // 
            lbProp3.AutoSize = true;
            lbProp3.BackColor = SystemColors.WindowFrame;
            lbProp3.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbProp3.ForeColor = SystemColors.ControlLightLight;
            lbProp3.Location = new Point(4, 420);
            lbProp3.Margin = new Padding(2, 0, 2, 0);
            lbProp3.Name = "lbProp3";
            lbProp3.Size = new Size(122, 37);
            lbProp3.TabIndex = 26;
            lbProp3.Text = "               ";
            // 
            // cmbProp2
            // 
            cmbProp2.BackColor = SystemColors.ActiveCaptionText;
            cmbProp2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbProp2.ForeColor = SystemColors.Info;
            cmbProp2.FormattingEnabled = true;
            cmbProp2.Location = new Point(122, 383);
            cmbProp2.Name = "cmbProp2";
            cmbProp2.Size = new Size(201, 38);
            cmbProp2.TabIndex = 28;
            // 
            // cmbProp1
            // 
            cmbProp1.BackColor = SystemColors.ActiveCaptionText;
            cmbProp1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbProp1.ForeColor = SystemColors.Info;
            cmbProp1.FormattingEnabled = true;
            cmbProp1.Location = new Point(122, 348);
            cmbProp1.Name = "cmbProp1";
            cmbProp1.Size = new Size(201, 38);
            cmbProp1.TabIndex = 29;
            // 
            // cmbProp3
            // 
            cmbProp3.BackColor = SystemColors.ActiveCaptionText;
            cmbProp3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbProp3.ForeColor = SystemColors.Info;
            cmbProp3.FormattingEnabled = true;
            cmbProp3.Location = new Point(122, 419);
            cmbProp3.Name = "cmbProp3";
            cmbProp3.Size = new Size(201, 38);
            cmbProp3.TabIndex = 30;
            // 
            // frmEmployeeManage
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1054, 516);
            Controls.Add(cmbProp3);
            Controls.Add(tbSalary);
            Controls.Add(cmbProp1);
            Controls.Add(cmbProp2);
            Controls.Add(lbProp3);
            Controls.Add(lbProp2);
            Controls.Add(lbProp1);
            Controls.Add(tbID);
            Controls.Add(tbName);
            Controls.Add(tbEmail);
            Controls.Add(tbPhone);
            Controls.Add(tbAddress);
            Controls.Add(cmbPosition);
            Controls.Add(lblPosition);
            Controls.Add(btnRemove);
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
            Controls.Add(lvEmployees);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 1, 2, 1);
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
        private ListView lvEmployees;
        private ComboBox cmbPosition;
        private Label lbProp1;
        private Label lbProp2;
        private Label lbProp3;
        private ComboBox cmbProp2;
        private ComboBox cmbProp1;
        private ComboBox cmbProp3;
    }
}
