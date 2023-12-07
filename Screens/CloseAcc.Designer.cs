namespace Banking_System.Screens
{
    partial class CloseAcc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CloseAcc));
            this.mainMenuBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.cPin = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.accName = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pin = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.BackColor = System.Drawing.Color.Red;
            this.mainMenuBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuBtn.Location = new System.Drawing.Point(12, 70);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(299, 105);
            this.mainMenuBtn.TabIndex = 126;
            this.mainMenuBtn.Text = "Main Menu";
            this.mainMenuBtn.UseVisualStyleBackColor = false;
            this.mainMenuBtn.Click += new System.EventHandler(this.mainMenuBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.Tan;
            this.nextBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.nextBtn.Location = new System.Drawing.Point(1117, 70);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(299, 105);
            this.nextBtn.TabIndex = 5;
            this.nextBtn.Text = "Add Account";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(511, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 282);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 122;
            this.pictureBox1.TabStop = false;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Green;
            this.addBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.addBtn.Location = new System.Drawing.Point(372, 802);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(689, 84);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Close";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cPin
            // 
            this.cPin.BackColor = System.Drawing.Color.LightGray;
            this.cPin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cPin.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.cPin.Location = new System.Drawing.Point(723, 665);
            this.cPin.Multiline = true;
            this.cPin.Name = "cPin";
            this.cPin.Size = new System.Drawing.Size(338, 53);
            this.cPin.TabIndex = 3;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(339, 665);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(351, 53);
            this.textBox7.TabIndex = 123;
            this.textBox7.Text = "Confirm Security PIN";
            // 
            // accName
            // 
            this.accName.BackColor = System.Drawing.Color.LightGray;
            this.accName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.accName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.accName.Location = new System.Drawing.Point(723, 485);
            this.accName.Multiline = true;
            this.accName.Name = "accName";
            this.accName.Size = new System.Drawing.Size(338, 53);
            this.accName.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(339, 485);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(304, 53);
            this.textBox3.TabIndex = 124;
            this.textBox3.Text = "Account Name";
            // 
            // pin
            // 
            this.pin.BackColor = System.Drawing.Color.LightGray;
            this.pin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pin.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.pin.Location = new System.Drawing.Point(723, 575);
            this.pin.Multiline = true;
            this.pin.Name = "pin";
            this.pin.Size = new System.Drawing.Size(338, 53);
            this.pin.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(339, 575);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(240, 53);
            this.textBox5.TabIndex = 125;
            this.textBox5.Text = "Security PIN";
            // 
            // CloseAcc
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
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.cPin);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.accName);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.pin);
            this.Controls.Add(this.textBox5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1450, 1100);
            this.MinimumSize = new System.Drawing.Size(1450, 1100);
            this.Name = "CloseAcc";
            this.Text = "Close Account";
            this.Load += new System.EventHandler(this.CloseAcc_Load);
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
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox accName;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox pin;
        private System.Windows.Forms.TextBox textBox5;
    }
}