namespace Program
{
    partial class GiveBook
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
            this.lb_BookID = new System.Windows.Forms.Label();
            this.TB_BookID = new System.Windows.Forms.TextBox();
            this.lb_ReaderTicket = new System.Windows.Forms.Label();
            this.TB_LibraryTicket = new System.Windows.Forms.TextBox();
            this.lb_StaffID = new System.Windows.Forms.Label();
            this.TB_StaffID = new System.Windows.Forms.TextBox();
            this.lb_GiveDate = new System.Windows.Forms.Label();
            this.TB_GiveDay = new System.Windows.Forms.TextBox();
            this.lb_GivenUntil = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.DTP_GiveDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lb_BookID
            // 
            this.lb_BookID.AutoSize = true;
            this.lb_BookID.Location = new System.Drawing.Point(13, 13);
            this.lb_BookID.Name = "lb_BookID";
            this.lb_BookID.Size = new System.Drawing.Size(108, 13);
            this.lb_BookID.TabIndex = 0;
            this.lb_BookID.Text = "Идент. номер книги";
            // 
            // TB_BookID
            // 
            this.TB_BookID.Location = new System.Drawing.Point(128, 10);
            this.TB_BookID.Name = "TB_BookID";
            this.TB_BookID.Size = new System.Drawing.Size(153, 20);
            this.TB_BookID.TabIndex = 1;
            this.TB_BookID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_BookID_KeyPress);
            this.TB_BookID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TB_BookID_KeyUp);
            // 
            // lb_ReaderTicket
            // 
            this.lb_ReaderTicket.AutoSize = true;
            this.lb_ReaderTicket.Location = new System.Drawing.Point(16, 39);
            this.lb_ReaderTicket.Name = "lb_ReaderTicket";
            this.lb_ReaderTicket.Size = new System.Drawing.Size(101, 13);
            this.lb_ReaderTicket.TabIndex = 2;
            this.lb_ReaderTicket.Text = "Номер чит. билета";
            // 
            // TB_LibraryTicket
            // 
            this.TB_LibraryTicket.Location = new System.Drawing.Point(128, 39);
            this.TB_LibraryTicket.Name = "TB_LibraryTicket";
            this.TB_LibraryTicket.ReadOnly = true;
            this.TB_LibraryTicket.Size = new System.Drawing.Size(153, 20);
            this.TB_LibraryTicket.TabIndex = 3;
            // 
            // lb_StaffID
            // 
            this.lb_StaffID.AutoSize = true;
            this.lb_StaffID.Location = new System.Drawing.Point(13, 72);
            this.lb_StaffID.Name = "lb_StaffID";
            this.lb_StaffID.Size = new System.Drawing.Size(161, 13);
            this.lb_StaffID.TabIndex = 4;
            this.lb_StaffID.Text = "Штатный номер библиотекаря";
            // 
            // TB_StaffID
            // 
            this.TB_StaffID.Location = new System.Drawing.Point(181, 70);
            this.TB_StaffID.Name = "TB_StaffID";
            this.TB_StaffID.ReadOnly = true;
            this.TB_StaffID.Size = new System.Drawing.Size(100, 20);
            this.TB_StaffID.TabIndex = 5;
            // 
            // lb_GiveDate
            // 
            this.lb_GiveDate.AutoSize = true;
            this.lb_GiveDate.Location = new System.Drawing.Point(16, 104);
            this.lb_GiveDate.Name = "lb_GiveDate";
            this.lb_GiveDate.Size = new System.Drawing.Size(73, 13);
            this.lb_GiveDate.TabIndex = 6;
            this.lb_GiveDate.Text = "Дата выдачи";
            // 
            // TB_GiveDay
            // 
            this.TB_GiveDay.Location = new System.Drawing.Point(95, 101);
            this.TB_GiveDay.Name = "TB_GiveDay";
            this.TB_GiveDay.ReadOnly = true;
            this.TB_GiveDay.Size = new System.Drawing.Size(186, 20);
            this.TB_GiveDay.TabIndex = 7;
            // 
            // lb_GivenUntil
            // 
            this.lb_GivenUntil.AutoSize = true;
            this.lb_GivenUntil.Location = new System.Drawing.Point(16, 138);
            this.lb_GivenUntil.Name = "lb_GivenUntil";
            this.lb_GivenUntil.Size = new System.Drawing.Size(64, 13);
            this.lb_GivenUntil.TabIndex = 8;
            this.lb_GivenUntil.Text = "Выдано до:";
            // 
            // btn_OK
            // 
            this.btn_OK.Enabled = false;
            this.btn_OK.Location = new System.Drawing.Point(191, 224);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(106, 23);
            this.btn_OK.TabIndex = 14;
            this.btn_OK.Text = "Выдать книгу";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(13, 223);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 15;
            this.btn_Cancel.Text = "Отмена";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // DTP_GiveDate
            // 
            this.DTP_GiveDate.Location = new System.Drawing.Point(81, 136);
            this.DTP_GiveDate.Name = "DTP_GiveDate";
            this.DTP_GiveDate.Size = new System.Drawing.Size(200, 20);
            this.DTP_GiveDate.TabIndex = 16;
            this.DTP_GiveDate.ValueChanged += new System.EventHandler(this.DTP_GiveDate_ValueChanged);
            // 
            // GiveBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 259);
            this.Controls.Add(this.DTP_GiveDate);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.lb_GivenUntil);
            this.Controls.Add(this.TB_GiveDay);
            this.Controls.Add(this.lb_GiveDate);
            this.Controls.Add(this.TB_StaffID);
            this.Controls.Add(this.lb_StaffID);
            this.Controls.Add(this.TB_LibraryTicket);
            this.Controls.Add(this.lb_ReaderTicket);
            this.Controls.Add(this.TB_BookID);
            this.Controls.Add(this.lb_BookID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GiveBook";
            this.Text = "Выдача книги";
            this.Load += new System.EventHandler(this.GiveBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_BookID;
        private System.Windows.Forms.TextBox TB_BookID;
        private System.Windows.Forms.Label lb_ReaderTicket;
        private System.Windows.Forms.TextBox TB_LibraryTicket;
        private System.Windows.Forms.Label lb_StaffID;
        private System.Windows.Forms.TextBox TB_StaffID;
        private System.Windows.Forms.Label lb_GiveDate;
        private System.Windows.Forms.TextBox TB_GiveDay;
        private System.Windows.Forms.Label lb_GivenUntil;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.DateTimePicker DTP_GiveDate;
    }
}