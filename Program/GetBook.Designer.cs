namespace Program
{
    partial class GetBook
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
            this.TB_GivenUntil = new System.Windows.Forms.TextBox();
            this.lb_GivenUntil = new System.Windows.Forms.Label();
            this.TB_GiveDay = new System.Windows.Forms.TextBox();
            this.lb_GiveDate = new System.Windows.Forms.Label();
            this.TB_StaffID = new System.Windows.Forms.TextBox();
            this.lb_StaffID = new System.Windows.Forms.Label();
            this.TB_LibraryTicket = new System.Windows.Forms.TextBox();
            this.lb_ReaderTicket = new System.Windows.Forms.Label();
            this.TB_BookID = new System.Windows.Forms.TextBox();
            this.lb_BookID = new System.Windows.Forms.Label();
            this.lb_Get = new System.Windows.Forms.Label();
            this.TB_Got = new System.Windows.Forms.TextBox();
            this.CB_Penalty = new System.Windows.Forms.CheckBox();
            this.lb_PaySum = new System.Windows.Forms.Label();
            this.TB_PaySum = new System.Windows.Forms.TextBox();
            this.lb_Currency = new System.Windows.Forms.Label();
            this.lb_PenaltyInfo = new System.Windows.Forms.Label();
            this.RTB_PenaltyInfo = new System.Windows.Forms.RichTextBox();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_GivenUntil
            // 
            this.TB_GivenUntil.Location = new System.Drawing.Point(94, 167);
            this.TB_GivenUntil.Name = "TB_GivenUntil";
            this.TB_GivenUntil.ReadOnly = true;
            this.TB_GivenUntil.Size = new System.Drawing.Size(186, 20);
            this.TB_GivenUntil.TabIndex = 23;
            this.TB_GivenUntil.Visible = false;
            // 
            // lb_GivenUntil
            // 
            this.lb_GivenUntil.AutoSize = true;
            this.lb_GivenUntil.Location = new System.Drawing.Point(15, 170);
            this.lb_GivenUntil.Name = "lb_GivenUntil";
            this.lb_GivenUntil.Size = new System.Drawing.Size(64, 13);
            this.lb_GivenUntil.TabIndex = 22;
            this.lb_GivenUntil.Text = "Выдано до:";
            this.lb_GivenUntil.Visible = false;
            // 
            // TB_GiveDay
            // 
            this.TB_GiveDay.Location = new System.Drawing.Point(94, 133);
            this.TB_GiveDay.Name = "TB_GiveDay";
            this.TB_GiveDay.ReadOnly = true;
            this.TB_GiveDay.Size = new System.Drawing.Size(186, 20);
            this.TB_GiveDay.TabIndex = 21;
            this.TB_GiveDay.Visible = false;
            // 
            // lb_GiveDate
            // 
            this.lb_GiveDate.AutoSize = true;
            this.lb_GiveDate.Location = new System.Drawing.Point(15, 136);
            this.lb_GiveDate.Name = "lb_GiveDate";
            this.lb_GiveDate.Size = new System.Drawing.Size(73, 13);
            this.lb_GiveDate.TabIndex = 20;
            this.lb_GiveDate.Text = "Дата выдачи";
            this.lb_GiveDate.Visible = false;
            // 
            // TB_StaffID
            // 
            this.TB_StaffID.Location = new System.Drawing.Point(180, 102);
            this.TB_StaffID.Name = "TB_StaffID";
            this.TB_StaffID.ReadOnly = true;
            this.TB_StaffID.Size = new System.Drawing.Size(100, 20);
            this.TB_StaffID.TabIndex = 19;
            this.TB_StaffID.Visible = false;
            // 
            // lb_StaffID
            // 
            this.lb_StaffID.AutoSize = true;
            this.lb_StaffID.Location = new System.Drawing.Point(12, 104);
            this.lb_StaffID.Name = "lb_StaffID";
            this.lb_StaffID.Size = new System.Drawing.Size(161, 13);
            this.lb_StaffID.TabIndex = 18;
            this.lb_StaffID.Text = "Штатный номер библиотекаря";
            this.lb_StaffID.Visible = false;
            // 
            // TB_LibraryTicket
            // 
            this.TB_LibraryTicket.Location = new System.Drawing.Point(127, 71);
            this.TB_LibraryTicket.Name = "TB_LibraryTicket";
            this.TB_LibraryTicket.ReadOnly = true;
            this.TB_LibraryTicket.Size = new System.Drawing.Size(153, 20);
            this.TB_LibraryTicket.TabIndex = 17;
            this.TB_LibraryTicket.Visible = false;
            // 
            // lb_ReaderTicket
            // 
            this.lb_ReaderTicket.AutoSize = true;
            this.lb_ReaderTicket.Location = new System.Drawing.Point(15, 71);
            this.lb_ReaderTicket.Name = "lb_ReaderTicket";
            this.lb_ReaderTicket.Size = new System.Drawing.Size(101, 13);
            this.lb_ReaderTicket.TabIndex = 16;
            this.lb_ReaderTicket.Text = "Номер чит. билета";
            this.lb_ReaderTicket.Visible = false;
            // 
            // TB_BookID
            // 
            this.TB_BookID.Location = new System.Drawing.Point(127, 6);
            this.TB_BookID.Name = "TB_BookID";
            this.TB_BookID.Size = new System.Drawing.Size(153, 20);
            this.TB_BookID.TabIndex = 15;
            this.TB_BookID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_BookID_KeyPress);
            this.TB_BookID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TB_BookID_KeyUp);
            // 
            // lb_BookID
            // 
            this.lb_BookID.AutoSize = true;
            this.lb_BookID.Location = new System.Drawing.Point(12, 9);
            this.lb_BookID.Name = "lb_BookID";
            this.lb_BookID.Size = new System.Drawing.Size(108, 13);
            this.lb_BookID.TabIndex = 14;
            this.lb_BookID.Text = "Идент. номер книги";
            // 
            // lb_Get
            // 
            this.lb_Get.AutoSize = true;
            this.lb_Get.Location = new System.Drawing.Point(15, 203);
            this.lb_Get.Name = "lb_Get";
            this.lb_Get.Size = new System.Drawing.Size(58, 13);
            this.lb_Get.TabIndex = 24;
            this.lb_Get.Text = "Получено:";
            this.lb_Get.Visible = false;
            // 
            // TB_Got
            // 
            this.TB_Got.Location = new System.Drawing.Point(94, 200);
            this.TB_Got.Name = "TB_Got";
            this.TB_Got.ReadOnly = true;
            this.TB_Got.Size = new System.Drawing.Size(186, 20);
            this.TB_Got.TabIndex = 25;
            this.TB_Got.Visible = false;
            // 
            // CB_Penalty
            // 
            this.CB_Penalty.AutoSize = true;
            this.CB_Penalty.Location = new System.Drawing.Point(18, 226);
            this.CB_Penalty.Name = "CB_Penalty";
            this.CB_Penalty.Size = new System.Drawing.Size(113, 17);
            this.CB_Penalty.TabIndex = 26;
            this.CB_Penalty.Text = "Наложить штраф";
            this.CB_Penalty.UseVisualStyleBackColor = true;
            this.CB_Penalty.Visible = false;
            this.CB_Penalty.CheckedChanged += new System.EventHandler(this.CB_Penalty_CheckedChanged);
            // 
            // lb_PaySum
            // 
            this.lb_PaySum.AutoSize = true;
            this.lb_PaySum.Location = new System.Drawing.Point(15, 256);
            this.lb_PaySum.Name = "lb_PaySum";
            this.lb_PaySum.Size = new System.Drawing.Size(86, 13);
            this.lb_PaySum.TabIndex = 27;
            this.lb_PaySum.Text = "Сумма штрафа:";
            this.lb_PaySum.Visible = false;
            // 
            // TB_PaySum
            // 
            this.TB_PaySum.Location = new System.Drawing.Point(107, 253);
            this.TB_PaySum.MaxLength = 18;
            this.TB_PaySum.Name = "TB_PaySum";
            this.TB_PaySum.Size = new System.Drawing.Size(135, 20);
            this.TB_PaySum.TabIndex = 28;
            this.TB_PaySum.Visible = false;
            this.TB_PaySum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_PaySum_KeyPress);
            this.TB_PaySum.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TB_PaySum_KeyUp);
            // 
            // lb_Currency
            // 
            this.lb_Currency.AutoSize = true;
            this.lb_Currency.Location = new System.Drawing.Point(242, 257);
            this.lb_Currency.Name = "lb_Currency";
            this.lb_Currency.Size = new System.Drawing.Size(27, 13);
            this.lb_Currency.TabIndex = 29;
            this.lb_Currency.Text = ".руб";
            this.lb_Currency.Visible = false;
            // 
            // lb_PenaltyInfo
            // 
            this.lb_PenaltyInfo.AutoSize = true;
            this.lb_PenaltyInfo.Location = new System.Drawing.Point(15, 281);
            this.lb_PenaltyInfo.Name = "lb_PenaltyInfo";
            this.lb_PenaltyInfo.Size = new System.Drawing.Size(127, 13);
            this.lb_PenaltyInfo.TabIndex = 30;
            this.lb_PenaltyInfo.Text = "Информация о штрафе:";
            this.lb_PenaltyInfo.Visible = false;
            // 
            // RTB_PenaltyInfo
            // 
            this.RTB_PenaltyInfo.Location = new System.Drawing.Point(18, 298);
            this.RTB_PenaltyInfo.MaxLength = 255;
            this.RTB_PenaltyInfo.Name = "RTB_PenaltyInfo";
            this.RTB_PenaltyInfo.Size = new System.Drawing.Size(262, 68);
            this.RTB_PenaltyInfo.TabIndex = 31;
            this.RTB_PenaltyInfo.Text = "";
            this.RTB_PenaltyInfo.Visible = false;
            this.RTB_PenaltyInfo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RTB_PenaltyInfo_KeyPress);
            // 
            // btn_Apply
            // 
            this.btn_Apply.Location = new System.Drawing.Point(205, 372);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(75, 23);
            this.btn_Apply.TabIndex = 32;
            this.btn_Apply.Text = "Принять";
            this.btn_Apply.UseVisualStyleBackColor = true;
            this.btn_Apply.Visible = false;
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(18, 33);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 33;
            this.btn_Back.Text = "Отмена";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(204, 33);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 34;
            this.btn_Search.Text = "Поиск";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.button1_Click);
            // 
            // GetBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 423);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.RTB_PenaltyInfo);
            this.Controls.Add(this.lb_PenaltyInfo);
            this.Controls.Add(this.lb_Currency);
            this.Controls.Add(this.TB_PaySum);
            this.Controls.Add(this.lb_PaySum);
            this.Controls.Add(this.CB_Penalty);
            this.Controls.Add(this.TB_Got);
            this.Controls.Add(this.lb_Get);
            this.Controls.Add(this.TB_GivenUntil);
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
            this.Name = "GetBook";
            this.Text = "Принять книгу";
            this.Load += new System.EventHandler(this.GetBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TB_GivenUntil;
        private System.Windows.Forms.Label lb_GivenUntil;
        private System.Windows.Forms.TextBox TB_GiveDay;
        private System.Windows.Forms.Label lb_GiveDate;
        private System.Windows.Forms.TextBox TB_StaffID;
        private System.Windows.Forms.Label lb_StaffID;
        private System.Windows.Forms.TextBox TB_LibraryTicket;
        private System.Windows.Forms.Label lb_ReaderTicket;
        private System.Windows.Forms.TextBox TB_BookID;
        private System.Windows.Forms.Label lb_BookID;
        private System.Windows.Forms.Label lb_Get;
        private System.Windows.Forms.TextBox TB_Got;
        private System.Windows.Forms.CheckBox CB_Penalty;
        private System.Windows.Forms.Label lb_PaySum;
        private System.Windows.Forms.TextBox TB_PaySum;
        private System.Windows.Forms.Label lb_Currency;
        private System.Windows.Forms.Label lb_PenaltyInfo;
        private System.Windows.Forms.RichTextBox RTB_PenaltyInfo;
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Search;
    }
}