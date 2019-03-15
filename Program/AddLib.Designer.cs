namespace Program
{
    partial class AddLib
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.TB_Email = new System.Windows.Forms.TextBox();
            this.TB_Phone = new System.Windows.Forms.TextBox();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.TB_Flat = new System.Windows.Forms.TextBox();
            this.lb_Flat = new System.Windows.Forms.Label();
            this.TB_House = new System.Windows.Forms.TextBox();
            this.lb_House = new System.Windows.Forms.Label();
            this.TB_Street = new System.Windows.Forms.TextBox();
            this.lb_Street = new System.Windows.Forms.Label();
            this.TB_City = new System.Windows.Forms.TextBox();
            this.lb_City = new System.Windows.Forms.Label();
            this.CB_Region = new System.Windows.Forms.ComboBox();
            this.lb_Region = new System.Windows.Forms.Label();
            this.lb_Birth = new System.Windows.Forms.Label();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_Phone = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.DTP_Birth = new System.Windows.Forms.DateTimePicker();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lb_Pass = new System.Windows.Forms.Label();
            this.DTP_Hiring_Date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(12, 444);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 50;
            this.btn_Cancel.Text = "Отмена";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Enabled = false;
            this.btn_OK.Location = new System.Drawing.Point(234, 444);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 49;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // TB_Email
            // 
            this.TB_Email.Location = new System.Drawing.Point(70, 83);
            this.TB_Email.MaxLength = 40;
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.Size = new System.Drawing.Size(239, 20);
            this.TB_Email.TabIndex = 48;
            this.TB_Email.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TB_Email_KeyUp);
            // 
            // TB_Phone
            // 
            this.TB_Phone.Location = new System.Drawing.Point(70, 41);
            this.TB_Phone.MaxLength = 18;
            this.TB_Phone.Name = "TB_Phone";
            this.TB_Phone.Size = new System.Drawing.Size(239, 20);
            this.TB_Phone.TabIndex = 47;
            this.TB_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Phone_KeyPress);
            this.TB_Phone.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TB_Phone_KeyUp);
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(70, 6);
            this.TB_Name.MaxLength = 60;
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(239, 20);
            this.TB_Name.TabIndex = 46;
            this.TB_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Name_KeyPress);
            this.TB_Name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TB_Name_KeyUp);
            // 
            // TB_Flat
            // 
            this.TB_Flat.Location = new System.Drawing.Point(116, 325);
            this.TB_Flat.MaxLength = 5;
            this.TB_Flat.Name = "TB_Flat";
            this.TB_Flat.Size = new System.Drawing.Size(44, 20);
            this.TB_Flat.TabIndex = 45;
            this.TB_Flat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Flat_KeyPress);
            this.TB_Flat.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TB_Flat_KeyUp);
            // 
            // lb_Flat
            // 
            this.lb_Flat.AutoSize = true;
            this.lb_Flat.Location = new System.Drawing.Point(15, 328);
            this.lb_Flat.Name = "lb_Flat";
            this.lb_Flat.Size = new System.Drawing.Size(55, 13);
            this.lb_Flat.TabIndex = 44;
            this.lb_Flat.Text = "Квартира";
            // 
            // TB_House
            // 
            this.TB_House.Location = new System.Drawing.Point(116, 283);
            this.TB_House.MaxLength = 8;
            this.TB_House.Name = "TB_House";
            this.TB_House.Size = new System.Drawing.Size(44, 20);
            this.TB_House.TabIndex = 43;
            this.TB_House.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TB_House_KeyUp);
            // 
            // lb_House
            // 
            this.lb_House.AutoSize = true;
            this.lb_House.Location = new System.Drawing.Point(18, 283);
            this.lb_House.Name = "lb_House";
            this.lb_House.Size = new System.Drawing.Size(50, 13);
            this.lb_House.TabIndex = 42;
            this.lb_House.Text = "№ Дома";
            // 
            // TB_Street
            // 
            this.TB_Street.Location = new System.Drawing.Point(116, 241);
            this.TB_Street.MaxLength = 50;
            this.TB_Street.Name = "TB_Street";
            this.TB_Street.Size = new System.Drawing.Size(193, 20);
            this.TB_Street.TabIndex = 41;
            this.TB_Street.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TB_Street_KeyUp);
            // 
            // lb_Street
            // 
            this.lb_Street.AutoSize = true;
            this.lb_Street.Location = new System.Drawing.Point(18, 241);
            this.lb_Street.Name = "lb_Street";
            this.lb_Street.Size = new System.Drawing.Size(39, 13);
            this.lb_Street.TabIndex = 40;
            this.lb_Street.Text = "Улица";
            // 
            // TB_City
            // 
            this.TB_City.Location = new System.Drawing.Point(116, 198);
            this.TB_City.MaxLength = 50;
            this.TB_City.Name = "TB_City";
            this.TB_City.Size = new System.Drawing.Size(193, 20);
            this.TB_City.TabIndex = 39;
            this.TB_City.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_City_KeyPress);
            this.TB_City.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TB_City_KeyUp);
            // 
            // lb_City
            // 
            this.lb_City.AutoSize = true;
            this.lb_City.Location = new System.Drawing.Point(18, 198);
            this.lb_City.Name = "lb_City";
            this.lb_City.Size = new System.Drawing.Size(37, 13);
            this.lb_City.TabIndex = 38;
            this.lb_City.Text = "Город";
            // 
            // CB_Region
            // 
            this.CB_Region.FormattingEnabled = true;
            this.CB_Region.Items.AddRange(new object[] {
            "Адыгея ",
            "Алтайский край",
            "Амурская область",
            "Архангельская область ",
            "Астраханская область ",
            "Башкортостан ",
            "Белгородская область ",
            "Брянская область ",
            "Бурятия     ",
            "Владимирская область ",
            "Волгоградская область ",
            "Вологодская область ",
            "Воронежская область ",
            "Дагестан ",
            "Еврейская АО ",
            "Ивановская область ",
            "Ингушетия ",
            "Иркутская область ",
            "Кабардино-Балкария ",
            "Калининградская область ",
            "Калмыкия ",
            "Калужская область ",
            "Камчатка ",
            "Карачаево-Черкессия ",
            "Карелия ",
            "Кемеровская область ",
            "Кировская область ",
            "Коми Республика ",
            "Костромская область ",
            "Краснодарский край ",
            "Красноярский край ",
            "Курганская область ",
            "Курская область ",
            "Ленинградская область ",
            "Липецкая область ",
            "Магаданская область ",
            "Мари-Эл ",
            "Мордовия ",
            "Московская область",
            "Мурманская область ",
            "Нижегородская область",
            "Новгородская область ",
            "Новосибирская область ",
            "Омская область ",
            "Оренбургская область ",
            "Орловская область ",
            "Пензенская область ",
            "Пермский край",
            "Приморский край ",
            "Псковская область ",
            "Ростовская область ",
            "Рязанская область ",
            "Самарская область ",
            "Саратовская область ",
            "Сахалин ",
            "Свердловская область ",
            "Северная Осетия ",
            "Смоленская область ",
            "Ставропольский край ",
            "Таймыр ",
            "Тамбовская область",
            "Татарстан ",
            "Тверская область ",
            "Томская область ",
            "Тува ",
            "Тульская область ",
            "Тюменская область ",
            "Удмуртия ",
            "Ульяновская область ",
            "Усть-Ордынский АО ",
            "Хабаровский край ",
            "Хакассия ",
            "Ханты-Мансийск ",
            "Челябинская область ",
            "Чеченская Республика ",
            "Читинская область ",
            "Чувашская Республика ",
            "Якутия (Саха) ",
            "Ямало-Ненецкий АО ",
            "Ярославская область"});
            this.CB_Region.Location = new System.Drawing.Point(116, 156);
            this.CB_Region.MaxLength = 50;
            this.CB_Region.Name = "CB_Region";
            this.CB_Region.Size = new System.Drawing.Size(193, 21);
            this.CB_Region.TabIndex = 37;
            this.CB_Region.DropDownClosed += new System.EventHandler(this.CB_Region_DropDownClosed);
            this.CB_Region.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CB_Region_KeyPress);
            this.CB_Region.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CB_Region_KeyUp);
            // 
            // lb_Region
            // 
            this.lb_Region.AutoSize = true;
            this.lb_Region.Location = new System.Drawing.Point(15, 159);
            this.lb_Region.Name = "lb_Region";
            this.lb_Region.Size = new System.Drawing.Size(43, 13);
            this.lb_Region.TabIndex = 36;
            this.lb_Region.Text = "Регион";
            // 
            // lb_Birth
            // 
            this.lb_Birth.AutoSize = true;
            this.lb_Birth.Location = new System.Drawing.Point(15, 120);
            this.lb_Birth.Name = "lb_Birth";
            this.lb_Birth.Size = new System.Drawing.Size(86, 13);
            this.lb_Birth.TabIndex = 32;
            this.lb_Birth.Text = "Дата рождения";
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Location = new System.Drawing.Point(15, 83);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(35, 13);
            this.lb_Email.TabIndex = 31;
            this.lb_Email.Text = "E-mail";
            // 
            // lb_Phone
            // 
            this.lb_Phone.AutoSize = true;
            this.lb_Phone.Location = new System.Drawing.Point(11, 43);
            this.lb_Phone.Name = "lb_Phone";
            this.lb_Phone.Size = new System.Drawing.Size(52, 13);
            this.lb_Phone.TabIndex = 30;
            this.lb_Phone.Text = "Телефон";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(12, 9);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(34, 13);
            this.lb_Name.TabIndex = 29;
            this.lb_Name.Text = "ФИО";
            // 
            // DTP_Birth
            // 
            this.DTP_Birth.Location = new System.Drawing.Point(108, 119);
            this.DTP_Birth.MaxDate = new System.DateTime(2005, 1, 1, 0, 0, 0, 0);
            this.DTP_Birth.MinDate = new System.DateTime(1899, 1, 1, 0, 0, 0, 0);
            this.DTP_Birth.Name = "DTP_Birth";
            this.DTP_Birth.Size = new System.Drawing.Size(201, 20);
            this.DTP_Birth.TabIndex = 51;
            this.DTP_Birth.Value = new System.DateTime(2005, 1, 1, 0, 0, 0, 0);
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(116, 366);
            this.tb_Password.MaxLength = 50;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(193, 20);
            this.tb_Password.TabIndex = 52;
            this.tb_Password.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_Password_KeyUp);
            // 
            // lb_Pass
            // 
            this.lb_Pass.AutoSize = true;
            this.lb_Pass.Location = new System.Drawing.Point(15, 369);
            this.lb_Pass.Name = "lb_Pass";
            this.lb_Pass.Size = new System.Drawing.Size(98, 13);
            this.lb_Pass.TabIndex = 53;
            this.lb_Pass.Text = "Пароль для входа";
            // 
            // DTP_Hiring_Date
            // 
            this.DTP_Hiring_Date.Checked = false;
            this.DTP_Hiring_Date.Location = new System.Drawing.Point(116, 401);
            this.DTP_Hiring_Date.MaxDate = new System.DateTime(2050, 1, 1, 0, 0, 0, 0);
            this.DTP_Hiring_Date.MinDate = new System.DateTime(1899, 1, 1, 0, 0, 0, 0);
            this.DTP_Hiring_Date.Name = "DTP_Hiring_Date";
            this.DTP_Hiring_Date.Size = new System.Drawing.Size(193, 20);
            this.DTP_Hiring_Date.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Дата принятия";
            // 
            // AddLib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 479);
            this.Controls.Add(this.DTP_Hiring_Date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Pass);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.DTP_Birth);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.TB_Email);
            this.Controls.Add(this.TB_Phone);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.TB_Flat);
            this.Controls.Add(this.lb_Flat);
            this.Controls.Add(this.TB_House);
            this.Controls.Add(this.lb_House);
            this.Controls.Add(this.TB_Street);
            this.Controls.Add(this.lb_Street);
            this.Controls.Add(this.TB_City);
            this.Controls.Add(this.lb_City);
            this.Controls.Add(this.CB_Region);
            this.Controls.Add(this.lb_Region);
            this.Controls.Add(this.lb_Birth);
            this.Controls.Add(this.lb_Email);
            this.Controls.Add(this.lb_Phone);
            this.Controls.Add(this.lb_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddLib";
            this.Text = "Добавление библиотекаря";
            this.Load += new System.EventHandler(this.AddLib_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.TextBox TB_Email;
        private System.Windows.Forms.TextBox TB_Phone;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.TextBox TB_Flat;
        private System.Windows.Forms.Label lb_Flat;
        private System.Windows.Forms.TextBox TB_House;
        private System.Windows.Forms.Label lb_House;
        private System.Windows.Forms.TextBox TB_Street;
        private System.Windows.Forms.Label lb_Street;
        private System.Windows.Forms.TextBox TB_City;
        private System.Windows.Forms.Label lb_City;
        private System.Windows.Forms.ComboBox CB_Region;
        private System.Windows.Forms.Label lb_Region;
        private System.Windows.Forms.Label lb_Birth;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Label lb_Phone;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.DateTimePicker DTP_Birth;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label lb_Pass;
        private System.Windows.Forms.DateTimePicker DTP_Hiring_Date;
        private System.Windows.Forms.Label label1;
    }
}