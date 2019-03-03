namespace Program
{
    partial class AddReader
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
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_Phone = new System.Windows.Forms.Label();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_Birth = new System.Windows.Forms.Label();
            this.TB_Year = new System.Windows.Forms.TextBox();
            this.CB_Month = new System.Windows.Forms.ComboBox();
            this.TB_Day = new System.Windows.Forms.TextBox();
            this.lb_Region = new System.Windows.Forms.Label();
            this.CB_Region = new System.Windows.Forms.ComboBox();
            this.lb_City = new System.Windows.Forms.Label();
            this.TB_City = new System.Windows.Forms.TextBox();
            this.lb_Street = new System.Windows.Forms.Label();
            this.TB_Street = new System.Windows.Forms.TextBox();
            this.lb_House = new System.Windows.Forms.Label();
            this.TB_House = new System.Windows.Forms.TextBox();
            this.lb_Flat = new System.Windows.Forms.Label();
            this.TB_Flat = new System.Windows.Forms.TextBox();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.TB_Phone = new System.Windows.Forms.TextBox();
            this.TB_Email = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(13, 13);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(34, 13);
            this.lb_Name.TabIndex = 0;
            this.lb_Name.Text = "ФИО";
            // 
            // lb_Phone
            // 
            this.lb_Phone.AutoSize = true;
            this.lb_Phone.Location = new System.Drawing.Point(12, 47);
            this.lb_Phone.Name = "lb_Phone";
            this.lb_Phone.Size = new System.Drawing.Size(52, 13);
            this.lb_Phone.TabIndex = 1;
            this.lb_Phone.Text = "Телефон";
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Location = new System.Drawing.Point(16, 87);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(35, 13);
            this.lb_Email.TabIndex = 2;
            this.lb_Email.Text = "E-mail";
            // 
            // lb_Birth
            // 
            this.lb_Birth.AutoSize = true;
            this.lb_Birth.Location = new System.Drawing.Point(16, 124);
            this.lb_Birth.Name = "lb_Birth";
            this.lb_Birth.Size = new System.Drawing.Size(86, 13);
            this.lb_Birth.TabIndex = 3;
            this.lb_Birth.Text = "Дата рождения";
            // 
            // TB_Year
            // 
            this.TB_Year.Location = new System.Drawing.Point(232, 124);
            this.TB_Year.Name = "TB_Year";
            this.TB_Year.Size = new System.Drawing.Size(36, 20);
            this.TB_Year.TabIndex = 13;
            this.TB_Year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Year_KeyPress);
            this.TB_Year.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TB_Year_KeyUp);
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
            this.CB_Month.Location = new System.Drawing.Point(153, 124);
            this.CB_Month.Name = "CB_Month";
            this.CB_Month.Size = new System.Drawing.Size(73, 21);
            this.CB_Month.TabIndex = 12;
            this.CB_Month.SelectedValueChanged += new System.EventHandler(this.CB_Month_SelectedValueChanged);
            // 
            // TB_Day
            // 
            this.TB_Day.Location = new System.Drawing.Point(117, 124);
            this.TB_Day.Name = "TB_Day";
            this.TB_Day.Size = new System.Drawing.Size(30, 20);
            this.TB_Day.TabIndex = 11;
            this.TB_Day.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Day_KeyPress);
            this.TB_Day.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TB_Day_KeyUp);
            // 
            // lb_Region
            // 
            this.lb_Region.AutoSize = true;
            this.lb_Region.Location = new System.Drawing.Point(16, 163);
            this.lb_Region.Name = "lb_Region";
            this.lb_Region.Size = new System.Drawing.Size(43, 13);
            this.lb_Region.TabIndex = 14;
            this.lb_Region.Text = "Регион";
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
            this.CB_Region.Location = new System.Drawing.Point(117, 160);
            this.CB_Region.MaxLength = 50;
            this.CB_Region.Name = "CB_Region";
            this.CB_Region.Size = new System.Drawing.Size(193, 21);
            this.CB_Region.TabIndex = 15;
            this.CB_Region.DropDownClosed += new System.EventHandler(this.CB_Region_DropDownClosed);
            this.CB_Region.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CB_Region_KeyPress);
            this.CB_Region.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CB_Region_KeyUp);
            // 
            // lb_City
            // 
            this.lb_City.AutoSize = true;
            this.lb_City.Location = new System.Drawing.Point(19, 202);
            this.lb_City.Name = "lb_City";
            this.lb_City.Size = new System.Drawing.Size(37, 13);
            this.lb_City.TabIndex = 16;
            this.lb_City.Text = "Город";
            // 
            // TB_City
            // 
            this.TB_City.Location = new System.Drawing.Point(117, 202);
            this.TB_City.MaxLength = 50;
            this.TB_City.Name = "TB_City";
            this.TB_City.Size = new System.Drawing.Size(193, 20);
            this.TB_City.TabIndex = 17;
            this.TB_City.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_City_KeyPress);
            this.TB_City.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TB_City_KeyUp);
            // 
            // lb_Street
            // 
            this.lb_Street.AutoSize = true;
            this.lb_Street.Location = new System.Drawing.Point(19, 245);
            this.lb_Street.Name = "lb_Street";
            this.lb_Street.Size = new System.Drawing.Size(39, 13);
            this.lb_Street.TabIndex = 18;
            this.lb_Street.Text = "Улица";
            // 
            // TB_Street
            // 
            this.TB_Street.Location = new System.Drawing.Point(117, 245);
            this.TB_Street.MaxLength = 50;
            this.TB_Street.Name = "TB_Street";
            this.TB_Street.Size = new System.Drawing.Size(193, 20);
            this.TB_Street.TabIndex = 19;
            this.TB_Street.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TB_Street_KeyUp);
            // 
            // lb_House
            // 
            this.lb_House.AutoSize = true;
            this.lb_House.Location = new System.Drawing.Point(19, 287);
            this.lb_House.Name = "lb_House";
            this.lb_House.Size = new System.Drawing.Size(50, 13);
            this.lb_House.TabIndex = 20;
            this.lb_House.Text = "№ Дома";
            // 
            // TB_House
            // 
            this.TB_House.Location = new System.Drawing.Point(117, 287);
            this.TB_House.MaxLength = 8;
            this.TB_House.Name = "TB_House";
            this.TB_House.Size = new System.Drawing.Size(44, 20);
            this.TB_House.TabIndex = 21;
            this.TB_House.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TB_House_KeyUp);
            // 
            // lb_Flat
            // 
            this.lb_Flat.AutoSize = true;
            this.lb_Flat.Location = new System.Drawing.Point(19, 332);
            this.lb_Flat.Name = "lb_Flat";
            this.lb_Flat.Size = new System.Drawing.Size(55, 13);
            this.lb_Flat.TabIndex = 22;
            this.lb_Flat.Text = "Квартира";
            // 
            // TB_Flat
            // 
            this.TB_Flat.Location = new System.Drawing.Point(117, 329);
            this.TB_Flat.MaxLength = 5;
            this.TB_Flat.Name = "TB_Flat";
            this.TB_Flat.Size = new System.Drawing.Size(44, 20);
            this.TB_Flat.TabIndex = 23;
            this.TB_Flat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Flat_KeyPress);
            this.TB_Flat.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TB_Flat_KeyUp);
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(71, 10);
            this.TB_Name.MaxLength = 60;
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(239, 20);
            this.TB_Name.TabIndex = 24;
            this.TB_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Name_KeyPress);
            this.TB_Name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TB_Name_KeyUp);
            // 
            // TB_Phone
            // 
            this.TB_Phone.Location = new System.Drawing.Point(71, 45);
            this.TB_Phone.MaxLength = 18;
            this.TB_Phone.Name = "TB_Phone";
            this.TB_Phone.Size = new System.Drawing.Size(239, 20);
            this.TB_Phone.TabIndex = 25;
            this.TB_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Phone_KeyPress);
            this.TB_Phone.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TB_Phone_KeyUp);
            // 
            // TB_Email
            // 
            this.TB_Email.Location = new System.Drawing.Point(71, 87);
            this.TB_Email.MaxLength = 40;
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.Size = new System.Drawing.Size(239, 20);
            this.TB_Email.TabIndex = 26;
            this.TB_Email.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TB_Email_KeyUp);
            // 
            // btn_OK
            // 
            this.btn_OK.Enabled = false;
            this.btn_OK.Location = new System.Drawing.Point(243, 370);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 27;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(12, 370);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 28;
            this.btn_Cancel.Text = "Отмена";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // AddReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 403);
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
            this.Controls.Add(this.TB_Year);
            this.Controls.Add(this.CB_Month);
            this.Controls.Add(this.TB_Day);
            this.Controls.Add(this.lb_Birth);
            this.Controls.Add(this.lb_Email);
            this.Controls.Add(this.lb_Phone);
            this.Controls.Add(this.lb_Name);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddReader";
            this.Text = "Добавление читателя";
            this.Load += new System.EventHandler(this.AddReader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_Phone;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Label lb_Birth;
        private System.Windows.Forms.TextBox TB_Year;
        private System.Windows.Forms.ComboBox CB_Month;
        private System.Windows.Forms.TextBox TB_Day;
        private System.Windows.Forms.Label lb_Region;
        private System.Windows.Forms.ComboBox CB_Region;
        private System.Windows.Forms.Label lb_City;
        private System.Windows.Forms.TextBox TB_City;
        private System.Windows.Forms.Label lb_Street;
        private System.Windows.Forms.TextBox TB_Street;
        private System.Windows.Forms.Label lb_House;
        private System.Windows.Forms.TextBox TB_House;
        private System.Windows.Forms.Label lb_Flat;
        private System.Windows.Forms.TextBox TB_Flat;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.TextBox TB_Phone;
        private System.Windows.Forms.TextBox TB_Email;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
    }
}