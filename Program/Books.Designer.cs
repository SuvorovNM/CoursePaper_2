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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.CB_Availability = new System.Windows.Forms.ComboBox();
            this.CB_Producer = new System.Windows.Forms.CheckBox();
            this.TB_Producer = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.TB_ISBN = new System.Windows.Forms.TextBox();
            this.btn_ApplyFilter = new System.Windows.Forms.Button();
            this.btn_FilterReset = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Change = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Info = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(166, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(488, 477);
            this.dataGridView1.TabIndex = 0;
            // 
            // CB_Name
            // 
            this.CB_Name.AutoSize = true;
            this.CB_Name.Location = new System.Drawing.Point(13, 33);
            this.CB_Name.Name = "CB_Name";
            this.CB_Name.Size = new System.Drawing.Size(76, 17);
            this.CB_Name.TabIndex = 1;
            this.CB_Name.Text = "Название";
            this.CB_Name.UseVisualStyleBackColor = true;
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(13, 57);
            this.TB_Name.MaxLength = 255;
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(137, 20);
            this.TB_Name.TabIndex = 2;
            // 
            // CB_Author
            // 
            this.CB_Author.AutoSize = true;
            this.CB_Author.Location = new System.Drawing.Point(13, 84);
            this.CB_Author.Name = "CB_Author";
            this.CB_Author.Size = new System.Drawing.Size(56, 17);
            this.CB_Author.TabIndex = 3;
            this.CB_Author.Text = "Автор";
            this.CB_Author.UseVisualStyleBackColor = true;
            // 
            // TB_Author
            // 
            this.TB_Author.Location = new System.Drawing.Point(13, 108);
            this.TB_Author.MaxLength = 80;
            this.TB_Author.Name = "TB_Author";
            this.TB_Author.Size = new System.Drawing.Size(137, 20);
            this.TB_Author.TabIndex = 4;
            // 
            // CB_Year
            // 
            this.CB_Year.AutoSize = true;
            this.CB_Year.Location = new System.Drawing.Point(13, 135);
            this.CB_Year.Name = "CB_Year";
            this.CB_Year.Size = new System.Drawing.Size(89, 17);
            this.CB_Year.TabIndex = 5;
            this.CB_Year.Text = "Год издания";
            this.CB_Year.UseVisualStyleBackColor = true;
            // 
            // TB_Year
            // 
            this.TB_Year.Location = new System.Drawing.Point(13, 159);
            this.TB_Year.MaxLength = 4;
            this.TB_Year.Name = "TB_Year";
            this.TB_Year.Size = new System.Drawing.Size(137, 20);
            this.TB_Year.TabIndex = 6;
            // 
            // CB_BBK
            // 
            this.CB_BBK.AutoSize = true;
            this.CB_BBK.Location = new System.Drawing.Point(13, 186);
            this.CB_BBK.Name = "CB_BBK";
            this.CB_BBK.Size = new System.Drawing.Size(47, 17);
            this.CB_BBK.TabIndex = 7;
            this.CB_BBK.Text = "ББК";
            this.CB_BBK.UseVisualStyleBackColor = true;
            // 
            // TB_BBK
            // 
            this.TB_BBK.Location = new System.Drawing.Point(13, 210);
            this.TB_BBK.MaxLength = 80;
            this.TB_BBK.Name = "TB_BBK";
            this.TB_BBK.Size = new System.Drawing.Size(137, 20);
            this.TB_BBK.TabIndex = 8;
            // 
            // CB_Id
            // 
            this.CB_Id.AutoSize = true;
            this.CB_Id.Location = new System.Drawing.Point(13, 237);
            this.CB_Id.Name = "CB_Id";
            this.CB_Id.Size = new System.Drawing.Size(95, 17);
            this.CB_Id.TabIndex = 9;
            this.CB_Id.Text = "Идент. номер";
            this.CB_Id.UseVisualStyleBackColor = true;
            // 
            // TB_Id
            // 
            this.TB_Id.Location = new System.Drawing.Point(13, 261);
            this.TB_Id.Name = "TB_Id";
            this.TB_Id.Size = new System.Drawing.Size(137, 20);
            this.TB_Id.TabIndex = 10;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 288);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Наличие";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // CB_Availability
            // 
            this.CB_Availability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Availability.FormattingEnabled = true;
            this.CB_Availability.Items.AddRange(new object[] {
            "Есть в наличии",
            "Нет в наличии",
            "Не учитывать наличие"});
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
            // 
            // TB_Producer
            // 
            this.TB_Producer.Location = new System.Drawing.Point(13, 364);
            this.TB_Producer.MaxLength = 80;
            this.TB_Producer.Name = "TB_Producer";
            this.TB_Producer.Size = new System.Drawing.Size(137, 20);
            this.TB_Producer.TabIndex = 14;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(13, 391);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(81, 17);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "ISBN/ISSN";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // TB_ISBN
            // 
            this.TB_ISBN.Location = new System.Drawing.Point(13, 411);
            this.TB_ISBN.MaxLength = 18;
            this.TB_ISBN.Name = "TB_ISBN";
            this.TB_ISBN.Size = new System.Drawing.Size(137, 20);
            this.TB_ISBN.TabIndex = 16;
            // 
            // btn_ApplyFilter
            // 
            this.btn_ApplyFilter.Location = new System.Drawing.Point(13, 438);
            this.btn_ApplyFilter.Name = "btn_ApplyFilter";
            this.btn_ApplyFilter.Size = new System.Drawing.Size(137, 23);
            this.btn_ApplyFilter.TabIndex = 17;
            this.btn_ApplyFilter.Text = "Применить фильтр";
            this.btn_ApplyFilter.UseVisualStyleBackColor = true;
            // 
            // btn_FilterReset
            // 
            this.btn_FilterReset.Location = new System.Drawing.Point(13, 468);
            this.btn_FilterReset.Name = "btn_FilterReset";
            this.btn_FilterReset.Size = new System.Drawing.Size(137, 23);
            this.btn_FilterReset.TabIndex = 18;
            this.btn_FilterReset.Text = "Сбросить фильтр";
            this.btn_FilterReset.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Image = global::Program.Properties.Resources.Крест;
            this.btn_Delete.Location = new System.Drawing.Point(660, 305);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(33, 34);
            this.btn_Delete.TabIndex = 22;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Change
            // 
            this.btn_Change.Image = global::Program.Properties.Resources.Гаечный_ключ1;
            this.btn_Change.Location = new System.Drawing.Point(660, 244);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(33, 34);
            this.btn_Change.TabIndex = 21;
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Image = global::Program.Properties.Resources.plus11;
            this.btn_Add.Location = new System.Drawing.Point(660, 183);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(33, 34);
            this.btn_Add.TabIndex = 20;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Info
            // 
            this.btn_Info.Image = global::Program.Properties.Resources.img_5255192;
            this.btn_Info.Location = new System.Drawing.Point(660, 125);
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
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Info);
            this.Controls.Add(this.btn_FilterReset);
            this.Controls.Add(this.btn_ApplyFilter);
            this.Controls.Add(this.TB_ISBN);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.TB_Producer);
            this.Controls.Add(this.CB_Producer);
            this.Controls.Add(this.CB_Availability);
            this.Controls.Add(this.checkBox1);
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
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Books";
            this.Text = "База книг";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox CB_Availability;
        private System.Windows.Forms.CheckBox CB_Producer;
        private System.Windows.Forms.TextBox TB_Producer;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox TB_ISBN;
        private System.Windows.Forms.Button btn_ApplyFilter;
        private System.Windows.Forms.Button btn_FilterReset;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Info;
    }
}