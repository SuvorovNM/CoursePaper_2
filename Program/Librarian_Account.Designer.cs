namespace Program
{
    partial class Librarian_Account
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
            this.lb_Name = new System.Windows.Forms.Label();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.lb_Birthday = new System.Windows.Forms.Label();
            this.TB_Birth = new System.Windows.Forms.TextBox();
            this.lb_Phone = new System.Windows.Forms.Label();
            this.TB_Phone = new System.Windows.Forms.TextBox();
            this.lb_Email = new System.Windows.Forms.Label();
            this.TB_Email = new System.Windows.Forms.TextBox();
            this.lb_Address = new System.Windows.Forms.Label();
            this.RTB_Address = new System.Windows.Forms.RichTextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(12, 39);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(34, 13);
            this.lb_Name.TabIndex = 0;
            this.lb_Name.Text = "ФИО";
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(53, 35);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.ReadOnly = true;
            this.TB_Name.Size = new System.Drawing.Size(258, 20);
            this.TB_Name.TabIndex = 1;
            // 
            // lb_Birthday
            // 
            this.lb_Birthday.AutoSize = true;
            this.lb_Birthday.Location = new System.Drawing.Point(13, 70);
            this.lb_Birthday.Name = "lb_Birthday";
            this.lb_Birthday.Size = new System.Drawing.Size(87, 13);
            this.lb_Birthday.TabIndex = 2;
            this.lb_Birthday.Text = "Дата Рождения";
            // 
            // TB_Birth
            // 
            this.TB_Birth.Location = new System.Drawing.Point(106, 67);
            this.TB_Birth.Name = "TB_Birth";
            this.TB_Birth.ReadOnly = true;
            this.TB_Birth.Size = new System.Drawing.Size(133, 20);
            this.TB_Birth.TabIndex = 13;
            // 
            // lb_Phone
            // 
            this.lb_Phone.AutoSize = true;
            this.lb_Phone.Location = new System.Drawing.Point(12, 102);
            this.lb_Phone.Name = "lb_Phone";
            this.lb_Phone.Size = new System.Drawing.Size(107, 13);
            this.lb_Phone.TabIndex = 14;
            this.lb_Phone.Text = "Телефонный номер";
            // 
            // TB_Phone
            // 
            this.TB_Phone.Location = new System.Drawing.Point(126, 102);
            this.TB_Phone.Name = "TB_Phone";
            this.TB_Phone.ReadOnly = true;
            this.TB_Phone.Size = new System.Drawing.Size(185, 20);
            this.TB_Phone.TabIndex = 15;
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Location = new System.Drawing.Point(15, 134);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(34, 13);
            this.lb_Email.TabIndex = 16;
            this.lb_Email.Text = "e-mail";
            // 
            // TB_Email
            // 
            this.TB_Email.Location = new System.Drawing.Point(56, 134);
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.ReadOnly = true;
            this.TB_Email.Size = new System.Drawing.Size(255, 20);
            this.TB_Email.TabIndex = 17;
            // 
            // lb_Address
            // 
            this.lb_Address.AutoSize = true;
            this.lb_Address.Location = new System.Drawing.Point(13, 162);
            this.lb_Address.Name = "lb_Address";
            this.lb_Address.Size = new System.Drawing.Size(38, 13);
            this.lb_Address.TabIndex = 18;
            this.lb_Address.Text = "Адрес";
            // 
            // RTB_Address
            // 
            this.RTB_Address.Location = new System.Drawing.Point(58, 162);
            this.RTB_Address.Name = "RTB_Address";
            this.RTB_Address.ReadOnly = true;
            this.RTB_Address.Size = new System.Drawing.Size(253, 96);
            this.RTB_Address.TabIndex = 19;
            this.RTB_Address.Text = "";
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(235, 296);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 21;
            this.btn_OK.Text = "ОК";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // Librarian_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 331);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.RTB_Address);
            this.Controls.Add(this.lb_Address);
            this.Controls.Add(this.TB_Email);
            this.Controls.Add(this.lb_Email);
            this.Controls.Add(this.TB_Phone);
            this.Controls.Add(this.lb_Phone);
            this.Controls.Add(this.TB_Birth);
            this.Controls.Add(this.lb_Birthday);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.lb_Name);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Librarian_Account";
            this.Text = "Librarian_Account";
            this.Load += new System.EventHandler(this.Librarian_Account_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Label lb_Birthday;
        private System.Windows.Forms.TextBox TB_Birth;
        private System.Windows.Forms.Label lb_Phone;
        private System.Windows.Forms.TextBox TB_Phone;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.TextBox TB_Email;
        private System.Windows.Forms.Label lb_Address;
        private System.Windows.Forms.RichTextBox RTB_Address;
        private System.Windows.Forms.Button btn_OK;
    }
}