namespace Program
{
    partial class Books
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
            this.DGV_Books = new System.Windows.Forms.DataGridView();
            this.CB_Name = new System.Windows.Forms.CheckBox();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.CB_Author = new System.Windows.Forms.CheckBox();
            this.TB_Author = new System.Windows.Forms.TextBox();
            this.CB_Year = new System.Windows.Forms.CheckBox();
            this.TB_Year = new System.Windows.Forms.TextBox();
            this.CB_BBK = new System.Windows.Forms.CheckBox();
            this.TB_BBK = new System.Windows.Forms.TextBox();
            this.CB_Id = new System.Windows.Forms.CheckBox();
            this.TB_Id = new System.Windows.Forms.TextBox();
            this.CB_Avail = new System.Windows.Forms.CheckBox();
            this.CB_Availability = new System.Windows.Forms.ComboBox();
            this.CB_Producer = new System.Windows.Forms.CheckBox();
            this.TB_Producer = new System.Windows.Forms.TextBox();
            this.btn_ApplyFilter = new System.Windows.Forms.Button();
            this.btn_FilterReset = new System.Windows.Forms.Button();
            this.CB_Filter_Name = new System.Windows.Forms.CheckBox();
            this.CB_Filter_Author = new System.Windows.Forms.CheckBox();
            this.CB_Filter_Year = new System.Windows.Forms.CheckBox();
            this.CB_Filter_BBK = new System.Windows.Forms.CheckBox();
            this.CB_Filter_ID = new System.Windows.Forms.CheckBox();
            this.CB_Filter_Avail = new System.Windows.Forms.CheckBox();
            this.CB_Filter_Producer = new System.Windows.Forms.CheckBox();
            this.btn_Import = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Change = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Info = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Books)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Books
            // 
            this.DGV_Books.AllowUserToAddRows = false;
            this.DGV_Books.AllowUserToDeleteRows = false;
            this.DGV_Books.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Books.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Books.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.DGV_Books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Books.Location = new System.Drawing.Point(194, 33);
            this.DGV_Books.MultiSelect = false;
            this.DGV_Books.Name = "DGV_Books";
            this.DGV_Books.ReadOnly = true;
            this.DGV_Books.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Books.Size = new System.Drawing.Size(488, 477);
            this.DGV_Books.TabIndex = 1;
            this.DGV_Books.SelectionChanged += new System.EventHandler(this.DGV_Books_SelectionChanged);
            // 
            // CB_Name
            // 
            this.CB_Name.AutoSize = true;
            this.CB_Name.Checked = true;
            this.CB_Name.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_Name.Location = new System.Drawing.Point(13, 87);
            this.CB_Name.Name = "CB_Name";
            this.CB_Name.Size = new System.Drawing.Size(76, 17);
            this.CB_Name.TabIndex = 1;
            this.CB_Name.Text = "Название";
            this.CB_Name.UseVisualStyleBackColor = true;
            this.CB_Name.CheckedChanged += new System.EventHandler(this.CB_Name_CheckedChanged);
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(13, 111);
            this.TB_Name.MaxLength = 255;
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(137, 20);
            this.TB_Name.TabIndex = 2;
            // 
            // CB_Author
            // 
            this.CB_Author.AutoSize = true;
            this.CB_Author.Checked = true;
            this.CB_Author.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_Author.Location = new System.Drawing.Point(13, 138);
            this.CB_Author.Name = "CB_Author";
            this.CB_Author.Size = new System.Drawing.Size(56, 17);
            this.CB_Author.TabIndex = 3;
            this.CB_Author.Text = "Автор";
            this.CB_Author.UseVisualStyleBackColor = true;
            this.CB_Author.CheckedChanged += new System.EventHandler(this.CB_Author_CheckedChanged);
            // 
            // TB_Author
            // 
            this.TB_Author.Location = new System.Drawing.Point(13, 162);
            this.TB_Author.MaxLength = 80;
            this.TB_Author.Name = "TB_Author";
            this.TB_Author.Size = new System.Drawing.Size(137, 20);
            this.TB_Author.TabIndex = 4;
            // 
            // CB_Year
            // 
            this.CB_Year.AutoSize = true;
            this.CB_Year.Location = new System.Drawing.Point(13, 189);
            this.CB_Year.Name = "CB_Year";
            this.CB_Year.Size = new System.Drawing.Size(89, 17);
            this.CB_Year.TabIndex = 5;
            this.CB_Year.Text = "Год издания";
            this.CB_Year.UseVisualStyleBackColor = true;
            this.CB_Year.CheckedChanged += new System.EventHandler(this.CB_Year_CheckedChanged);
            // 
            // TB_Year
            // 
            this.TB_Year.Location = new System.Drawing.Point(13, 213);
            this.TB_Year.MaxLength = 4;
            this.TB_Year.Name = "TB_Year";
            this.TB_Year.Size = new System.Drawing.Size(137, 20);
            this.TB_Year.TabIndex = 6;
            // 
            // CB_BBK
            // 
            this.CB_BBK.AutoSize = true;
            this.CB_BBK.Checked = true;
            this.CB_BBK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_BBK.Location = new System.Drawing.Point(13, 240);
            this.CB_BBK.Name = "CB_BBK";
            this.CB_BBK.Size = new System.Drawing.Size(47, 17);
            this.CB_BBK.TabIndex = 7;
            this.CB_BBK.Text = "ББК";
            this.CB_BBK.UseVisualStyleBackColor = true;
            this.CB_BBK.CheckedChanged += new System.EventHandler(this.CB_BBK_CheckedChanged);
            // 
            // TB_BBK
            // 
            this.TB_BBK.Location = new System.Drawing.Point(13, 264);
            this.TB_BBK.MaxLength = 80;
            this.TB_BBK.Name = "TB_BBK";
            this.TB_BBK.Size = new System.Drawing.Size(137, 20);
            this.TB_BBK.TabIndex = 8;
            // 
            // CB_Id
            // 
            this.CB_Id.AutoSize = true;
            this.CB_Id.Checked = true;
            this.CB_Id.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_Id.Location = new System.Drawing.Point(13, 37);
            this.CB_Id.Name = "CB_Id";
            this.CB_Id.Size = new System.Drawing.Size(95, 17);
            this.CB_Id.TabIndex = 9;
            this.CB_Id.Text = "Идент. номер";
            this.CB_Id.UseVisualStyleBackColor = true;
            this.CB_Id.CheckedChanged += new System.EventHandler(this.CB_Id_CheckedChanged);
            // 
            // TB_Id
            // 
            this.TB_Id.Location = new System.Drawing.Point(13, 61);
            this.TB_Id.Name = "TB_Id";
            this.TB_Id.Size = new System.Drawing.Size(137, 20);
            this.TB_Id.TabIndex = 10;
            this.TB_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Id_KeyPress);
            // 
            // CB_Avail
            // 
            this.CB_Avail.AutoSize = true;
            this.CB_Avail.Checked = true;
            this.CB_Avail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_Avail.Location = new System.Drawing.Point(13, 288);
            this.CB_Avail.Name = "CB_Avail";
            this.CB_Avail.Size = new System.Drawing.Size(69, 17);
            this.CB_Avail.TabIndex = 11;
            this.CB_Avail.Text = "Наличие";
            this.CB_Avail.UseVisualStyleBackColor = true;
            this.CB_Avail.CheckedChanged += new System.EventHandler(this.CB_Avail_CheckedChanged);
            // 
            // CB_Availability
            // 
            this.CB_Availability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Availability.FormattingEnabled = true;
            this.CB_Availability.Items.AddRange(new object[] {
            "Нет в наличии",
            "Есть в наличии"});
            this.CB_Availability.Location = new System.Drawing.Point(13, 312);
            this.CB_Availability.Name = "CB_Availability";
            this.CB_Availability.Size = new System.Drawing.Size(137, 21);
            this.CB_Availability.TabIndex = 12;
            // 
            // CB_Producer
            // 
            this.CB_Producer.AutoSize = true;
            this.CB_Producer.Location = new System.Drawing.Point(13, 340);
            this.CB_Producer.Name = "CB_Producer";
            this.CB_Producer.Size = new System.Drawing.Size(98, 17);
            this.CB_Producer.TabIndex = 13;
            this.CB_Producer.Text = "Издательство";
            this.CB_Producer.UseVisualStyleBackColor = true;
            this.CB_Producer.CheckedChanged += new System.EventHandler(this.CB_Producer_CheckedChanged);
            // 
            // TB_Producer
            // 
            this.TB_Producer.Location = new System.Drawing.Point(13, 364);
            this.TB_Producer.MaxLength = 80;
            this.TB_Producer.Name = "TB_Producer";
            this.TB_Producer.Size = new System.Drawing.Size(137, 20);
            this.TB_Producer.TabIndex = 14;
            // 
            // btn_ApplyFilter
            // 
            this.btn_ApplyFilter.Location = new System.Drawing.Point(13, 413);
            this.btn_ApplyFilter.Name = "btn_ApplyFilter";
            this.btn_ApplyFilter.Size = new System.Drawing.Size(137, 23);
            this.btn_ApplyFilter.TabIndex = 17;
            this.btn_ApplyFilter.Text = "Применить фильтр";
            this.btn_ApplyFilter.UseVisualStyleBackColor = true;
            this.btn_ApplyFilter.Click += new System.EventHandler(this.btn_ApplyFilter_Click);
            // 
            // btn_FilterReset
            // 
            this.btn_FilterReset.Location = new System.Drawing.Point(13, 443);
            this.btn_FilterReset.Name = "btn_FilterReset";
            this.btn_FilterReset.Size = new System.Drawing.Size(137, 23);
            this.btn_FilterReset.TabIndex = 18;
            this.btn_FilterReset.Text = "Сбросить фильтр";
            this.btn_FilterReset.UseVisualStyleBackColor = true;
            this.btn_FilterReset.Click += new System.EventHandler(this.btn_FilterReset_Click);
            // 
            // CB_Filter_Name
            // 
            this.CB_Filter_Name.AutoSize = true;
            this.CB_Filter_Name.Location = new System.Drawing.Point(156, 114);
            this.CB_Filter_Name.Name = "CB_Filter_Name";
            this.CB_Filter_Name.Size = new System.Drawing.Size(15, 14);
            this.CB_Filter_Name.TabIndex = 23;
            this.CB_Filter_Name.UseVisualStyleBackColor = true;
            this.CB_Filter_Name.CheckedChanged += new System.EventHandler(this.CB_Filter_Name_CheckedChanged);
            // 
            // CB_Filter_Author
            // 
            this.CB_Filter_Author.AutoSize = true;
            this.CB_Filter_Author.Location = new System.Drawing.Point(156, 165);
            this.CB_Filter_Author.Name = "CB_Filter_Author";
            this.CB_Filter_Author.Size = new System.Drawing.Size(15, 14);
            this.CB_Filter_Author.TabIndex = 24;
            this.CB_Filter_Author.UseVisualStyleBackColor = true;
            this.CB_Filter_Author.CheckedChanged += new System.EventHandler(this.CB_Filter_Author_CheckedChanged);
            // 
            // CB_Filter_Year
            // 
            this.CB_Filter_Year.AutoSize = true;
            this.CB_Filter_Year.Location = new System.Drawing.Point(156, 216);
            this.CB_Filter_Year.Name = "CB_Filter_Year";
            this.CB_Filter_Year.Size = new System.Drawing.Size(15, 14);
            this.CB_Filter_Year.TabIndex = 25;
            this.CB_Filter_Year.UseVisualStyleBackColor = true;
            this.CB_Filter_Year.CheckedChanged += new System.EventHandler(this.CB_Filter_Year_CheckedChanged);
            // 
            // CB_Filter_BBK
            // 
            this.CB_Filter_BBK.AutoSize = true;
            this.CB_Filter_BBK.Location = new System.Drawing.Point(156, 270);
            this.CB_Filter_BBK.Name = "CB_Filter_BBK";
            this.CB_Filter_BBK.Size = new System.Drawing.Size(15, 14);
            this.CB_Filter_BBK.TabIndex = 26;
            this.CB_Filter_BBK.UseVisualStyleBackColor = true;
            this.CB_Filter_BBK.CheckedChanged += new System.EventHandler(this.CB_Filter_BBK_CheckedChanged);
            // 
            // CB_Filter_ID
            // 
            this.CB_Filter_ID.AutoSize = true;
            this.CB_Filter_ID.Location = new System.Drawing.Point(156, 64);
            this.CB_Filter_ID.Name = "CB_Filter_ID";
            this.CB_Filter_ID.Size = new System.Drawing.Size(15, 14);
            this.CB_Filter_ID.TabIndex = 27;
            this.CB_Filter_ID.UseVisualStyleBackColor = true;
            this.CB_Filter_ID.CheckedChanged += new System.EventHandler(this.CB_Filter_ID_CheckedChanged);
            // 
            // CB_Filter_Avail
            // 
            this.CB_Filter_Avail.AutoSize = true;
            this.CB_Filter_Avail.Location = new System.Drawing.Point(156, 315);
            this.CB_Filter_Avail.Name = "CB_Filter_Avail";
            this.CB_Filter_Avail.Size = new System.Drawing.Size(15, 14);
            this.CB_Filter_Avail.TabIndex = 28;
            this.CB_Filter_Avail.UseVisualStyleBackColor = true;
            this.CB_Filter_Avail.CheckedChanged += new System.EventHandler(this.CB_Filter_Avail_CheckedChanged);
            // 
            // CB_Filter_Producer
            // 
            this.CB_Filter_Producer.AutoSize = true;
            this.CB_Filter_Producer.Location = new System.Drawing.Point(156, 367);
            this.CB_Filter_Producer.Name = "CB_Filter_Producer";
            this.CB_Filter_Producer.Size = new System.Drawing.Size(15, 14);
            this.CB_Filter_Producer.TabIndex = 29;
            this.CB_Filter_Producer.UseVisualStyleBackColor = true;
            this.CB_Filter_Producer.CheckedChanged += new System.EventHandler(this.CB_Filter_Producer_CheckedChanged);
            // 
            // btn_Import
            // 
            this.btn_Import.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Import.Image = global::Program.Properties.Resources.Import1;
            this.btn_Import.Location = new System.Drawing.Point(688, 387);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(33, 39);
            this.btn_Import.TabIndex = 31;
            this.btn_Import.UseVisualStyleBackColor = true;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Update.Image = global::Program.Properties.Resources._13;
            this.btn_Update.Location = new System.Drawing.Point(688, 103);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(33, 34);
            this.btn_Update.TabIndex = 30;
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.Image = global::Program.Properties.Resources.Крест;
            this.btn_Delete.Location = new System.Drawing.Point(688, 334);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(33, 34);
            this.btn_Delete.TabIndex = 22;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Change
            // 
            this.btn_Change.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Change.Image = global::Program.Properties.Resources.Гаечный_ключ1;
            this.btn_Change.Location = new System.Drawing.Point(688, 273);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(33, 34);
            this.btn_Change.TabIndex = 21;
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.Image = global::Program.Properties.Resources.plus11;
            this.btn_Add.Location = new System.Drawing.Point(688, 212);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(33, 34);
            this.btn_Add.TabIndex = 20;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Info
            // 
            this.btn_Info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Info.Image = global::Program.Properties.Resources.img_5255192;
            this.btn_Info.Location = new System.Drawing.Point(688, 154);
            this.btn_Info.Name = "btn_Info";
            this.btn_Info.Size = new System.Drawing.Size(33, 34);
            this.btn_Info.TabIndex = 19;
            this.btn_Info.UseVisualStyleBackColor = true;
            this.btn_Info.Click += new System.EventHandler(this.btn_Info_Click);
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 522);
            this.Controls.Add(this.btn_Import);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.CB_Filter_Producer);
            this.Controls.Add(this.CB_Filter_Avail);
            this.Controls.Add(this.CB_Filter_ID);
            this.Controls.Add(this.CB_Filter_BBK);
            this.Controls.Add(this.CB_Filter_Year);
            this.Controls.Add(this.CB_Filter_Author);
            this.Controls.Add(this.CB_Filter_Name);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Info);
            this.Controls.Add(this.btn_FilterReset);
            this.Controls.Add(this.btn_ApplyFilter);
            this.Controls.Add(this.TB_Producer);
            this.Controls.Add(this.CB_Producer);
            this.Controls.Add(this.CB_Availability);
            this.Controls.Add(this.CB_Avail);
            this.Controls.Add(this.TB_Id);
            this.Controls.Add(this.CB_Id);
            this.Controls.Add(this.TB_BBK);
            this.Controls.Add(this.CB_BBK);
            this.Controls.Add(this.TB_Year);
            this.Controls.Add(this.CB_Year);
            this.Controls.Add(this.TB_Author);
            this.Controls.Add(this.CB_Author);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.CB_Name);
            this.Controls.Add(this.DGV_Books);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(755, 560);
            this.Name = "Books";
            this.Text = "База книг";
            this.Load += new System.EventHandler(this.Books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Books)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Books;
        private System.Windows.Forms.CheckBox CB_Name;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.CheckBox CB_Author;
        private System.Windows.Forms.TextBox TB_Author;
        private System.Windows.Forms.CheckBox CB_Year;
        private System.Windows.Forms.TextBox TB_Year;
        private System.Windows.Forms.CheckBox CB_BBK;
        private System.Windows.Forms.TextBox TB_BBK;
        private System.Windows.Forms.CheckBox CB_Id;
        private System.Windows.Forms.TextBox TB_Id;
        private System.Windows.Forms.CheckBox CB_Avail;
        private System.Windows.Forms.ComboBox CB_Availability;
        private System.Windows.Forms.CheckBox CB_Producer;
        private System.Windows.Forms.TextBox TB_Producer;
        private System.Windows.Forms.Button btn_ApplyFilter;
        private System.Windows.Forms.Button btn_FilterReset;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Info;
        private System.Windows.Forms.CheckBox CB_Filter_Name;
        private System.Windows.Forms.CheckBox CB_Filter_Author;
        private System.Windows.Forms.CheckBox CB_Filter_Year;
        private System.Windows.Forms.CheckBox CB_Filter_BBK;
        private System.Windows.Forms.CheckBox CB_Filter_ID;
        private System.Windows.Forms.CheckBox CB_Filter_Avail;
        private System.Windows.Forms.CheckBox CB_Filter_Producer;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Import;
    }
}