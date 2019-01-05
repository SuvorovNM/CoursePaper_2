﻿namespace Program
{
    partial class MainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSM_Readers = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Readers_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Readers_Change = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Readers_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Readers_CurrentBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Readers_CurrentPenalty = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Books = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Books_OpenBase = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Books_Give = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_books_get = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Books_Journal = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Report = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Librarian = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Librarian_Profile = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Librarian_Change = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Librarian_Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.DGV_Readers = new System.Windows.Forms.DataGridView();
            this.TB_LibraryCard = new System.Windows.Forms.TextBox();
            this.CB_ReaderTicket = new System.Windows.Forms.CheckBox();
            this.CB_Name = new System.Windows.Forms.CheckBox();
            this.TB_FIO = new System.Windows.Forms.TextBox();
            this.CB_Birthday = new System.Windows.Forms.CheckBox();
            this.TB_Day = new System.Windows.Forms.TextBox();
            this.CB_Month = new System.Windows.Forms.ComboBox();
            this.TB_Year = new System.Windows.Forms.TextBox();
            this.CB_Phone = new System.Windows.Forms.CheckBox();
            this.TB_PhoneNumber = new System.Windows.Forms.TextBox();
            this.CB_Email = new System.Windows.Forms.CheckBox();
            this.TB_Email = new System.Windows.Forms.TextBox();
            this.btn_ApplyFilter = new System.Windows.Forms.Button();
            this.btn_FilterReset = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Change = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Info = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Readers)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_Readers,
            this.TSM_Books,
            this.TSM_Report,
            this.TSM_Librarian});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(681, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // TSM_Readers
            // 
            this.TSM_Readers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_Readers_Add,
            this.TSM_Readers_Change,
            this.TSM_Readers_Delete,
            this.TSM_Readers_CurrentBooks,
            this.TSM_Readers_CurrentPenalty});
            this.TSM_Readers.Name = "TSM_Readers";
            this.TSM_Readers.Size = new System.Drawing.Size(70, 20);
            this.TSM_Readers.Text = "Читатели";
            // 
            // TSM_Readers_Add
            // 
            this.TSM_Readers_Add.Name = "TSM_Readers_Add";
            this.TSM_Readers_Add.Size = new System.Drawing.Size(180, 22);
            this.TSM_Readers_Add.Text = "Добавить";
            // 
            // TSM_Readers_Change
            // 
            this.TSM_Readers_Change.Name = "TSM_Readers_Change";
            this.TSM_Readers_Change.Size = new System.Drawing.Size(180, 22);
            this.TSM_Readers_Change.Text = "Изменить";
            // 
            // TSM_Readers_Delete
            // 
            this.TSM_Readers_Delete.Name = "TSM_Readers_Delete";
            this.TSM_Readers_Delete.Size = new System.Drawing.Size(180, 22);
            this.TSM_Readers_Delete.Text = "Удалить";
            // 
            // TSM_Readers_CurrentBooks
            // 
            this.TSM_Readers_CurrentBooks.Name = "TSM_Readers_CurrentBooks";
            this.TSM_Readers_CurrentBooks.Size = new System.Drawing.Size(180, 22);
            this.TSM_Readers_CurrentBooks.Text = "Текущие книги";
            this.TSM_Readers_CurrentBooks.Click += new System.EventHandler(this.TSM_Readers_CurrentBooks_Click);
            // 
            // TSM_Readers_CurrentPenalty
            // 
            this.TSM_Readers_CurrentPenalty.Name = "TSM_Readers_CurrentPenalty";
            this.TSM_Readers_CurrentPenalty.Size = new System.Drawing.Size(180, 22);
            this.TSM_Readers_CurrentPenalty.Text = "Текущий штраф";
            this.TSM_Readers_CurrentPenalty.Click += new System.EventHandler(this.TSM_Readers_CurrentPenalty_Click);
            // 
            // TSM_Books
            // 
            this.TSM_Books.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_Books_OpenBase,
            this.TSM_Books_Give,
            this.TSM_books_get,
            this.TSM_Books_Journal});
            this.TSM_Books.Name = "TSM_Books";
            this.TSM_Books.Size = new System.Drawing.Size(52, 20);
            this.TSM_Books.Text = "Книги";
            // 
            // TSM_Books_OpenBase
            // 
            this.TSM_Books_OpenBase.Name = "TSM_Books_OpenBase";
            this.TSM_Books_OpenBase.Size = new System.Drawing.Size(210, 22);
            this.TSM_Books_OpenBase.Text = "Открыть базу книг";
            this.TSM_Books_OpenBase.Click += new System.EventHandler(this.TSM_Books_OpenBase_Click);
            // 
            // TSM_Books_Give
            // 
            this.TSM_Books_Give.Name = "TSM_Books_Give";
            this.TSM_Books_Give.Size = new System.Drawing.Size(210, 22);
            this.TSM_Books_Give.Text = "Выдать книгу";
            this.TSM_Books_Give.Click += new System.EventHandler(this.TSM_Books_Give_Click);
            // 
            // TSM_books_get
            // 
            this.TSM_books_get.Name = "TSM_books_get";
            this.TSM_books_get.Size = new System.Drawing.Size(210, 22);
            this.TSM_books_get.Text = "Принять книгу";
            // 
            // TSM_Books_Journal
            // 
            this.TSM_Books_Journal.Name = "TSM_Books_Journal";
            this.TSM_Books_Journal.Size = new System.Drawing.Size(210, 22);
            this.TSM_Books_Journal.Text = "Открыть журнал выдачи";
            // 
            // TSM_Report
            // 
            this.TSM_Report.Name = "TSM_Report";
            this.TSM_Report.Size = new System.Drawing.Size(60, 20);
            this.TSM_Report.Text = "Отчеты";
            // 
            // TSM_Librarian
            // 
            this.TSM_Librarian.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_Librarian_Profile,
            this.TSM_Librarian_Change,
            this.TSM_Librarian_Quit});
            this.TSM_Librarian.Name = "TSM_Librarian";
            this.TSM_Librarian.Size = new System.Drawing.Size(97, 20);
            this.TSM_Librarian.Text = "Библиотекарь";
            // 
            // TSM_Librarian_Profile
            // 
            this.TSM_Librarian_Profile.Name = "TSM_Librarian_Profile";
            this.TSM_Librarian_Profile.Size = new System.Drawing.Size(200, 22);
            this.TSM_Librarian_Profile.Text = "Просмотр профиля";
            this.TSM_Librarian_Profile.Click += new System.EventHandler(this.TSM_Librarian_Profile_Click);
            // 
            // TSM_Librarian_Change
            // 
            this.TSM_Librarian_Change.Name = "TSM_Librarian_Change";
            this.TSM_Librarian_Change.Size = new System.Drawing.Size(200, 22);
            this.TSM_Librarian_Change.Text = "Сменить пользователя";
            this.TSM_Librarian_Change.Click += new System.EventHandler(this.TSM_Librarian_Change_Click);
            // 
            // TSM_Librarian_Quit
            // 
            this.TSM_Librarian_Quit.Name = "TSM_Librarian_Quit";
            this.TSM_Librarian_Quit.Size = new System.Drawing.Size(200, 22);
            this.TSM_Librarian_Quit.Text = "Выход";
            this.TSM_Librarian_Quit.Click += new System.EventHandler(this.TSM_Librarian_Quit_Click);
            // 
            // DGV_Readers
            // 
            this.DGV_Readers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Readers.Location = new System.Drawing.Point(154, 48);
            this.DGV_Readers.Name = "DGV_Readers";
            this.DGV_Readers.Size = new System.Drawing.Size(428, 346);
            this.DGV_Readers.TabIndex = 1;
            // 
            // TB_LibraryCard
            // 
            this.TB_LibraryCard.Location = new System.Drawing.Point(12, 71);
            this.TB_LibraryCard.Name = "TB_LibraryCard";
            this.TB_LibraryCard.Size = new System.Drawing.Size(136, 20);
            this.TB_LibraryCard.TabIndex = 3;
            // 
            // CB_ReaderTicket
            // 
            this.CB_ReaderTicket.AutoSize = true;
            this.CB_ReaderTicket.Location = new System.Drawing.Point(12, 48);
            this.CB_ReaderTicket.Name = "CB_ReaderTicket";
            this.CB_ReaderTicket.Size = new System.Drawing.Size(130, 17);
            this.CB_ReaderTicket.TabIndex = 4;
            this.CB_ReaderTicket.Text = "Читательский билет";
            this.CB_ReaderTicket.UseVisualStyleBackColor = true;
            // 
            // CB_Name
            // 
            this.CB_Name.AutoSize = true;
            this.CB_Name.Location = new System.Drawing.Point(13, 98);
            this.CB_Name.Name = "CB_Name";
            this.CB_Name.Size = new System.Drawing.Size(53, 17);
            this.CB_Name.TabIndex = 5;
            this.CB_Name.Text = "ФИО";
            this.CB_Name.UseVisualStyleBackColor = true;
            // 
            // TB_FIO
            // 
            this.TB_FIO.Location = new System.Drawing.Point(12, 122);
            this.TB_FIO.Name = "TB_FIO";
            this.TB_FIO.Size = new System.Drawing.Size(136, 20);
            this.TB_FIO.TabIndex = 6;
            // 
            // CB_Birthday
            // 
            this.CB_Birthday.AutoSize = true;
            this.CB_Birthday.Location = new System.Drawing.Point(12, 149);
            this.CB_Birthday.Name = "CB_Birthday";
            this.CB_Birthday.Size = new System.Drawing.Size(105, 17);
            this.CB_Birthday.TabIndex = 7;
            this.CB_Birthday.Text = "Дата рождения";
            this.CB_Birthday.UseVisualStyleBackColor = true;
            // 
            // TB_Day
            // 
            this.TB_Day.Location = new System.Drawing.Point(12, 173);
            this.TB_Day.Name = "TB_Day";
            this.TB_Day.Size = new System.Drawing.Size(20, 20);
            this.TB_Day.TabIndex = 8;
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
            this.CB_Month.Location = new System.Drawing.Point(38, 173);
            this.CB_Month.Name = "CB_Month";
            this.CB_Month.Size = new System.Drawing.Size(73, 21);
            this.CB_Month.TabIndex = 9;
            // 
            // TB_Year
            // 
            this.TB_Year.Location = new System.Drawing.Point(117, 173);
            this.TB_Year.Name = "TB_Year";
            this.TB_Year.Size = new System.Drawing.Size(31, 20);
            this.TB_Year.TabIndex = 10;
            // 
            // CB_Phone
            // 
            this.CB_Phone.AutoSize = true;
            this.CB_Phone.Location = new System.Drawing.Point(12, 200);
            this.CB_Phone.Name = "CB_Phone";
            this.CB_Phone.Size = new System.Drawing.Size(71, 17);
            this.CB_Phone.TabIndex = 11;
            this.CB_Phone.Text = "Телефон";
            this.CB_Phone.UseVisualStyleBackColor = true;
            // 
            // TB_PhoneNumber
            // 
            this.TB_PhoneNumber.Location = new System.Drawing.Point(12, 224);
            this.TB_PhoneNumber.Name = "TB_PhoneNumber";
            this.TB_PhoneNumber.Size = new System.Drawing.Size(136, 20);
            this.TB_PhoneNumber.TabIndex = 12;
            // 
            // CB_Email
            // 
            this.CB_Email.AutoSize = true;
            this.CB_Email.Location = new System.Drawing.Point(12, 251);
            this.CB_Email.Name = "CB_Email";
            this.CB_Email.Size = new System.Drawing.Size(53, 17);
            this.CB_Email.TabIndex = 13;
            this.CB_Email.Text = "e-mail";
            this.CB_Email.UseVisualStyleBackColor = true;
            // 
            // TB_Email
            // 
            this.TB_Email.Location = new System.Drawing.Point(12, 275);
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.Size = new System.Drawing.Size(136, 20);
            this.TB_Email.TabIndex = 14;
            // 
            // btn_ApplyFilter
            // 
            this.btn_ApplyFilter.Location = new System.Drawing.Point(28, 310);
            this.btn_ApplyFilter.Name = "btn_ApplyFilter";
            this.btn_ApplyFilter.Size = new System.Drawing.Size(114, 23);
            this.btn_ApplyFilter.TabIndex = 19;
            this.btn_ApplyFilter.Text = "Применить фильтр";
            this.btn_ApplyFilter.UseVisualStyleBackColor = true;
            // 
            // btn_FilterReset
            // 
            this.btn_FilterReset.Location = new System.Drawing.Point(27, 339);
            this.btn_FilterReset.Name = "btn_FilterReset";
            this.btn_FilterReset.Size = new System.Drawing.Size(115, 23);
            this.btn_FilterReset.TabIndex = 20;
            this.btn_FilterReset.Text = "Сбросить фильтр";
            this.btn_FilterReset.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Image = global::Program.Properties.Resources.Крест;
            this.btn_Delete.Location = new System.Drawing.Point(588, 261);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(33, 34);
            this.btn_Delete.TabIndex = 18;
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Change
            // 
            this.btn_Change.Image = global::Program.Properties.Resources.Гаечный_ключ1;
            this.btn_Change.Location = new System.Drawing.Point(588, 200);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(33, 34);
            this.btn_Change.TabIndex = 17;
            this.btn_Change.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Image = global::Program.Properties.Resources.plus11;
            this.btn_Add.Location = new System.Drawing.Point(588, 139);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(33, 34);
            this.btn_Add.TabIndex = 16;
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Info
            // 
            this.btn_Info.Image = global::Program.Properties.Resources.img_5255192;
            this.btn_Info.Location = new System.Drawing.Point(588, 81);
            this.btn_Info.Name = "btn_Info";
            this.btn_Info.Size = new System.Drawing.Size(33, 34);
            this.btn_Info.TabIndex = 15;
            this.btn_Info.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 427);
            this.Controls.Add(this.btn_FilterReset);
            this.Controls.Add(this.btn_ApplyFilter);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Info);
            this.Controls.Add(this.TB_Email);
            this.Controls.Add(this.CB_Email);
            this.Controls.Add(this.TB_PhoneNumber);
            this.Controls.Add(this.CB_Phone);
            this.Controls.Add(this.TB_Year);
            this.Controls.Add(this.CB_Month);
            this.Controls.Add(this.TB_Day);
            this.Controls.Add(this.CB_Birthday);
            this.Controls.Add(this.TB_FIO);
            this.Controls.Add(this.CB_Name);
            this.Controls.Add(this.CB_ReaderTicket);
            this.Controls.Add(this.TB_LibraryCard);
            this.Controls.Add(this.DGV_Readers);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Text = "Главное меню";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Readers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSM_Readers;
        private System.Windows.Forms.ToolStripMenuItem TSM_Readers_Add;
        private System.Windows.Forms.ToolStripMenuItem TSM_Readers_Change;
        private System.Windows.Forms.ToolStripMenuItem TSM_Readers_Delete;
        private System.Windows.Forms.ToolStripMenuItem TSM_Readers_CurrentBooks;
        private System.Windows.Forms.ToolStripMenuItem TSM_Readers_CurrentPenalty;
        private System.Windows.Forms.ToolStripMenuItem TSM_Books;
        private System.Windows.Forms.ToolStripMenuItem TSM_Books_OpenBase;
        private System.Windows.Forms.ToolStripMenuItem TSM_Books_Give;
        private System.Windows.Forms.ToolStripMenuItem TSM_books_get;
        private System.Windows.Forms.ToolStripMenuItem TSM_Books_Journal;
        private System.Windows.Forms.ToolStripMenuItem TSM_Report;
        private System.Windows.Forms.ToolStripMenuItem TSM_Librarian;
        private System.Windows.Forms.ToolStripMenuItem TSM_Librarian_Profile;
        private System.Windows.Forms.ToolStripMenuItem TSM_Librarian_Change;
        private System.Windows.Forms.ToolStripMenuItem TSM_Librarian_Quit;
        private System.Windows.Forms.DataGridView DGV_Readers;
        private System.Windows.Forms.TextBox TB_LibraryCard;
        private System.Windows.Forms.CheckBox CB_ReaderTicket;
        private System.Windows.Forms.CheckBox CB_Name;
        private System.Windows.Forms.TextBox TB_FIO;
        private System.Windows.Forms.CheckBox CB_Birthday;
        private System.Windows.Forms.TextBox TB_Day;
        private System.Windows.Forms.ComboBox CB_Month;
        private System.Windows.Forms.TextBox TB_Year;
        private System.Windows.Forms.CheckBox CB_Phone;
        private System.Windows.Forms.TextBox TB_PhoneNumber;
        private System.Windows.Forms.CheckBox CB_Email;
        private System.Windows.Forms.TextBox TB_Email;
        private System.Windows.Forms.Button btn_Info;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_ApplyFilter;
        private System.Windows.Forms.Button btn_FilterReset;
    }
}