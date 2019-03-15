namespace Program
{
    partial class Librarians
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
            this.btn_Update = new System.Windows.Forms.Button();
            this.CB_Filter_Email = new System.Windows.Forms.CheckBox();
            this.CB_Filter_Phone = new System.Windows.Forms.CheckBox();
            this.CB_Filter_Date = new System.Windows.Forms.CheckBox();
            this.CB_Filter_FIO = new System.Windows.Forms.CheckBox();
            this.CB_Filter_Library_Code = new System.Windows.Forms.CheckBox();
            this.btn_FilterReset = new System.Windows.Forms.Button();
            this.btn_ApplyFilter = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Change = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Info = new System.Windows.Forms.Button();
            this.TB_Email = new System.Windows.Forms.TextBox();
            this.CB_Email = new System.Windows.Forms.CheckBox();
            this.TB_PhoneNumber = new System.Windows.Forms.TextBox();
            this.CB_Phone = new System.Windows.Forms.CheckBox();
            this.CB_Birthday = new System.Windows.Forms.CheckBox();
            this.TB_FIO = new System.Windows.Forms.TextBox();
            this.CB_Name = new System.Windows.Forms.CheckBox();
            this.CB_StaffNumber = new System.Windows.Forms.CheckBox();
            this.TB_LibrarianCode = new System.Windows.Forms.TextBox();
            this.DGV_Workers = new System.Windows.Forms.DataGridView();
            this.btn_Close = new System.Windows.Forms.Button();
            this.DTP_Birth = new System.Windows.Forms.DateTimePicker();
            this.DTP_Hiring = new System.Windows.Forms.DateTimePicker();
            this.CB_Filter_Hiring = new System.Windows.Forms.CheckBox();
            this.CB_Hiring = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Workers)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Update.Image = global::Program.Properties.Resources._13;
            this.btn_Update.Location = new System.Drawing.Point(627, 44);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(33, 34);
            this.btn_Update.TabIndex = 51;
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // CB_Filter_Email
            // 
            this.CB_Filter_Email.AutoSize = true;
            this.CB_Filter_Email.Location = new System.Drawing.Point(153, 251);
            this.CB_Filter_Email.Name = "CB_Filter_Email";
            this.CB_Filter_Email.Size = new System.Drawing.Size(15, 14);
            this.CB_Filter_Email.TabIndex = 50;
            this.CB_Filter_Email.UseVisualStyleBackColor = true;
            this.CB_Filter_Email.CheckedChanged += new System.EventHandler(this.CB_Filter_Email_CheckedChanged);
            // 
            // CB_Filter_Phone
            // 
            this.CB_Filter_Phone.AutoSize = true;
            this.CB_Filter_Phone.Location = new System.Drawing.Point(153, 200);
            this.CB_Filter_Phone.Name = "CB_Filter_Phone";
            this.CB_Filter_Phone.Size = new System.Drawing.Size(15, 14);
            this.CB_Filter_Phone.TabIndex = 49;
            this.CB_Filter_Phone.UseVisualStyleBackColor = true;
            this.CB_Filter_Phone.CheckedChanged += new System.EventHandler(this.CB_Filter_Phone_CheckedChanged);
            // 
            // CB_Filter_Date
            // 
            this.CB_Filter_Date.AutoSize = true;
            this.CB_Filter_Date.Location = new System.Drawing.Point(153, 149);
            this.CB_Filter_Date.Name = "CB_Filter_Date";
            this.CB_Filter_Date.Size = new System.Drawing.Size(15, 14);
            this.CB_Filter_Date.TabIndex = 48;
            this.CB_Filter_Date.UseVisualStyleBackColor = true;
            this.CB_Filter_Date.CheckedChanged += new System.EventHandler(this.CB_Filter_Date_CheckedChanged);
            // 
            // CB_Filter_FIO
            // 
            this.CB_Filter_FIO.AutoSize = true;
            this.CB_Filter_FIO.Location = new System.Drawing.Point(153, 98);
            this.CB_Filter_FIO.Name = "CB_Filter_FIO";
            this.CB_Filter_FIO.Size = new System.Drawing.Size(15, 14);
            this.CB_Filter_FIO.TabIndex = 47;
            this.CB_Filter_FIO.UseVisualStyleBackColor = true;
            this.CB_Filter_FIO.CheckedChanged += new System.EventHandler(this.CB_Filter_FIO_CheckedChanged);
            // 
            // CB_Filter_Library_Code
            // 
            this.CB_Filter_Library_Code.AutoSize = true;
            this.CB_Filter_Library_Code.Location = new System.Drawing.Point(153, 47);
            this.CB_Filter_Library_Code.Name = "CB_Filter_Library_Code";
            this.CB_Filter_Library_Code.Size = new System.Drawing.Size(15, 14);
            this.CB_Filter_Library_Code.TabIndex = 46;
            this.CB_Filter_Library_Code.UseVisualStyleBackColor = true;
            this.CB_Filter_Library_Code.CheckedChanged += new System.EventHandler(this.CB_Filter_Library_Code_CheckedChanged);
            // 
            // btn_FilterReset
            // 
            this.btn_FilterReset.Location = new System.Drawing.Point(13, 366);
            this.btn_FilterReset.Name = "btn_FilterReset";
            this.btn_FilterReset.Size = new System.Drawing.Size(115, 23);
            this.btn_FilterReset.TabIndex = 45;
            this.btn_FilterReset.Text = "Сбросить фильтр";
            this.btn_FilterReset.UseVisualStyleBackColor = true;
            this.btn_FilterReset.Click += new System.EventHandler(this.btn_FilterReset_Click);
            // 
            // btn_ApplyFilter
            // 
            this.btn_ApplyFilter.Location = new System.Drawing.Point(14, 337);
            this.btn_ApplyFilter.Name = "btn_ApplyFilter";
            this.btn_ApplyFilter.Size = new System.Drawing.Size(114, 23);
            this.btn_ApplyFilter.TabIndex = 44;
            this.btn_ApplyFilter.Text = "Применить фильтр";
            this.btn_ApplyFilter.UseVisualStyleBackColor = true;
            this.btn_ApplyFilter.Click += new System.EventHandler(this.btn_ApplyFilter_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.Image = global::Program.Properties.Resources.Крест;
            this.btn_Delete.Location = new System.Drawing.Point(627, 283);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(33, 34);
            this.btn_Delete.TabIndex = 43;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Change
            // 
            this.btn_Change.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Change.Image = global::Program.Properties.Resources.Гаечный_ключ1;
            this.btn_Change.Location = new System.Drawing.Point(627, 222);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(33, 34);
            this.btn_Change.TabIndex = 42;
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.Image = global::Program.Properties.Resources.plus11;
            this.btn_Add.Location = new System.Drawing.Point(627, 161);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(33, 34);
            this.btn_Add.TabIndex = 41;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Info
            // 
            this.btn_Info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Info.Image = global::Program.Properties.Resources.img_5255192;
            this.btn_Info.Location = new System.Drawing.Point(627, 103);
            this.btn_Info.Name = "btn_Info";
            this.btn_Info.Size = new System.Drawing.Size(33, 34);
            this.btn_Info.TabIndex = 40;
            this.btn_Info.UseVisualStyleBackColor = true;
            this.btn_Info.Click += new System.EventHandler(this.btn_Info_Click);
            // 
            // TB_Email
            // 
            this.TB_Email.Location = new System.Drawing.Point(11, 248);
            this.TB_Email.MaxLength = 40;
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.Size = new System.Drawing.Size(136, 20);
            this.TB_Email.TabIndex = 39;
            // 
            // CB_Email
            // 
            this.CB_Email.AutoSize = true;
            this.CB_Email.Location = new System.Drawing.Point(11, 224);
            this.CB_Email.Name = "CB_Email";
            this.CB_Email.Size = new System.Drawing.Size(53, 17);
            this.CB_Email.TabIndex = 38;
            this.CB_Email.Text = "e-mail";
            this.CB_Email.UseVisualStyleBackColor = true;
            this.CB_Email.CheckedChanged += new System.EventHandler(this.CB_Email_CheckedChanged);
            // 
            // TB_PhoneNumber
            // 
            this.TB_PhoneNumber.Location = new System.Drawing.Point(11, 197);
            this.TB_PhoneNumber.MaxLength = 18;
            this.TB_PhoneNumber.Name = "TB_PhoneNumber";
            this.TB_PhoneNumber.Size = new System.Drawing.Size(136, 20);
            this.TB_PhoneNumber.TabIndex = 37;
            // 
            // CB_Phone
            // 
            this.CB_Phone.AutoSize = true;
            this.CB_Phone.Location = new System.Drawing.Point(11, 173);
            this.CB_Phone.Name = "CB_Phone";
            this.CB_Phone.Size = new System.Drawing.Size(71, 17);
            this.CB_Phone.TabIndex = 36;
            this.CB_Phone.Text = "Телефон";
            this.CB_Phone.UseVisualStyleBackColor = true;
            this.CB_Phone.CheckedChanged += new System.EventHandler(this.CB_Phone_CheckedChanged);
            // 
            // CB_Birthday
            // 
            this.CB_Birthday.AutoSize = true;
            this.CB_Birthday.Checked = true;
            this.CB_Birthday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_Birthday.Location = new System.Drawing.Point(11, 122);
            this.CB_Birthday.Name = "CB_Birthday";
            this.CB_Birthday.Size = new System.Drawing.Size(105, 17);
            this.CB_Birthday.TabIndex = 32;
            this.CB_Birthday.Text = "Дата рождения";
            this.CB_Birthday.UseVisualStyleBackColor = true;
            this.CB_Birthday.CheckedChanged += new System.EventHandler(this.CB_Birthday_CheckedChanged);
            // 
            // TB_FIO
            // 
            this.TB_FIO.Location = new System.Drawing.Point(11, 95);
            this.TB_FIO.MaxLength = 60;
            this.TB_FIO.Name = "TB_FIO";
            this.TB_FIO.Size = new System.Drawing.Size(136, 20);
            this.TB_FIO.TabIndex = 31;
            // 
            // CB_Name
            // 
            this.CB_Name.AutoSize = true;
            this.CB_Name.Checked = true;
            this.CB_Name.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_Name.Location = new System.Drawing.Point(12, 71);
            this.CB_Name.Name = "CB_Name";
            this.CB_Name.Size = new System.Drawing.Size(53, 17);
            this.CB_Name.TabIndex = 30;
            this.CB_Name.Text = "ФИО";
            this.CB_Name.UseVisualStyleBackColor = true;
            this.CB_Name.CheckedChanged += new System.EventHandler(this.CB_Name_CheckedChanged);
            // 
            // CB_StaffNumber
            // 
            this.CB_StaffNumber.AutoSize = true;
            this.CB_StaffNumber.Checked = true;
            this.CB_StaffNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_StaffNumber.Location = new System.Drawing.Point(11, 21);
            this.CB_StaffNumber.Name = "CB_StaffNumber";
            this.CB_StaffNumber.Size = new System.Drawing.Size(106, 17);
            this.CB_StaffNumber.TabIndex = 29;
            this.CB_StaffNumber.Text = "Штатный номер";
            this.CB_StaffNumber.UseVisualStyleBackColor = true;
            this.CB_StaffNumber.CheckedChanged += new System.EventHandler(this.CB_StaffNumber_CheckedChanged);
            // 
            // TB_LibrarianCode
            // 
            this.TB_LibrarianCode.Location = new System.Drawing.Point(11, 44);
            this.TB_LibrarianCode.Name = "TB_LibrarianCode";
            this.TB_LibrarianCode.Size = new System.Drawing.Size(136, 20);
            this.TB_LibrarianCode.TabIndex = 28;
            // 
            // DGV_Workers
            // 
            this.DGV_Workers.AllowUserToAddRows = false;
            this.DGV_Workers.AllowUserToDeleteRows = false;
            this.DGV_Workers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Workers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Workers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Workers.Location = new System.Drawing.Point(193, 21);
            this.DGV_Workers.MultiSelect = false;
            this.DGV_Workers.Name = "DGV_Workers";
            this.DGV_Workers.ReadOnly = true;
            this.DGV_Workers.RowHeadersVisible = false;
            this.DGV_Workers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Workers.Size = new System.Drawing.Size(428, 346);
            this.DGV_Workers.TabIndex = 27;
            this.DGV_Workers.SelectionChanged += new System.EventHandler(this.DGV_Workers_SelectionChanged);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.Location = new System.Drawing.Point(602, 389);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 52;
            this.btn_Close.Text = "Закрыть";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // DTP_Birth
            // 
            this.DTP_Birth.Location = new System.Drawing.Point(13, 145);
            this.DTP_Birth.Name = "DTP_Birth";
            this.DTP_Birth.Size = new System.Drawing.Size(134, 20);
            this.DTP_Birth.TabIndex = 53;
            // 
            // DTP_Hiring
            // 
            this.DTP_Hiring.Location = new System.Drawing.Point(12, 297);
            this.DTP_Hiring.Name = "DTP_Hiring";
            this.DTP_Hiring.Size = new System.Drawing.Size(134, 20);
            this.DTP_Hiring.TabIndex = 56;
            // 
            // CB_Filter_Hiring
            // 
            this.CB_Filter_Hiring.AutoSize = true;
            this.CB_Filter_Hiring.Location = new System.Drawing.Point(152, 301);
            this.CB_Filter_Hiring.Name = "CB_Filter_Hiring";
            this.CB_Filter_Hiring.Size = new System.Drawing.Size(15, 14);
            this.CB_Filter_Hiring.TabIndex = 55;
            this.CB_Filter_Hiring.UseVisualStyleBackColor = true;
            this.CB_Filter_Hiring.CheckedChanged += new System.EventHandler(this.CB_Filter_Hiring_CheckedChanged);
            // 
            // CB_Hiring
            // 
            this.CB_Hiring.AutoSize = true;
            this.CB_Hiring.Checked = true;
            this.CB_Hiring.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_Hiring.Location = new System.Drawing.Point(10, 274);
            this.CB_Hiring.Name = "CB_Hiring";
            this.CB_Hiring.Size = new System.Drawing.Size(154, 17);
            this.CB_Hiring.TabIndex = 54;
            this.CB_Hiring.Text = "Дата принятия на работу";
            this.CB_Hiring.UseVisualStyleBackColor = true;
            this.CB_Hiring.CheckedChanged += new System.EventHandler(this.CB_Hiring_CheckedChanged);
            // 
            // Librarians
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 424);
            this.Controls.Add(this.DTP_Hiring);
            this.Controls.Add(this.CB_Filter_Hiring);
            this.Controls.Add(this.CB_Hiring);
            this.Controls.Add(this.DTP_Birth);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.CB_Filter_Email);
            this.Controls.Add(this.CB_Filter_Phone);
            this.Controls.Add(this.CB_Filter_Date);
            this.Controls.Add(this.CB_Filter_FIO);
            this.Controls.Add(this.CB_Filter_Library_Code);
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
            this.Controls.Add(this.CB_Birthday);
            this.Controls.Add(this.TB_FIO);
            this.Controls.Add(this.CB_Name);
            this.Controls.Add(this.CB_StaffNumber);
            this.Controls.Add(this.TB_LibrarianCode);
            this.Controls.Add(this.DGV_Workers);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(705, 463);
            this.Name = "Librarians";
            this.Text = "Работа с библиотекарями";
            this.Load += new System.EventHandler(this.Librarians_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Workers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.CheckBox CB_Filter_Email;
        private System.Windows.Forms.CheckBox CB_Filter_Phone;
        private System.Windows.Forms.CheckBox CB_Filter_Date;
        private System.Windows.Forms.CheckBox CB_Filter_FIO;
        private System.Windows.Forms.CheckBox CB_Filter_Library_Code;
        private System.Windows.Forms.Button btn_FilterReset;
        private System.Windows.Forms.Button btn_ApplyFilter;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Info;
        private System.Windows.Forms.TextBox TB_Email;
        private System.Windows.Forms.CheckBox CB_Email;
        private System.Windows.Forms.TextBox TB_PhoneNumber;
        private System.Windows.Forms.CheckBox CB_Phone;
        private System.Windows.Forms.CheckBox CB_Birthday;
        private System.Windows.Forms.TextBox TB_FIO;
        private System.Windows.Forms.CheckBox CB_Name;
        private System.Windows.Forms.CheckBox CB_StaffNumber;
        private System.Windows.Forms.TextBox TB_LibrarianCode;
        private System.Windows.Forms.DataGridView DGV_Workers;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.DateTimePicker DTP_Birth;
        private System.Windows.Forms.DateTimePicker DTP_Hiring;
        private System.Windows.Forms.CheckBox CB_Filter_Hiring;
        private System.Windows.Forms.CheckBox CB_Hiring;
    }
}