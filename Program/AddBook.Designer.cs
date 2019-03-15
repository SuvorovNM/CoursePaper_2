namespace Program
{
    partial class AddBook
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
            this.TB_Pages = new System.Windows.Forms.TextBox();
            this.TB_ISBN = new System.Windows.Forms.TextBox();
            this.TB_UDK = new System.Windows.Forms.TextBox();
            this.TB_BBK = new System.Windows.Forms.TextBox();
            this.TB_Author = new System.Windows.Forms.TextBox();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.lb_Publisher = new System.Windows.Forms.Label();
            this.lb_Pages = new System.Windows.Forms.Label();
            this.lb_ISBN = new System.Windows.Forms.Label();
            this.lb_UDK = new System.Windows.Forms.Label();
            this.lb_BBK = new System.Windows.Forms.Label();
            this.lb_Author = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_PubType = new System.Windows.Forms.Label();
            this.CB_PubType = new System.Windows.Forms.ComboBox();
            this.lb_PubName = new System.Windows.Forms.Label();
            this.TB_PubName = new System.Windows.Forms.TextBox();
            this.lb_Year = new System.Windows.Forms.Label();
            this.TB_Year = new System.Windows.Forms.TextBox();
            this.lb_City = new System.Windows.Forms.Label();
            this.TB_City = new System.Windows.Forms.TextBox();
            this.lb_ReleaseNumber = new System.Windows.Forms.Label();
            this.TB_ReleaseNumber = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_Pages
            // 
            this.TB_Pages.Location = new System.Drawing.Point(129, 208);
            this.TB_Pages.MaxLength = 5;
            this.TB_Pages.Name = "TB_Pages";
            this.TB_Pages.Size = new System.Drawing.Size(68, 20);
            this.TB_Pages.TabIndex = 30;
            this.TB_Pages.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Pages_KeyPress);
            this.TB_Pages.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TB_Pages_KeyUp);
            // 
            // TB_ISBN
            // 
            this.TB_ISBN.Location = new System.Drawing.Point(129, 169);
            this.TB_ISBN.MaxLength = 18;
            this.TB_ISBN.Name = "TB_ISBN";
            this.TB_ISBN.Size = new System.Drawing.Size(205, 20);
            this.TB_ISBN.TabIndex = 29;
            this.TB_ISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_ISBN_KeyPress);
            this.TB_ISBN.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TB_ISBN_KeyUp);
            // 
            // TB_UDK
            // 
            this.TB_UDK.Location = new System.Drawing.Point(129, 135);
            this.TB_UDK.MaxLength = 80;
            this.TB_UDK.Name = "TB_UDK";
            this.TB_UDK.Size = new System.Drawing.Size(205, 20);
            this.TB_UDK.TabIndex = 28;
            this.TB_UDK.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TB_UDK_KeyUp);
            // 
            // TB_BBK
            // 
            this.TB_BBK.Location = new System.Drawing.Point(129, 100);
            this.TB_BBK.MaxLength = 80;
            this.TB_BBK.Name = "TB_BBK";
            this.TB_BBK.Size = new System.Drawing.Size(205, 20);
            this.TB_BBK.TabIndex = 27;
            this.TB_BBK.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TB_BBK_KeyUp);
            // 
            // TB_Author
            // 
            this.TB_Author.Location = new System.Drawing.Point(129, 69);
            this.TB_Author.MaxLength = 80;
            this.TB_Author.Name = "TB_Author";
            this.TB_Author.Size = new System.Drawing.Size(205, 20);
            this.TB_Author.TabIndex = 26;
            this.TB_Author.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Author_KeyPress);
            this.TB_Author.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TB_Author_KeyUp);
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(129, 34);
            this.TB_Name.MaxLength = 255;
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(205, 20);
            this.TB_Name.TabIndex = 25;
            this.TB_Name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TB_Name_KeyUp);
            // 
            // lb_Publisher
            // 
            this.lb_Publisher.AutoSize = true;
            this.lb_Publisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Publisher.Location = new System.Drawing.Point(47, 266);
            this.lb_Publisher.Name = "lb_Publisher";
            this.lb_Publisher.Size = new System.Drawing.Size(91, 13);
            this.lb_Publisher.TabIndex = 23;
            this.lb_Publisher.Text = "Издательство";
            // 
            // lb_Pages
            // 
            this.lb_Pages.AutoSize = true;
            this.lb_Pages.Location = new System.Drawing.Point(37, 211);
            this.lb_Pages.Name = "lb_Pages";
            this.lb_Pages.Size = new System.Drawing.Size(85, 13);
            this.lb_Pages.TabIndex = 22;
            this.lb_Pages.Text = "Кол-во страниц";
            // 
            // lb_ISBN
            // 
            this.lb_ISBN.AutoSize = true;
            this.lb_ISBN.Location = new System.Drawing.Point(61, 172);
            this.lb_ISBN.Name = "lb_ISBN";
            this.lb_ISBN.Size = new System.Drawing.Size(62, 13);
            this.lb_ISBN.TabIndex = 21;
            this.lb_ISBN.Text = "ISBN/ISSN";
            // 
            // lb_UDK
            // 
            this.lb_UDK.AutoSize = true;
            this.lb_UDK.Location = new System.Drawing.Point(91, 139);
            this.lb_UDK.Name = "lb_UDK";
            this.lb_UDK.Size = new System.Drawing.Size(31, 13);
            this.lb_UDK.TabIndex = 20;
            this.lb_UDK.Text = "УДК";
            // 
            // lb_BBK
            // 
            this.lb_BBK.AutoSize = true;
            this.lb_BBK.Location = new System.Drawing.Point(94, 107);
            this.lb_BBK.Name = "lb_BBK";
            this.lb_BBK.Size = new System.Drawing.Size(28, 13);
            this.lb_BBK.TabIndex = 19;
            this.lb_BBK.Text = "ББК";
            // 
            // lb_Author
            // 
            this.lb_Author.AutoSize = true;
            this.lb_Author.Location = new System.Drawing.Point(85, 72);
            this.lb_Author.Name = "lb_Author";
            this.lb_Author.Size = new System.Drawing.Size(37, 13);
            this.lb_Author.TabIndex = 18;
            this.lb_Author.Text = "Автор";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(33, 37);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(89, 13);
            this.lb_Name.TabIndex = 17;
            this.lb_Name.Text = "Название книги";
            // 
            // lb_PubType
            // 
            this.lb_PubType.AutoSize = true;
            this.lb_PubType.Location = new System.Drawing.Point(51, 10);
            this.lb_PubType.Name = "lb_PubType";
            this.lb_PubType.Size = new System.Drawing.Size(71, 13);
            this.lb_PubType.TabIndex = 32;
            this.lb_PubType.Text = "Тип издания";
            // 
            // CB_PubType
            // 
            this.CB_PubType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_PubType.FormattingEnabled = true;
            this.CB_PubType.Items.AddRange(new object[] {
            "Книга",
            "Периодическое издание"});
            this.CB_PubType.Location = new System.Drawing.Point(129, 7);
            this.CB_PubType.Name = "CB_PubType";
            this.CB_PubType.Size = new System.Drawing.Size(205, 21);
            this.CB_PubType.TabIndex = 33;
            this.CB_PubType.SelectedIndexChanged += new System.EventHandler(this.CB_PubType_SelectedIndexChanged);
            this.CB_PubType.DropDownClosed += new System.EventHandler(this.CB_PubType_DropDownClosed);
            this.CB_PubType.Click += new System.EventHandler(this.CB_PubType_Click);
            // 
            // lb_PubName
            // 
            this.lb_PubName.AutoSize = true;
            this.lb_PubName.Location = new System.Drawing.Point(58, 294);
            this.lb_PubName.Name = "lb_PubName";
            this.lb_PubName.Size = new System.Drawing.Size(57, 13);
            this.lb_PubName.TabIndex = 34;
            this.lb_PubName.Text = "Название";
            // 
            // TB_PubName
            // 
            this.TB_PubName.Location = new System.Drawing.Point(133, 292);
            this.TB_PubName.MaxLength = 80;
            this.TB_PubName.Name = "TB_PubName";
            this.TB_PubName.Size = new System.Drawing.Size(201, 20);
            this.TB_PubName.TabIndex = 35;
            this.TB_PubName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TB_PubName_KeyUp);
            // 
            // lb_Year
            // 
            this.lb_Year.AutoSize = true;
            this.lb_Year.Location = new System.Drawing.Point(45, 329);
            this.lb_Year.Name = "lb_Year";
            this.lb_Year.Size = new System.Drawing.Size(70, 13);
            this.lb_Year.TabIndex = 36;
            this.lb_Year.Text = "Год издания";
            // 
            // TB_Year
            // 
            this.TB_Year.Location = new System.Drawing.Point(133, 327);
            this.TB_Year.MaxLength = 4;
            this.TB_Year.Name = "TB_Year";
            this.TB_Year.Size = new System.Drawing.Size(68, 20);
            this.TB_Year.TabIndex = 37;
            this.TB_Year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Year_KeyPress);
            this.TB_Year.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TB_Year_KeyUp);
            // 
            // lb_City
            // 
            this.lb_City.AutoSize = true;
            this.lb_City.Location = new System.Drawing.Point(33, 369);
            this.lb_City.Name = "lb_City";
            this.lb_City.Size = new System.Drawing.Size(82, 13);
            this.lb_City.TabIndex = 38;
            this.lb_City.Text = "Город издания";
            // 
            // TB_City
            // 
            this.TB_City.Location = new System.Drawing.Point(133, 367);
            this.TB_City.MaxLength = 40;
            this.TB_City.Name = "TB_City";
            this.TB_City.Size = new System.Drawing.Size(100, 20);
            this.TB_City.TabIndex = 39;
            this.TB_City.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_City_KeyPress);
            this.TB_City.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TB_City_KeyUp);
            // 
            // lb_ReleaseNumber
            // 
            this.lb_ReleaseNumber.AutoSize = true;
            this.lb_ReleaseNumber.Location = new System.Drawing.Point(35, 243);
            this.lb_ReleaseNumber.Name = "lb_ReleaseNumber";
            this.lb_ReleaseNumber.Size = new System.Drawing.Size(87, 13);
            this.lb_ReleaseNumber.TabIndex = 40;
            this.lb_ReleaseNumber.Text = "Номер выпуска";
            // 
            // TB_ReleaseNumber
            // 
            this.TB_ReleaseNumber.Location = new System.Drawing.Point(129, 241);
            this.TB_ReleaseNumber.MaxLength = 40;
            this.TB_ReleaseNumber.Name = "TB_ReleaseNumber";
            this.TB_ReleaseNumber.Size = new System.Drawing.Size(205, 20);
            this.TB_ReleaseNumber.TabIndex = 41;
            this.TB_ReleaseNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TB_ReleaseNumber_KeyUp);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(279, 419);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 42;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(13, 418);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 43;
            this.btn_Back.Text = "Назад";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 454);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.TB_ReleaseNumber);
            this.Controls.Add(this.lb_ReleaseNumber);
            this.Controls.Add(this.TB_City);
            this.Controls.Add(this.lb_City);
            this.Controls.Add(this.TB_Year);
            this.Controls.Add(this.lb_Year);
            this.Controls.Add(this.TB_PubName);
            this.Controls.Add(this.lb_PubName);
            this.Controls.Add(this.CB_PubType);
            this.Controls.Add(this.lb_PubType);
            this.Controls.Add(this.TB_Pages);
            this.Controls.Add(this.TB_ISBN);
            this.Controls.Add(this.TB_UDK);
            this.Controls.Add(this.TB_BBK);
            this.Controls.Add(this.TB_Author);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.lb_Publisher);
            this.Controls.Add(this.lb_Pages);
            this.Controls.Add(this.lb_ISBN);
            this.Controls.Add(this.lb_UDK);
            this.Controls.Add(this.lb_BBK);
            this.Controls.Add(this.lb_Author);
            this.Controls.Add(this.lb_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddBook";
            this.Text = "Добавление издания";
            this.Load += new System.EventHandler(this.AddBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TB_Pages;
        private System.Windows.Forms.TextBox TB_ISBN;
        private System.Windows.Forms.TextBox TB_UDK;
        private System.Windows.Forms.TextBox TB_BBK;
        private System.Windows.Forms.TextBox TB_Author;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Label lb_Publisher;
        private System.Windows.Forms.Label lb_Pages;
        private System.Windows.Forms.Label lb_ISBN;
        private System.Windows.Forms.Label lb_UDK;
        private System.Windows.Forms.Label lb_BBK;
        private System.Windows.Forms.Label lb_Author;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_PubType;
        private System.Windows.Forms.ComboBox CB_PubType;
        private System.Windows.Forms.Label lb_PubName;
        private System.Windows.Forms.TextBox TB_PubName;
        private System.Windows.Forms.Label lb_Year;
        private System.Windows.Forms.TextBox TB_Year;
        private System.Windows.Forms.Label lb_City;
        private System.Windows.Forms.TextBox TB_City;
        private System.Windows.Forms.Label lb_ReleaseNumber;
        private System.Windows.Forms.TextBox TB_ReleaseNumber;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Back;
    }
}