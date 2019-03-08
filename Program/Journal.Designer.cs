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
            this.CB_ExpectedReturnDate = new System.Windows.Forms.CheckBox();
            this.CB_RealReturnDate = new System.Windows.Forms.CheckBox();
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
            this.TSM_Librarian_Birth = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Librarian_Phone = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Librarian_Email = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Librarian_Address = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Close = new System.Windows.Forms.Button();
            this.DTP_GiveDate = new System.Windows.Forms.DateTimePicker();
            this.DTP_Expected_Date = new System.Windows.Forms.DateTimePicker();
            this.DTP_Real_Date = new System.Windows.Forms.DateTimePicker();
            this.CB_Filter_PubID = new System.Windows.Forms.CheckBox();
            this.CB_Filter_Reader_Ticket = new System.Windows.Forms.CheckBox();
            this.CB_Filter_Giver = new System.Windows.Forms.CheckBox();
            this.CB_Filter_Getter = new System.Windows.Forms.CheckBox();
            this.CB_Filter_Give_Date = new System.Windows.Forms.CheckBox();
            this.CB_Filter_Expected_Date = new System.Windows.Forms.CheckBox();
            this.CB_Filter_Real_Date = new System.Windows.Forms.CheckBox();
            this.CB_Filter_OperationID = new System.Windows.Forms.CheckBox();
            this.TB_OperationID = new System.Windows.Forms.TextBox();
            this.CB_OperationID = new System.Windows.Forms.CheckBox();
            this.btn_ApplyFilters = new System.Windows.Forms.Button();
            this.btn_CancelFilters = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Journal)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Journal
            // 
            this.DGV_Journal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Journal.Location = new System.Drawing.Point(180, 30);
            this.DGV_Journal.Name = "DGV_Journal";
            this.DGV_Journal.Size = new System.Drawing.Size(552, 472);
            this.DGV_Journal.TabIndex = 0;
            // 
            // CB_BookID
            // 
            this.CB_BookID.AutoSize = true;
            this.CB_BookID.Checked = true;
            this.CB_BookID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_BookID.Location = new System.Drawing.Point(13, 81);
            this.CB_BookID.Name = "CB_BookID";
            this.CB_BookID.Size = new System.Drawing.Size(69, 17);
            this.CB_BookID.TabIndex = 1;
            this.CB_BookID.Text = "ID книги";
            this.CB_BookID.UseVisualStyleBackColor = true;
            this.CB_BookID.CheckedChanged += new System.EventHandler(this.CB_BookID_CheckedChanged);
            // 
            // TB_BookID
            // 
            this.TB_BookID.Location = new System.Drawing.Point(12, 104);
            this.TB_BookID.Name = "TB_BookID";
            this.TB_BookID.Size = new System.Drawing.Size(144, 20);
            this.TB_BookID.TabIndex = 2;
            // 
            // CB_ReaderTicket
            // 
            this.CB_ReaderTicket.AutoSize = true;
            this.CB_ReaderTicket.Checked = true;
            this.CB_ReaderTicket.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_ReaderTicket.Location = new System.Drawing.Point(12, 131);
            this.CB_ReaderTicket.Name = "CB_ReaderTicket";
            this.CB_ReaderTicket.Size = new System.Drawing.Size(124, 17);
            this.CB_ReaderTicket.TabIndex = 3;
            this.CB_ReaderTicket.Text = "Номер Чит. Билета";
            this.CB_ReaderTicket.UseVisualStyleBackColor = true;
            this.CB_ReaderTicket.CheckedChanged += new System.EventHandler(this.CB_ReaderTicket_CheckedChanged);
            // 
            // TB_ReaderTicket
            // 
            this.TB_ReaderTicket.Location = new System.Drawing.Point(12, 155);
            this.TB_ReaderTicket.Name = "TB_ReaderTicket";
            this.TB_ReaderTicket.Size = new System.Drawing.Size(144, 20);
            this.TB_ReaderTicket.TabIndex = 4;
            // 
            // CB_GiverStaffNumber
            // 
            this.CB_GiverStaffNumber.AutoSize = true;
            this.CB_GiverStaffNumber.Location = new System.Drawing.Point(13, 182);
            this.CB_GiverStaffNumber.Name = "CB_GiverStaffNumber";
            this.CB_GiverStaffNumber.Size = new System.Drawing.Size(138, 17);
            this.CB_GiverStaffNumber.TabIndex = 5;
            this.CB_GiverStaffNumber.Text = "Шт. номер выдавшего";
            this.CB_GiverStaffNumber.UseVisualStyleBackColor = true;
            this.CB_GiverStaffNumber.CheckedChanged += new System.EventHandler(this.CB_GiverStaffNumber_CheckedChanged);
            // 
            // TB_GiverStaffNumber
            // 
            this.TB_GiverStaffNumber.Location = new System.Drawing.Point(13, 206);
            this.TB_GiverStaffNumber.Name = "TB_GiverStaffNumber";
            this.TB_GiverStaffNumber.Size = new System.Drawing.Size(143, 20);
            this.TB_GiverStaffNumber.TabIndex = 6;
            // 
            // CB_RecieverStaffNumber
            // 
            this.CB_RecieverStaffNumber.AutoSize = true;
            this.CB_RecieverStaffNumber.Location = new System.Drawing.Point(13, 233);
            this.CB_RecieverStaffNumber.Name = "CB_RecieverStaffNumber";
            this.CB_RecieverStaffNumber.Size = new System.Drawing.Size(142, 17);
            this.CB_RecieverStaffNumber.TabIndex = 7;
            this.CB_RecieverStaffNumber.Text = "Шт. номер принявшего";
            this.CB_RecieverStaffNumber.UseVisualStyleBackColor = true;
            this.CB_RecieverStaffNumber.CheckedChanged += new System.EventHandler(this.CB_RecieverStaffNumber_CheckedChanged);
            // 
            // TB_RecieverStaffNumber
            // 
            this.TB_RecieverStaffNumber.Location = new System.Drawing.Point(13, 257);
            this.TB_RecieverStaffNumber.Name = "TB_RecieverStaffNumber";
            this.TB_RecieverStaffNumber.Size = new System.Drawing.Size(143, 20);
            this.TB_RecieverStaffNumber.TabIndex = 8;
            // 
            // CB_GiveDate
            // 
            this.CB_GiveDate.AutoSize = true;
            this.CB_GiveDate.Location = new System.Drawing.Point(13, 284);
            this.CB_GiveDate.Name = "CB_GiveDate";
            this.CB_GiveDate.Size = new System.Drawing.Size(92, 17);
            this.CB_GiveDate.TabIndex = 9;
            this.CB_GiveDate.Text = "Дата выдачи";
            this.CB_GiveDate.UseVisualStyleBackColor = true;
            this.CB_GiveDate.CheckedChanged += new System.EventHandler(this.CB_GiveDate_CheckedChanged);
            // 
            // CB_ExpectedReturnDate
            // 
            this.CB_ExpectedReturnDate.AutoSize = true;
            this.CB_ExpectedReturnDate.Location = new System.Drawing.Point(12, 334);
            this.CB_ExpectedReturnDate.Name = "CB_ExpectedReturnDate";
            this.CB_ExpectedReturnDate.Size = new System.Drawing.Size(144, 17);
            this.CB_ExpectedReturnDate.TabIndex = 14;
            this.CB_ExpectedReturnDate.Text = "Ожидаемая дата сдачи";
            this.CB_ExpectedReturnDate.UseVisualStyleBackColor = true;
            this.CB_ExpectedReturnDate.CheckedChanged += new System.EventHandler(this.CB_ExpectedReturnDate_CheckedChanged);
            // 
            // CB_RealReturnDate
            // 
            this.CB_RealReturnDate.AutoSize = true;
            this.CB_RealReturnDate.Checked = true;
            this.CB_RealReturnDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_RealReturnDate.Location = new System.Drawing.Point(12, 384);
            this.CB_RealReturnDate.Name = "CB_RealReturnDate";
            this.CB_RealReturnDate.Size = new System.Drawing.Size(133, 17);
            this.CB_RealReturnDate.TabIndex = 18;
            this.CB_RealReturnDate.Text = "Реальная дата сдачи";
            this.CB_RealReturnDate.UseVisualStyleBackColor = true;
            this.CB_RealReturnDate.CheckedChanged += new System.EventHandler(this.CB_RealReturnDate_CheckedChanged);
            // 
            // CB_PenaltySum
            // 
            this.CB_PenaltySum.AutoSize = true;
            this.CB_PenaltySum.Checked = true;
            this.CB_PenaltySum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_PenaltySum.Location = new System.Drawing.Point(12, 434);
            this.CB_PenaltySum.Name = "CB_PenaltySum";
            this.CB_PenaltySum.Size = new System.Drawing.Size(102, 17);
            this.CB_PenaltySum.TabIndex = 22;
            this.CB_PenaltySum.Text = "Сумма штрафа";
            this.CB_PenaltySum.UseVisualStyleBackColor = true;
            this.CB_PenaltySum.CheckedChanged += new System.EventHandler(this.CB_PenaltySum_CheckedChanged);
            // 
            // CB_PenaltyInfo
            // 
            this.CB_PenaltyInfo.AutoSize = true;
            this.CB_PenaltyInfo.Checked = true;
            this.CB_PenaltyInfo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_PenaltyInfo.Location = new System.Drawing.Point(12, 458);
            this.CB_PenaltyInfo.Name = "CB_PenaltyInfo";
            this.CB_PenaltyInfo.Size = new System.Drawing.Size(102, 17);
            this.CB_PenaltyInfo.TabIndex = 23;
            this.CB_PenaltyInfo.Text = "Инф. о штрафе";
            this.CB_PenaltyInfo.UseVisualStyleBackColor = true;
            this.CB_PenaltyInfo.CheckedChanged += new System.EventHandler(this.CB_PenaltyInfo_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_Books,
            this.TSM_Readers,
            this.TSM_Librarian});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
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
            // TSM_Librarian_Birth
            // 
            this.TSM_Librarian_Birth.Name = "TSM_Librarian_Birth";
            this.TSM_Librarian_Birth.Size = new System.Drawing.Size(180, 22);
            this.TSM_Librarian_Birth.Text = "Дата рождения";
            // 
            // TSM_Librarian_Phone
            // 
            this.TSM_Librarian_Phone.Name = "TSM_Librarian_Phone";
            this.TSM_Librarian_Phone.Size = new System.Drawing.Size(180, 22);
            this.TSM_Librarian_Phone.Text = "Телефон";
            // 
            // TSM_Librarian_Email
            // 
            this.TSM_Librarian_Email.Name = "TSM_Librarian_Email";
            this.TSM_Librarian_Email.Size = new System.Drawing.Size(180, 22);
            this.TSM_Librarian_Email.Text = "E-mail";
            // 
            // TSM_Librarian_Address
            // 
            this.TSM_Librarian_Address.Name = "TSM_Librarian_Address";
            this.TSM_Librarian_Address.Size = new System.Drawing.Size(180, 22);
            this.TSM_Librarian_Address.Text = "Адрес";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(657, 508);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 25;
            this.btn_Close.Text = "Закрыть";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // DTP_GiveDate
            // 
            this.DTP_GiveDate.Location = new System.Drawing.Point(12, 308);
            this.DTP_GiveDate.Name = "DTP_GiveDate";
            this.DTP_GiveDate.Size = new System.Drawing.Size(144, 20);
            this.DTP_GiveDate.TabIndex = 26;
            // 
            // DTP_Expected_Date
            // 
            this.DTP_Expected_Date.Location = new System.Drawing.Point(12, 358);
            this.DTP_Expected_Date.Name = "DTP_Expected_Date";
            this.DTP_Expected_Date.Size = new System.Drawing.Size(144, 20);
            this.DTP_Expected_Date.TabIndex = 27;
            // 
            // DTP_Real_Date
            // 
            this.DTP_Real_Date.Location = new System.Drawing.Point(12, 407);
            this.DTP_Real_Date.Name = "DTP_Real_Date";
            this.DTP_Real_Date.Size = new System.Drawing.Size(144, 20);
            this.DTP_Real_Date.TabIndex = 28;
            // 
            // CB_Filter_PubID
            // 
            this.CB_Filter_PubID.AutoSize = true;
            this.CB_Filter_PubID.Location = new System.Drawing.Point(159, 107);
            this.CB_Filter_PubID.Name = "CB_Filter_PubID";
            this.CB_Filter_PubID.Size = new System.Drawing.Size(15, 14);
            this.CB_Filter_PubID.TabIndex = 29;
            this.CB_Filter_PubID.UseVisualStyleBackColor = true;
            this.CB_Filter_PubID.CheckedChanged += new System.EventHandler(this.CB_Filter_PubID_CheckedChanged);
            // 
            // CB_Filter_Reader_Ticket
            // 
            this.CB_Filter_Reader_Ticket.AutoSize = true;
            this.CB_Filter_Reader_Ticket.Location = new System.Drawing.Point(159, 158);
            this.CB_Filter_Reader_Ticket.Name = "CB_Filter_Reader_Ticket";
            this.CB_Filter_Reader_Ticket.Size = new System.Drawing.Size(15, 14);
            this.CB_Filter_Reader_Ticket.TabIndex = 30;
            this.CB_Filter_Reader_Ticket.UseVisualStyleBackColor = true;
            this.CB_Filter_Reader_Ticket.CheckedChanged += new System.EventHandler(this.CB_Filter_Reader_Ticket_CheckedChanged);
            // 
            // CB_Filter_Giver
            // 
            this.CB_Filter_Giver.AutoSize = true;
            this.CB_Filter_Giver.Location = new System.Drawing.Point(159, 209);
            this.CB_Filter_Giver.Name = "CB_Filter_Giver";
            this.CB_Filter_Giver.Size = new System.Drawing.Size(15, 14);
            this.CB_Filter_Giver.TabIndex = 31;
            this.CB_Filter_Giver.UseVisualStyleBackColor = true;
            this.CB_Filter_Giver.CheckedChanged += new System.EventHandler(this.CB_Filter_Giver_CheckedChanged);
            // 
            // CB_Filter_Getter
            // 
            this.CB_Filter_Getter.AutoSize = true;
            this.CB_Filter_Getter.Location = new System.Drawing.Point(159, 260);
            this.CB_Filter_Getter.Name = "CB_Filter_Getter";
            this.CB_Filter_Getter.Size = new System.Drawing.Size(15, 14);
            this.CB_Filter_Getter.TabIndex = 32;
            this.CB_Filter_Getter.UseVisualStyleBackColor = true;
            this.CB_Filter_Getter.CheckedChanged += new System.EventHandler(this.CB_Filter_Getter_CheckedChanged);
            // 
            // CB_Filter_Give_Date
            // 
            this.CB_Filter_Give_Date.AutoSize = true;
            this.CB_Filter_Give_Date.Location = new System.Drawing.Point(159, 311);
            this.CB_Filter_Give_Date.Name = "CB_Filter_Give_Date";
            this.CB_Filter_Give_Date.Size = new System.Drawing.Size(15, 14);
            this.CB_Filter_Give_Date.TabIndex = 33;
            this.CB_Filter_Give_Date.UseVisualStyleBackColor = true;
            this.CB_Filter_Give_Date.CheckedChanged += new System.EventHandler(this.CB_Filter_Give_Date_CheckedChanged);
            // 
            // CB_Filter_Expected_Date
            // 
            this.CB_Filter_Expected_Date.AutoSize = true;
            this.CB_Filter_Expected_Date.Location = new System.Drawing.Point(159, 361);
            this.CB_Filter_Expected_Date.Name = "CB_Filter_Expected_Date";
            this.CB_Filter_Expected_Date.Size = new System.Drawing.Size(15, 14);
            this.CB_Filter_Expected_Date.TabIndex = 34;
            this.CB_Filter_Expected_Date.UseVisualStyleBackColor = true;
            this.CB_Filter_Expected_Date.CheckedChanged += new System.EventHandler(this.CB_Filter_Expected_Date_CheckedChanged);
            // 
            // CB_Filter_Real_Date
            // 
            this.CB_Filter_Real_Date.AutoSize = true;
            this.CB_Filter_Real_Date.Location = new System.Drawing.Point(159, 410);
            this.CB_Filter_Real_Date.Name = "CB_Filter_Real_Date";
            this.CB_Filter_Real_Date.Size = new System.Drawing.Size(15, 14);
            this.CB_Filter_Real_Date.TabIndex = 35;
            this.CB_Filter_Real_Date.UseVisualStyleBackColor = true;
            this.CB_Filter_Real_Date.CheckedChanged += new System.EventHandler(this.CB_Filter_Real_Date_CheckedChanged);
            // 
            // CB_Filter_OperationID
            // 
            this.CB_Filter_OperationID.AutoSize = true;
            this.CB_Filter_OperationID.Location = new System.Drawing.Point(159, 53);
            this.CB_Filter_OperationID.Name = "CB_Filter_OperationID";
            this.CB_Filter_OperationID.Size = new System.Drawing.Size(15, 14);
            this.CB_Filter_OperationID.TabIndex = 38;
            this.CB_Filter_OperationID.UseVisualStyleBackColor = true;
            this.CB_Filter_OperationID.CheckedChanged += new System.EventHandler(this.CB_Filter_OperationID_CheckedChanged);
            // 
            // TB_OperationID
            // 
            this.TB_OperationID.Location = new System.Drawing.Point(12, 50);
            this.TB_OperationID.Name = "TB_OperationID";
            this.TB_OperationID.Size = new System.Drawing.Size(144, 20);
            this.TB_OperationID.TabIndex = 37;
            // 
            // CB_OperationID
            // 
            this.CB_OperationID.AutoSize = true;
            this.CB_OperationID.Checked = true;
            this.CB_OperationID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_OperationID.Location = new System.Drawing.Point(13, 27);
            this.CB_OperationID.Name = "CB_OperationID";
            this.CB_OperationID.Size = new System.Drawing.Size(88, 17);
            this.CB_OperationID.TabIndex = 36;
            this.CB_OperationID.Text = "ID операции";
            this.CB_OperationID.UseVisualStyleBackColor = true;
            this.CB_OperationID.CheckedChanged += new System.EventHandler(this.CB_OperationID_CheckedChanged);
            // 
            // btn_ApplyFilters
            // 
            this.btn_ApplyFilters.Location = new System.Drawing.Point(13, 478);
            this.btn_ApplyFilters.Name = "btn_ApplyFilters";
            this.btn_ApplyFilters.Size = new System.Drawing.Size(123, 23);
            this.btn_ApplyFilters.TabIndex = 39;
            this.btn_ApplyFilters.Text = "Применить фильтр";
            this.btn_ApplyFilters.UseVisualStyleBackColor = true;
            this.btn_ApplyFilters.Click += new System.EventHandler(this.btn_ApplyFilters_Click);
            // 
            // btn_CancelFilters
            // 
            this.btn_CancelFilters.Location = new System.Drawing.Point(12, 507);
            this.btn_CancelFilters.Name = "btn_CancelFilters";
            this.btn_CancelFilters.Size = new System.Drawing.Size(123, 23);
            this.btn_CancelFilters.TabIndex = 40;
            this.btn_CancelFilters.Text = "Сбросить фильтр";
            this.btn_CancelFilters.UseVisualStyleBackColor = true;
            this.btn_CancelFilters.Click += new System.EventHandler(this.btn_CancelFilters_Click);
            // 
            // Journal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 543);
            this.Controls.Add(this.btn_CancelFilters);
            this.Controls.Add(this.btn_ApplyFilters);
            this.Controls.Add(this.CB_Filter_OperationID);
            this.Controls.Add(this.TB_OperationID);
            this.Controls.Add(this.CB_OperationID);
            this.Controls.Add(this.CB_Filter_Real_Date);
            this.Controls.Add(this.CB_Filter_Expected_Date);
            this.Controls.Add(this.CB_Filter_Give_Date);
            this.Controls.Add(this.CB_Filter_Getter);
            this.Controls.Add(this.CB_Filter_Giver);
            this.Controls.Add(this.CB_Filter_Reader_Ticket);
            this.Controls.Add(this.CB_Filter_PubID);
            this.Controls.Add(this.DTP_Real_Date);
            this.Controls.Add(this.DTP_Expected_Date);
            this.Controls.Add(this.DTP_GiveDate);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.CB_PenaltyInfo);
            this.Controls.Add(this.CB_PenaltySum);
            this.Controls.Add(this.CB_RealReturnDate);
            this.Controls.Add(this.CB_ExpectedReturnDate);
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
            this.Load += new System.EventHandler(this.Journal_Load);
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
        private System.Windows.Forms.CheckBox CB_ExpectedReturnDate;
        private System.Windows.Forms.CheckBox CB_RealReturnDate;
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
        private System.Windows.Forms.DateTimePicker DTP_GiveDate;
        private System.Windows.Forms.DateTimePicker DTP_Expected_Date;
        private System.Windows.Forms.DateTimePicker DTP_Real_Date;
        private System.Windows.Forms.CheckBox CB_Filter_PubID;
        private System.Windows.Forms.CheckBox CB_Filter_Reader_Ticket;
        private System.Windows.Forms.CheckBox CB_Filter_Giver;
        private System.Windows.Forms.CheckBox CB_Filter_Getter;
        private System.Windows.Forms.CheckBox CB_Filter_Give_Date;
        private System.Windows.Forms.CheckBox CB_Filter_Expected_Date;
        private System.Windows.Forms.CheckBox CB_Filter_Real_Date;
        private System.Windows.Forms.CheckBox CB_Filter_OperationID;
        private System.Windows.Forms.TextBox TB_OperationID;
        private System.Windows.Forms.CheckBox CB_OperationID;
        private System.Windows.Forms.Button btn_ApplyFilters;
        private System.Windows.Forms.Button btn_CancelFilters;
    }
}