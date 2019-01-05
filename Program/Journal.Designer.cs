namespace Program
{
    partial class Journal
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
            this.DGV_Journal = new System.Windows.Forms.DataGridView();
            this.CB_BookID = new System.Windows.Forms.CheckBox();
            this.TB_BookID = new System.Windows.Forms.TextBox();
            this.CB_ReaderTicket = new System.Windows.Forms.CheckBox();
            this.TB_ReaderTicket = new System.Windows.Forms.TextBox();
            this.CB_GiverStaffNumber = new System.Windows.Forms.CheckBox();
            this.TB_GiverStaffNumber = new System.Windows.Forms.TextBox();
            this.CB_RecieverStaffNumber = new System.Windows.Forms.CheckBox();
            this.TB_RecieverStaffNumber = new System.Windows.Forms.TextBox();
            this.CB_GiveDate = new System.Windows.Forms.CheckBox();
            this.TB_Year = new System.Windows.Forms.TextBox();
            this.CB_Month = new System.Windows.Forms.ComboBox();
            this.TB_Day = new System.Windows.Forms.TextBox();
            this.CB_ExpectedReturnDate = new System.Windows.Forms.CheckBox();
            this.TB_ExpectedYear = new System.Windows.Forms.TextBox();
            this.CB_ExpectedMonth = new System.Windows.Forms.ComboBox();
            this.TB_ExpectedDay = new System.Windows.Forms.TextBox();
            this.CB_RealReturnDate = new System.Windows.Forms.CheckBox();
            this.TB_RealYear = new System.Windows.Forms.TextBox();
            this.CB_RealMonth = new System.Windows.Forms.ComboBox();
            this.TB_RealDay = new System.Windows.Forms.TextBox();
            this.CB_PenaltySum = new System.Windows.Forms.CheckBox();
            this.CB_PenaltyInfo = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSM_Books = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Books_Name = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Books_Author = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Books_Producer = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Books_BBK = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Books_ISBN = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Books_Year = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Readers = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Readers_Name = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Readers_Birth = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Readers_Phone = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Readers_Email = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Readers_Address = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Librarian = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Librarian_Name = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Librarian_Phone = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Librarian_Address = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Librarian_Email = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Librarian_Birth = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Journal)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Journal
            // 
            this.DGV_Journal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Journal.Location = new System.Drawing.Point(163, 30);
            this.DGV_Journal.Name = "DGV_Journal";
            this.DGV_Journal.Size = new System.Drawing.Size(498, 416);
            this.DGV_Journal.TabIndex = 0;
            // 
            // CB_BookID
            // 
            this.CB_BookID.AutoSize = true;
            this.CB_BookID.Location = new System.Drawing.Point(13, 30);
            this.CB_BookID.Name = "CB_BookID";
            this.CB_BookID.Size = new System.Drawing.Size(69, 17);
            this.CB_BookID.TabIndex = 1;
            this.CB_BookID.Text = "ID книги";
            this.CB_BookID.UseVisualStyleBackColor = true;
            // 
            // TB_BookID
            // 
            this.TB_BookID.Location = new System.Drawing.Point(12, 53);
            this.TB_BookID.Name = "TB_BookID";
            this.TB_BookID.Size = new System.Drawing.Size(144, 20);
            this.TB_BookID.TabIndex = 2;
            // 
            // CB_ReaderTicket
            // 
            this.CB_ReaderTicket.AutoSize = true;
            this.CB_ReaderTicket.Location = new System.Drawing.Point(12, 80);
            this.CB_ReaderTicket.Name = "CB_ReaderTicket";
            this.CB_ReaderTicket.Size = new System.Drawing.Size(124, 17);
            this.CB_ReaderTicket.TabIndex = 3;
            this.CB_ReaderTicket.Text = "Номер Чит. Билета";
            this.CB_ReaderTicket.UseVisualStyleBackColor = true;
            // 
            // TB_ReaderTicket
            // 
            this.TB_ReaderTicket.Location = new System.Drawing.Point(12, 104);
            this.TB_ReaderTicket.Name = "TB_ReaderTicket";
            this.TB_ReaderTicket.Size = new System.Drawing.Size(144, 20);
            this.TB_ReaderTicket.TabIndex = 4;
            // 
            // CB_GiverStaffNumber
            // 
            this.CB_GiverStaffNumber.AutoSize = true;
            this.CB_GiverStaffNumber.Location = new System.Drawing.Point(13, 131);
            this.CB_GiverStaffNumber.Name = "CB_GiverStaffNumber";
            this.CB_GiverStaffNumber.Size = new System.Drawing.Size(138, 17);
            this.CB_GiverStaffNumber.TabIndex = 5;
            this.CB_GiverStaffNumber.Text = "Шт. номер выдавшего";
            this.CB_GiverStaffNumber.UseVisualStyleBackColor = true;
            // 
            // TB_GiverStaffNumber
            // 
            this.TB_GiverStaffNumber.Location = new System.Drawing.Point(13, 155);
            this.TB_GiverStaffNumber.Name = "TB_GiverStaffNumber";
            this.TB_GiverStaffNumber.Size = new System.Drawing.Size(143, 20);
            this.TB_GiverStaffNumber.TabIndex = 6;
            // 
            // CB_RecieverStaffNumber
            // 
            this.CB_RecieverStaffNumber.AutoSize = true;
            this.CB_RecieverStaffNumber.Location = new System.Drawing.Point(13, 182);
            this.CB_RecieverStaffNumber.Name = "CB_RecieverStaffNumber";
            this.CB_RecieverStaffNumber.Size = new System.Drawing.Size(142, 17);
            this.CB_RecieverStaffNumber.TabIndex = 7;
            this.CB_RecieverStaffNumber.Text = "Шт. номер принявшего";
            this.CB_RecieverStaffNumber.UseVisualStyleBackColor = true;
            // 
            // TB_RecieverStaffNumber
            // 
            this.TB_RecieverStaffNumber.Location = new System.Drawing.Point(13, 206);
            this.TB_RecieverStaffNumber.Name = "TB_RecieverStaffNumber";
            this.TB_RecieverStaffNumber.Size = new System.Drawing.Size(143, 20);
            this.TB_RecieverStaffNumber.TabIndex = 8;
            // 
            // CB_GiveDate
            // 
            this.CB_GiveDate.AutoSize = true;
            this.CB_GiveDate.Location = new System.Drawing.Point(13, 233);
            this.CB_GiveDate.Name = "CB_GiveDate";
            this.CB_GiveDate.Size = new System.Drawing.Size(92, 17);
            this.CB_GiveDate.TabIndex = 9;
            this.CB_GiveDate.Text = "Дата выдачи";
            this.CB_GiveDate.UseVisualStyleBackColor = true;
            // 
            // TB_Year
            // 
            this.TB_Year.Location = new System.Drawing.Point(117, 256);
            this.TB_Year.Name = "TB_Year";
            this.TB_Year.Size = new System.Drawing.Size(39, 20);
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
            this.CB_Month.Location = new System.Drawing.Point(38, 256);
            this.CB_Month.Name = "CB_Month";
            this.CB_Month.Size = new System.Drawing.Size(73, 21);
            this.CB_Month.TabIndex = 12;
            // 
            // TB_Day
            // 
            this.TB_Day.Location = new System.Drawing.Point(12, 256);
            this.TB_Day.Name = "TB_Day";
            this.TB_Day.Size = new System.Drawing.Size(20, 20);
            this.TB_Day.TabIndex = 11;
            // 
            // CB_ExpectedReturnDate
            // 
            this.CB_ExpectedReturnDate.AutoSize = true;
            this.CB_ExpectedReturnDate.Location = new System.Drawing.Point(12, 283);
            this.CB_ExpectedReturnDate.Name = "CB_ExpectedReturnDate";
            this.CB_ExpectedReturnDate.Size = new System.Drawing.Size(144, 17);
            this.CB_ExpectedReturnDate.TabIndex = 14;
            this.CB_ExpectedReturnDate.Text = "Ожидаемая дата сдачи";
            this.CB_ExpectedReturnDate.UseVisualStyleBackColor = true;
            // 
            // TB_ExpectedYear
            // 
            this.TB_ExpectedYear.Location = new System.Drawing.Point(117, 306);
            this.TB_ExpectedYear.Name = "TB_ExpectedYear";
            this.TB_ExpectedYear.Size = new System.Drawing.Size(39, 20);
            this.TB_ExpectedYear.TabIndex = 17;
            // 
            // CB_ExpectedMonth
            // 
            this.CB_ExpectedMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_ExpectedMonth.FormattingEnabled = true;
            this.CB_ExpectedMonth.Items.AddRange(new object[] {
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
            this.CB_ExpectedMonth.Location = new System.Drawing.Point(38, 306);
            this.CB_ExpectedMonth.Name = "CB_ExpectedMonth";
            this.CB_ExpectedMonth.Size = new System.Drawing.Size(73, 21);
            this.CB_ExpectedMonth.TabIndex = 16;
            // 
            // TB_ExpectedDay
            // 
            this.TB_ExpectedDay.Location = new System.Drawing.Point(12, 306);
            this.TB_ExpectedDay.Name = "TB_ExpectedDay";
            this.TB_ExpectedDay.Size = new System.Drawing.Size(20, 20);
            this.TB_ExpectedDay.TabIndex = 15;
            // 
            // CB_RealReturnDate
            // 
            this.CB_RealReturnDate.AutoSize = true;
            this.CB_RealReturnDate.Location = new System.Drawing.Point(12, 333);
            this.CB_RealReturnDate.Name = "CB_RealReturnDate";
            this.CB_RealReturnDate.Size = new System.Drawing.Size(133, 17);
            this.CB_RealReturnDate.TabIndex = 18;
            this.CB_RealReturnDate.Text = "Реальная дата сдачи";
            this.CB_RealReturnDate.UseVisualStyleBackColor = true;
            // 
            // TB_RealYear
            // 
            this.TB_RealYear.Location = new System.Drawing.Point(117, 356);
            this.TB_RealYear.Name = "TB_RealYear";
            this.TB_RealYear.Size = new System.Drawing.Size(39, 20);
            this.TB_RealYear.TabIndex = 21;
            // 
            // CB_RealMonth
            // 
            this.CB_RealMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_RealMonth.FormattingEnabled = true;
            this.CB_RealMonth.Items.AddRange(new object[] {
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
            this.CB_RealMonth.Location = new System.Drawing.Point(38, 356);
            this.CB_RealMonth.Name = "CB_RealMonth";
            this.CB_RealMonth.Size = new System.Drawing.Size(73, 21);
            this.CB_RealMonth.TabIndex = 20;
            // 
            // TB_RealDay
            // 
            this.TB_RealDay.Location = new System.Drawing.Point(12, 356);
            this.TB_RealDay.Name = "TB_RealDay";
            this.TB_RealDay.Size = new System.Drawing.Size(20, 20);
            this.TB_RealDay.TabIndex = 19;
            // 
            // CB_PenaltySum
            // 
            this.CB_PenaltySum.AutoSize = true;
            this.CB_PenaltySum.Location = new System.Drawing.Point(12, 383);
            this.CB_PenaltySum.Name = "CB_PenaltySum";
            this.CB_PenaltySum.Size = new System.Drawing.Size(102, 17);
            this.CB_PenaltySum.TabIndex = 22;
            this.CB_PenaltySum.Text = "Сумма штрафа";
            this.CB_PenaltySum.UseVisualStyleBackColor = true;
            // 
            // CB_PenaltyInfo
            // 
            this.CB_PenaltyInfo.AutoSize = true;
            this.CB_PenaltyInfo.Location = new System.Drawing.Point(12, 407);
            this.CB_PenaltyInfo.Name = "CB_PenaltyInfo";
            this.CB_PenaltyInfo.Size = new System.Drawing.Size(102, 17);
            this.CB_PenaltyInfo.TabIndex = 23;
            this.CB_PenaltyInfo.Text = "Инф. о штрафе";
            this.CB_PenaltyInfo.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_Books,
            this.TSM_Readers,
            this.TSM_Librarian});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(673, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSM_Books
            // 
            this.TSM_Books.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_Books_Name,
            this.TSM_Books_Author,
            this.TSM_Books_Producer,
            this.TSM_Books_BBK,
            this.TSM_Books_ISBN,
            this.TSM_Books_Year});
            this.TSM_Books.Name = "TSM_Books";
            this.TSM_Books.Size = new System.Drawing.Size(52, 20);
            this.TSM_Books.Text = "Книги";
            // 
            // TSM_Books_Name
            // 
            this.TSM_Books_Name.Name = "TSM_Books_Name";
            this.TSM_Books_Name.Size = new System.Drawing.Size(180, 22);
            this.TSM_Books_Name.Text = "Название";
            // 
            // TSM_Books_Author
            // 
            this.TSM_Books_Author.Name = "TSM_Books_Author";
            this.TSM_Books_Author.Size = new System.Drawing.Size(180, 22);
            this.TSM_Books_Author.Text = "Автор";
            // 
            // TSM_Books_Producer
            // 
            this.TSM_Books_Producer.Name = "TSM_Books_Producer";
            this.TSM_Books_Producer.Size = new System.Drawing.Size(180, 22);
            this.TSM_Books_Producer.Text = "Издательство";
            // 
            // TSM_Books_BBK
            // 
            this.TSM_Books_BBK.Name = "TSM_Books_BBK";
            this.TSM_Books_BBK.Size = new System.Drawing.Size(180, 22);
            this.TSM_Books_BBK.Text = "ББК";
            // 
            // TSM_Books_ISBN
            // 
            this.TSM_Books_ISBN.Name = "TSM_Books_ISBN";
            this.TSM_Books_ISBN.Size = new System.Drawing.Size(180, 22);
            this.TSM_Books_ISBN.Text = "ISBN/ISSN";
            // 
            // TSM_Books_Year
            // 
            this.TSM_Books_Year.Name = "TSM_Books_Year";
            this.TSM_Books_Year.Size = new System.Drawing.Size(180, 22);
            this.TSM_Books_Year.Text = "Год издания";
            // 
            // TSM_Readers
            // 
            this.TSM_Readers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_Readers_Name,
            this.TSM_Readers_Birth,
            this.TSM_Readers_Phone,
            this.TSM_Readers_Email,
            this.TSM_Readers_Address});
            this.TSM_Readers.Name = "TSM_Readers";
            this.TSM_Readers.Size = new System.Drawing.Size(70, 20);
            this.TSM_Readers.Text = "Читатели";
            // 
            // TSM_Readers_Name
            // 
            this.TSM_Readers_Name.Name = "TSM_Readers_Name";
            this.TSM_Readers_Name.Size = new System.Drawing.Size(180, 22);
            this.TSM_Readers_Name.Text = "ФИО";
            // 
            // TSM_Readers_Birth
            // 
            this.TSM_Readers_Birth.Name = "TSM_Readers_Birth";
            this.TSM_Readers_Birth.Size = new System.Drawing.Size(180, 22);
            this.TSM_Readers_Birth.Text = "Дата рождения";
            // 
            // TSM_Readers_Phone
            // 
            this.TSM_Readers_Phone.Name = "TSM_Readers_Phone";
            this.TSM_Readers_Phone.Size = new System.Drawing.Size(180, 22);
            this.TSM_Readers_Phone.Text = "Телефон";
            // 
            // TSM_Readers_Email
            // 
            this.TSM_Readers_Email.Name = "TSM_Readers_Email";
            this.TSM_Readers_Email.Size = new System.Drawing.Size(180, 22);
            this.TSM_Readers_Email.Text = "E-mail";
            // 
            // TSM_Readers_Address
            // 
            this.TSM_Readers_Address.Name = "TSM_Readers_Address";
            this.TSM_Readers_Address.Size = new System.Drawing.Size(180, 22);
            this.TSM_Readers_Address.Text = "Адрес";
            // 
            // TSM_Librarian
            // 
            this.TSM_Librarian.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_Librarian_Name,
            this.TSM_Librarian_Birth,
            this.TSM_Librarian_Phone,
            this.TSM_Librarian_Email,
            this.TSM_Librarian_Address});
            this.TSM_Librarian.Name = "TSM_Librarian";
            this.TSM_Librarian.Size = new System.Drawing.Size(98, 20);
            this.TSM_Librarian.Text = "Библиотекари";
            // 
            // TSM_Librarian_Name
            // 
            this.TSM_Librarian_Name.Name = "TSM_Librarian_Name";
            this.TSM_Librarian_Name.Size = new System.Drawing.Size(180, 22);
            this.TSM_Librarian_Name.Text = "ФИО";
            // 
            // TSM_Librarian_Phone
            // 
            this.TSM_Librarian_Phone.Name = "TSM_Librarian_Phone";
            this.TSM_Librarian_Phone.Size = new System.Drawing.Size(180, 22);
            this.TSM_Librarian_Phone.Text = "Телефон";
            // 
            // TSM_Librarian_Address
            // 
            this.TSM_Librarian_Address.Name = "TSM_Librarian_Address";
            this.TSM_Librarian_Address.Size = new System.Drawing.Size(180, 22);
            this.TSM_Librarian_Address.Text = "Адрес";
            // 
            // TSM_Librarian_Email
            // 
            this.TSM_Librarian_Email.Name = "TSM_Librarian_Email";
            this.TSM_Librarian_Email.Size = new System.Drawing.Size(180, 22);
            this.TSM_Librarian_Email.Text = "E-mail";
            // 
            // TSM_Librarian_Birth
            // 
            this.TSM_Librarian_Birth.Name = "TSM_Librarian_Birth";
            this.TSM_Librarian_Birth.Size = new System.Drawing.Size(180, 22);
            this.TSM_Librarian_Birth.Text = "Дата рождения";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(586, 473);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 25;
            this.btn_Close.Text = "Закрыть";
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // Journal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 508);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.CB_PenaltyInfo);
            this.Controls.Add(this.CB_PenaltySum);
            this.Controls.Add(this.TB_RealYear);
            this.Controls.Add(this.CB_RealMonth);
            this.Controls.Add(this.TB_RealDay);
            this.Controls.Add(this.CB_RealReturnDate);
            this.Controls.Add(this.TB_ExpectedYear);
            this.Controls.Add(this.CB_ExpectedMonth);
            this.Controls.Add(this.TB_ExpectedDay);
            this.Controls.Add(this.CB_ExpectedReturnDate);
            this.Controls.Add(this.TB_Year);
            this.Controls.Add(this.CB_Month);
            this.Controls.Add(this.TB_Day);
            this.Controls.Add(this.CB_GiveDate);
            this.Controls.Add(this.TB_RecieverStaffNumber);
            this.Controls.Add(this.CB_RecieverStaffNumber);
            this.Controls.Add(this.TB_GiverStaffNumber);
            this.Controls.Add(this.CB_GiverStaffNumber);
            this.Controls.Add(this.TB_ReaderTicket);
            this.Controls.Add(this.CB_ReaderTicket);
            this.Controls.Add(this.TB_BookID);
            this.Controls.Add(this.CB_BookID);
            this.Controls.Add(this.DGV_Journal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Journal";
            this.Text = "Журнал выдачи книг";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Journal)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Journal;
        private System.Windows.Forms.CheckBox CB_BookID;
        private System.Windows.Forms.TextBox TB_BookID;
        private System.Windows.Forms.CheckBox CB_ReaderTicket;
        private System.Windows.Forms.TextBox TB_ReaderTicket;
        private System.Windows.Forms.CheckBox CB_GiverStaffNumber;
        private System.Windows.Forms.TextBox TB_GiverStaffNumber;
        private System.Windows.Forms.CheckBox CB_RecieverStaffNumber;
        private System.Windows.Forms.TextBox TB_RecieverStaffNumber;
        private System.Windows.Forms.CheckBox CB_GiveDate;
        private System.Windows.Forms.TextBox TB_Year;
        private System.Windows.Forms.ComboBox CB_Month;
        private System.Windows.Forms.TextBox TB_Day;
        private System.Windows.Forms.CheckBox CB_ExpectedReturnDate;
        private System.Windows.Forms.TextBox TB_ExpectedYear;
        private System.Windows.Forms.ComboBox CB_ExpectedMonth;
        private System.Windows.Forms.TextBox TB_ExpectedDay;
        private System.Windows.Forms.CheckBox CB_RealReturnDate;
        private System.Windows.Forms.TextBox TB_RealYear;
        private System.Windows.Forms.ComboBox CB_RealMonth;
        private System.Windows.Forms.TextBox TB_RealDay;
        private System.Windows.Forms.CheckBox CB_PenaltySum;
        private System.Windows.Forms.CheckBox CB_PenaltyInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSM_Books;
        private System.Windows.Forms.ToolStripMenuItem TSM_Books_Name;
        private System.Windows.Forms.ToolStripMenuItem TSM_Books_Author;
        private System.Windows.Forms.ToolStripMenuItem TSM_Books_Producer;
        private System.Windows.Forms.ToolStripMenuItem TSM_Books_BBK;
        private System.Windows.Forms.ToolStripMenuItem TSM_Books_ISBN;
        private System.Windows.Forms.ToolStripMenuItem TSM_Books_Year;
        private System.Windows.Forms.ToolStripMenuItem TSM_Readers;
        private System.Windows.Forms.ToolStripMenuItem TSM_Readers_Name;
        private System.Windows.Forms.ToolStripMenuItem TSM_Readers_Birth;
        private System.Windows.Forms.ToolStripMenuItem TSM_Readers_Phone;
        private System.Windows.Forms.ToolStripMenuItem TSM_Readers_Email;
        private System.Windows.Forms.ToolStripMenuItem TSM_Readers_Address;
        private System.Windows.Forms.ToolStripMenuItem TSM_Librarian;
        private System.Windows.Forms.ToolStripMenuItem TSM_Librarian_Name;
        private System.Windows.Forms.ToolStripMenuItem TSM_Librarian_Birth;
        private System.Windows.Forms.ToolStripMenuItem TSM_Librarian_Phone;
        private System.Windows.Forms.ToolStripMenuItem TSM_Librarian_Email;
        private System.Windows.Forms.ToolStripMenuItem TSM_Librarian_Address;
        private System.Windows.Forms.Button btn_Close;
    }
}