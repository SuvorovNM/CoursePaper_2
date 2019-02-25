namespace Program
{
    partial class BookInfo
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
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_Author = new System.Windows.Forms.Label();
            this.lb_BBK = new System.Windows.Forms.Label();
            this.lb_UDK = new System.Windows.Forms.Label();
            this.lb_ISBN = new System.Windows.Forms.Label();
            this.lb_Pages = new System.Windows.Forms.Label();
            this.lb_Publisher = new System.Windows.Forms.Label();
            this.TB_BookID = new System.Windows.Forms.TextBox();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.TB_Author = new System.Windows.Forms.TextBox();
            this.TB_BBK = new System.Windows.Forms.TextBox();
            this.TB_UDK = new System.Windows.Forms.TextBox();
            this.TB_ISBN = new System.Windows.Forms.TextBox();
            this.TB_Pages = new System.Windows.Forms.TextBox();
            this.RTB_Publisher = new System.Windows.Forms.RichTextBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lb_Availability = new System.Windows.Forms.Label();
            this.TB_Availability = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_BookID
            // 
            this.lb_BookID.AutoSize = true;
            this.lb_BookID.Location = new System.Drawing.Point(13, 13);
            this.lb_BookID.Name = "lb_BookID";
            this.lb_BookID.Size = new System.Drawing.Size(119, 13);
            this.lb_BookID.TabIndex = 0;
            this.lb_BookID.Text = "Идентификатор книги";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(43, 50);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(89, 13);
            this.lb_Name.TabIndex = 1;
            this.lb_Name.Text = "Название книги";
            // 
            // lb_Author
            // 
            this.lb_Author.AutoSize = true;
            this.lb_Author.Location = new System.Drawing.Point(95, 85);
            this.lb_Author.Name = "lb_Author";
            this.lb_Author.Size = new System.Drawing.Size(37, 13);
            this.lb_Author.TabIndex = 2;
            this.lb_Author.Text = "Автор";
            // 
            // lb_BBK
            // 
            this.lb_BBK.AutoSize = true;
            this.lb_BBK.Location = new System.Drawing.Point(104, 120);
            this.lb_BBK.Name = "lb_BBK";
            this.lb_BBK.Size = new System.Drawing.Size(28, 13);
            this.lb_BBK.TabIndex = 3;
            this.lb_BBK.Text = "ББК";
            // 
            // lb_UDK
            // 
            this.lb_UDK.AutoSize = true;
            this.lb_UDK.Location = new System.Drawing.Point(101, 152);
            this.lb_UDK.Name = "lb_UDK";
            this.lb_UDK.Size = new System.Drawing.Size(31, 13);
            this.lb_UDK.TabIndex = 4;
            this.lb_UDK.Text = "УДК";
            // 
            // lb_ISBN
            // 
            this.lb_ISBN.AutoSize = true;
            this.lb_ISBN.Location = new System.Drawing.Point(71, 185);
            this.lb_ISBN.Name = "lb_ISBN";
            this.lb_ISBN.Size = new System.Drawing.Size(62, 13);
            this.lb_ISBN.TabIndex = 5;
            this.lb_ISBN.Text = "ISBN/ISSN";
            // 
            // lb_Pages
            // 
            this.lb_Pages.AutoSize = true;
            this.lb_Pages.Location = new System.Drawing.Point(47, 224);
            this.lb_Pages.Name = "lb_Pages";
            this.lb_Pages.Size = new System.Drawing.Size(85, 13);
            this.lb_Pages.TabIndex = 6;
            this.lb_Pages.Text = "Кол-во страниц";
            // 
            // lb_Publisher
            // 
            this.lb_Publisher.AutoSize = true;
            this.lb_Publisher.Location = new System.Drawing.Point(12, 262);
            this.lb_Publisher.Name = "lb_Publisher";
            this.lb_Publisher.Size = new System.Drawing.Size(82, 13);
            this.lb_Publisher.TabIndex = 7;
            this.lb_Publisher.Text = "Издательство:";
            // 
            // TB_BookID
            // 
            this.TB_BookID.Location = new System.Drawing.Point(139, 13);
            this.TB_BookID.Name = "TB_BookID";
            this.TB_BookID.ReadOnly = true;
            this.TB_BookID.Size = new System.Drawing.Size(205, 20);
            this.TB_BookID.TabIndex = 8;
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(139, 47);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.ReadOnly = true;
            this.TB_Name.Size = new System.Drawing.Size(205, 20);
            this.TB_Name.TabIndex = 9;
            // 
            // TB_Author
            // 
            this.TB_Author.Location = new System.Drawing.Point(139, 82);
            this.TB_Author.Name = "TB_Author";
            this.TB_Author.ReadOnly = true;
            this.TB_Author.Size = new System.Drawing.Size(205, 20);
            this.TB_Author.TabIndex = 10;
            // 
            // TB_BBK
            // 
            this.TB_BBK.Location = new System.Drawing.Point(139, 113);
            this.TB_BBK.Name = "TB_BBK";
            this.TB_BBK.ReadOnly = true;
            this.TB_BBK.Size = new System.Drawing.Size(205, 20);
            this.TB_BBK.TabIndex = 11;
            // 
            // TB_UDK
            // 
            this.TB_UDK.Location = new System.Drawing.Point(139, 148);
            this.TB_UDK.Name = "TB_UDK";
            this.TB_UDK.ReadOnly = true;
            this.TB_UDK.Size = new System.Drawing.Size(205, 20);
            this.TB_UDK.TabIndex = 12;
            // 
            // TB_ISBN
            // 
            this.TB_ISBN.Location = new System.Drawing.Point(139, 182);
            this.TB_ISBN.Name = "TB_ISBN";
            this.TB_ISBN.ReadOnly = true;
            this.TB_ISBN.Size = new System.Drawing.Size(205, 20);
            this.TB_ISBN.TabIndex = 13;
            // 
            // TB_Pages
            // 
            this.TB_Pages.Location = new System.Drawing.Point(139, 221);
            this.TB_Pages.Name = "TB_Pages";
            this.TB_Pages.ReadOnly = true;
            this.TB_Pages.Size = new System.Drawing.Size(68, 20);
            this.TB_Pages.TabIndex = 14;
            // 
            // RTB_Publisher
            // 
            this.RTB_Publisher.Location = new System.Drawing.Point(98, 261);
            this.RTB_Publisher.Name = "RTB_Publisher";
            this.RTB_Publisher.ReadOnly = true;
            this.RTB_Publisher.Size = new System.Drawing.Size(246, 96);
            this.RTB_Publisher.TabIndex = 15;
            this.RTB_Publisher.Text = "";
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(268, 415);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 16;
            this.btn_Back.Text = "Назад";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lb_Availability
            // 
            this.lb_Availability.AutoSize = true;
            this.lb_Availability.Location = new System.Drawing.Point(82, 366);
            this.lb_Availability.Name = "lb_Availability";
            this.lb_Availability.Size = new System.Drawing.Size(50, 13);
            this.lb_Availability.TabIndex = 17;
            this.lb_Availability.Text = "Наличие";
            // 
            // TB_Availability
            // 
            this.TB_Availability.Location = new System.Drawing.Point(139, 363);
            this.TB_Availability.Name = "TB_Availability";
            this.TB_Availability.ReadOnly = true;
            this.TB_Availability.Size = new System.Drawing.Size(205, 20);
            this.TB_Availability.TabIndex = 18;
            // 
            // BookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 450);
            this.Controls.Add(this.TB_Availability);
            this.Controls.Add(this.lb_Availability);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.RTB_Publisher);
            this.Controls.Add(this.TB_Pages);
            this.Controls.Add(this.TB_ISBN);
            this.Controls.Add(this.TB_UDK);
            this.Controls.Add(this.TB_BBK);
            this.Controls.Add(this.TB_Author);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.TB_BookID);
            this.Controls.Add(this.lb_Publisher);
            this.Controls.Add(this.lb_Pages);
            this.Controls.Add(this.lb_ISBN);
            this.Controls.Add(this.lb_UDK);
            this.Controls.Add(this.lb_BBK);
            this.Controls.Add(this.lb_Author);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.lb_BookID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookInfo";
            this.Text = "Информация о книге";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_BookID;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_Author;
        private System.Windows.Forms.Label lb_BBK;
        private System.Windows.Forms.Label lb_UDK;
        private System.Windows.Forms.Label lb_ISBN;
        private System.Windows.Forms.Label lb_Pages;
        private System.Windows.Forms.Label lb_Publisher;
        private System.Windows.Forms.TextBox TB_BookID;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.TextBox TB_Author;
        private System.Windows.Forms.TextBox TB_BBK;
        private System.Windows.Forms.TextBox TB_UDK;
        private System.Windows.Forms.TextBox TB_ISBN;
        private System.Windows.Forms.TextBox TB_Pages;
        private System.Windows.Forms.RichTextBox RTB_Publisher;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label lb_Availability;
        private System.Windows.Forms.TextBox TB_Availability;
    }
}