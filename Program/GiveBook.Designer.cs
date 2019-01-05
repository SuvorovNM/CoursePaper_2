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
            this.TB_Year = new System.Windows.Forms.TextBox();
            this.CB_Month = new System.Windows.Forms.ComboBox();
            this.TB_Day = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
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
            // TB_Year
            // 
            this.TB_Year.Location = new System.Drawing.Point(191, 135);
            this.TB_Year.Name = "TB_Year";
            this.TB_Year.Size = new System.Drawing.Size(31, 20);
            this.TB_Year.TabIndex = 13;
            // 
            // CB_Month
            // 
            this.CB_Month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Month.FormattingEnabled = true;
            this.CB_Month.Items.AddRange(new object[] {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Март",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"});
            this.CB_Month.Location = new System.Drawing.Point(112, 135);
            this.CB_Month.Name = "CB_Month";
            this.CB_Month.Size = new System.Drawing.Size(73, 21);
            this.CB_Month.TabIndex = 12;
            // 
            // TB_Day
            // 
            this.TB_Day.Location = new System.Drawing.Point(86, 135);
            this.TB_Day.Name = "TB_Day";
            this.TB_Day.Size = new System.Drawing.Size(20, 20);
            this.TB_Day.TabIndex = 11;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(191, 224);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(106, 23);
            this.btn_OK.TabIndex = 14;
            this.btn_OK.Text = "Выдать книгу";
            this.btn_OK.UseVisualStyleBackColor = true;
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
            // GiveBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 259);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.TB_Year);
            this.Controls.Add(this.CB_Month);
            this.Controls.Add(this.TB_Day);
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
        private System.Windows.Forms.TextBox TB_Year;
        private System.Windows.Forms.ComboBox CB_Month;
        private System.Windows.Forms.TextBox TB_Day;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
    }
}