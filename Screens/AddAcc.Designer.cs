namespace Banking_System
{
    partial class AddAcc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAcc));
            this.mainMenuBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.cPin = new System.Windows.Forms.TextBox();
            this.cPinText = new System.Windows.Forms.TextBox();
            this.accName = new System.Windows.Forms.TextBox();
            this.accNameText = new System.Windows.Forms.TextBox();
            this.pin = new System.Windows.Forms.TextBox();
            this.PinText = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.firstname = new System.Windows.Forms.TextBox();
            this.firstnametext = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.BackColor = System.Drawing.Color.Red;
            this.mainMenuBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuBtn.Location = new System.Drawing.Point(12, 52);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(299, 105);
            this.mainMenuBtn.TabIndex = 116;
            this.mainMenuBtn.Text = "Main Menu";
            this.mainMenuBtn.UseVisualStyleBackColor = false;
            this.mainMenuBtn.Click += new System.EventHandler(this.mainMenuBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.Tan;
            this.nextBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.nextBtn.Location = new System.Drawing.Point(1117, 52);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(299, 105);
            this.nextBtn.TabIndex = 5;
            this.nextBtn.Text = "Deposit Money";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(511, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 282);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 102;
            this.pictureBox1.TabStop = false;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Green;
            this.addBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.addBtn.Location = new System.Drawing.Point(372, 784);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(689, 84);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cPin
            // 
            this.cPin.BackColor = System.Drawing.Color.LightGray;
            this.cPin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cPin.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.cPin.Location = new System.Drawing.Point(723, 647);
            this.cPin.Multiline = true;
            this.cPin.Name = "cPin";
            this.cPin.Size = new System.Drawing.Size(338, 53);
            this.cPin.TabIndex = 3;
            // 
            // cPinText
            // 
            this.cPinText.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.cPinText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cPinText.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPinText.Location = new System.Drawing.Point(339, 647);
            this.cPinText.Multiline = true;
            this.cPinText.Name = "cPinText";
            this.cPinText.ReadOnly = true;
            this.cPinText.Size = new System.Drawing.Size(351, 53);
            this.cPinText.TabIndex = 110;
            this.cPinText.Text = "Confirm Security PIN";
            // 
            // accName
            // 
            this.accName.BackColor = System.Drawing.Color.LightGray;
            this.accName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.accName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.accName.Location = new System.Drawing.Point(723, 467);
            this.accName.Multiline = true;
            this.accName.Name = "accName";
            this.accName.Size = new System.Drawing.Size(338, 53);
            this.accName.TabIndex = 1;
            // 
            // accNameText
            // 
            this.accNameText.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.accNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.accNameText.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accNameText.Location = new System.Drawing.Point(339, 467);
            this.accNameText.Multiline = true;
            this.accNameText.Name = "accNameText";
            this.accNameText.ReadOnly = true;
            this.accNameText.Size = new System.Drawing.Size(304, 53);
            this.accNameText.TabIndex = 112;
            this.accNameText.Text = "Account Name";
            // 
            // pin
            // 
            this.pin.BackColor = System.Drawing.Color.LightGray;
            this.pin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pin.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.pin.Location = new System.Drawing.Point(723, 557);
            this.pin.Multiline = true;
            this.pin.Name = "pin";
            this.pin.Size = new System.Drawing.Size(338, 53);
            this.pin.TabIndex = 2;
            // 
            // PinText
            // 
            this.PinText.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.PinText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PinText.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PinText.Location = new System.Drawing.Point(339, 557);
            this.PinText.Multiline = true;
            this.PinText.Name = "PinText";
            this.PinText.ReadOnly = true;
            this.PinText.Size = new System.Drawing.Size(240, 53);
            this.PinText.TabIndex = 115;
            this.PinText.Text = "Security PIN";
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.searchBtn.Location = new System.Drawing.Point(502, 765);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(360, 84);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Verify";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // firstname
            // 
            this.firstname.BackColor = System.Drawing.Color.LightGray;
            this.firstname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstname.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.firstname.Location = new System.Drawing.Point(739, 444);
            this.firstname.Multiline = true;
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(338, 53);
            this.firstname.TabIndex = 1;
            // 
            // firstnametext
            // 
            this.firstnametext.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.firstnametext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstnametext.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnametext.Location = new System.Drawing.Point(355, 444);
            this.firstnametext.Multiline = true;
            this.firstnametext.Name = "firstnametext";
            this.firstnametext.ReadOnly = true;
            this.firstnametext.Size = new System.Drawing.Size(304, 53);
            this.firstnametext.TabIndex = 122;
            this.firstnametext.Text = "First Name";
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.LightGray;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.password.Location = new System.Drawing.Point(739, 534);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(338, 53);
            this.password.TabIndex = 2;
            // 
            // passwordText
            // 
            this.passwordText.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.passwordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordText.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordText.Location = new System.Drawing.Point(355, 534);
            this.passwordText.Multiline = true;
            this.passwordText.Name = "passwordText";
            this.passwordText.ReadOnly = true;
            this.passwordText.Size = new System.Drawing.Size(240, 53);
            this.passwordText.TabIndex = 123;
            this.passwordText.Text = "Password";
            // 
            // AddAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1428, 1044);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.firstnametext);
            this.Controls.Add(this.password);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.mainMenuBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.cPin);
            this.Controls.Add(this.cPinText);
            this.Controls.Add(this.accName);
            this.Controls.Add(this.accNameText);
            this.Controls.Add(this.pin);
            this.Controls.Add(this.PinText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1450, 1100);
            this.MinimumSize = new System.Drawing.Size(1450, 1100);
            this.Name = "AddAcc";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Add Account";
            this.Load += new System.EventHandler(this.AccountSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainMenuBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox cPin;
        private System.Windows.Forms.TextBox cPinText;
        private System.Windows.Forms.TextBox accName;
        private System.Windows.Forms.TextBox accNameText;
        private System.Windows.Forms.TextBox pin;
        private System.Windows.Forms.TextBox PinText;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.TextBox firstnametext;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox passwordText;
    }
}