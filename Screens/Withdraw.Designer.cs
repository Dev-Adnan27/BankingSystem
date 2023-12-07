namespace Banking_System
{
    partial class Withdraw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Withdraw));
            this.mainMenuBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.verifyBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.accName = new System.Windows.Forms.TextBox();
            this.accNameText = new System.Windows.Forms.TextBox();
            this.depositMoney = new System.Windows.Forms.TextBox();
            this.depositText = new System.Windows.Forms.TextBox();
            this.pin = new System.Windows.Forms.TextBox();
            this.pinText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.BackColor = System.Drawing.Color.Red;
            this.mainMenuBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuBtn.Location = new System.Drawing.Point(12, 50);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(299, 105);
            this.mainMenuBtn.TabIndex = 137;
            this.mainMenuBtn.Text = "Main Menu";
            this.mainMenuBtn.UseVisualStyleBackColor = false;
            this.mainMenuBtn.Click += new System.EventHandler(this.mainMenuBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.Tan;
            this.nextBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.nextBtn.Location = new System.Drawing.Point(1117, 50);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(299, 105);
            this.nextBtn.TabIndex = 132;
            this.nextBtn.Text = "Transaction History";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(511, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 282);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 133;
            this.pictureBox1.TabStop = false;
            // 
            // verifyBtn
            // 
            this.verifyBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.verifyBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyBtn.ForeColor = System.Drawing.Color.Black;
            this.verifyBtn.Location = new System.Drawing.Point(525, 549);
            this.verifyBtn.Name = "verifyBtn";
            this.verifyBtn.Size = new System.Drawing.Size(305, 84);
            this.verifyBtn.TabIndex = 129;
            this.verifyBtn.Text = "Verify";
            this.verifyBtn.UseVisualStyleBackColor = false;
            this.verifyBtn.Click += new System.EventHandler(this.verifyBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Green;
            this.addBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.addBtn.Location = new System.Drawing.Point(350, 585);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(689, 84);
            this.addBtn.TabIndex = 131;
            this.addBtn.Text = "Withdraw";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // accName
            // 
            this.accName.BackColor = System.Drawing.Color.LightGray;
            this.accName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.accName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.accName.Location = new System.Drawing.Point(723, 364);
            this.accName.Multiline = true;
            this.accName.Name = "accName";
            this.accName.Size = new System.Drawing.Size(338, 53);
            this.accName.TabIndex = 127;
            // 
            // accNameText
            // 
            this.accNameText.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.accNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.accNameText.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accNameText.Location = new System.Drawing.Point(339, 364);
            this.accNameText.Multiline = true;
            this.accNameText.Name = "accNameText";
            this.accNameText.ReadOnly = true;
            this.accNameText.Size = new System.Drawing.Size(304, 53);
            this.accNameText.TabIndex = 134;
            this.accNameText.Text = "Account Name";
            // 
            // depositMoney
            // 
            this.depositMoney.BackColor = System.Drawing.Color.LightGray;
            this.depositMoney.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.depositMoney.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.depositMoney.Location = new System.Drawing.Point(723, 490);
            this.depositMoney.Multiline = true;
            this.depositMoney.Name = "depositMoney";
            this.depositMoney.Size = new System.Drawing.Size(338, 53);
            this.depositMoney.TabIndex = 130;
            // 
            // depositText
            // 
            this.depositText.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.depositText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.depositText.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositText.Location = new System.Drawing.Point(339, 490);
            this.depositText.Multiline = true;
            this.depositText.Name = "depositText";
            this.depositText.ReadOnly = true;
            this.depositText.Size = new System.Drawing.Size(319, 53);
            this.depositText.TabIndex = 135;
            this.depositText.Text = "Withdraw Amount";
            // 
            // pin
            // 
            this.pin.BackColor = System.Drawing.Color.LightGray;
            this.pin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pin.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.pin.Location = new System.Drawing.Point(723, 454);
            this.pin.Multiline = true;
            this.pin.Name = "pin";
            this.pin.Size = new System.Drawing.Size(338, 53);
            this.pin.TabIndex = 128;
            // 
            // pinText
            // 
            this.pinText.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.pinText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pinText.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinText.Location = new System.Drawing.Point(339, 454);
            this.pinText.Multiline = true;
            this.pinText.Name = "pinText";
            this.pinText.ReadOnly = true;
            this.pinText.Size = new System.Drawing.Size(240, 53);
            this.pinText.TabIndex = 136;
            this.pinText.Text = "Security PIN";
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1428, 1044);
            this.Controls.Add(this.mainMenuBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.verifyBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.accName);
            this.Controls.Add(this.accNameText);
            this.Controls.Add(this.depositMoney);
            this.Controls.Add(this.depositText);
            this.Controls.Add(this.pin);
            this.Controls.Add(this.pinText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1450, 1100);
            this.MinimumSize = new System.Drawing.Size(1450, 1100);
            this.Name = "Withdraw";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainMenuBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button verifyBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox accName;
        private System.Windows.Forms.TextBox accNameText;
        private System.Windows.Forms.TextBox depositMoney;
        private System.Windows.Forms.TextBox depositText;
        private System.Windows.Forms.TextBox pin;
        private System.Windows.Forms.TextBox pinText;
    }
}