namespace Week_1_Testing
{
    partial class TestingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestingForm));
            lblInfo = new Label();
            txtInt = new TextBox();
            btnStart = new Button();
            listArray = new ListView();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfo.ForeColor = SystemColors.Control;
            lblInfo.Location = new Point(25, 9);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(939, 59);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "How many numbers would you like to generate?";
            // 
            // txtInt
            // 
            txtInt.BackColor = Color.Black;
            txtInt.BorderStyle = BorderStyle.FixedSingle;
            txtInt.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInt.ForeColor = Color.Gold;
            txtInt.Location = new Point(340, 496);
            txtInt.Name = "txtInt";
            txtInt.PlaceholderText = "Int (1 to 10000)";
            txtInt.Size = new Size(334, 71);
            txtInt.TabIndex = 1;
            txtInt.TextAlign = HorizontalAlignment.Center;
            // 
            // btnStart
            // 
            btnStart.FlatAppearance.BorderColor = Color.FromArgb(215, 215, 0);
            btnStart.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 100, 0);
            btnStart.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 50, 0);
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.ForeColor = SystemColors.Info;
            btnStart.Location = new Point(404, 598);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(206, 73);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start Testing";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // listArray
            // 
            listArray.BackColor = Color.Black;
            listArray.ForeColor = SystemColors.Info;
            listArray.Location = new Point(180, 90);
            listArray.Name = "listArray";
            listArray.Size = new Size(649, 314);
            listArray.TabIndex = 3;
            listArray.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(340, 443);
            label1.Name = "label1";
            label1.Size = new Size(347, 36);
            label1.TabIndex = 4;
            label1.Text = "Input will be multiplied by 10";
            // 
            // TestingForm
            // 
            AutoScaleDimensions = new SizeF(14F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(990, 733);
            Controls.Add(label1);
            Controls.Add(listArray);
            Controls.Add(btnStart);
            Controls.Add(txtInt);
            Controls.Add(lblInfo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TestingForm";
            Text = "Number Generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfo;
        private TextBox txtInt;
        private Button btnStart;
        private ListView listArray;
        private Label label1;
    }
}
