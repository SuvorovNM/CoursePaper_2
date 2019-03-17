namespace Program
{
    partial class QBE
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
            this.CB_Entities = new System.Windows.Forms.ComboBox();
            this.lb_Entity = new System.Windows.Forms.Label();
            this.btn_AddOne = new System.Windows.Forms.Button();
            this.btn_AddAll = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_RemoveAll = new System.Windows.Forms.Button();
            this.CB_ChAt = new System.Windows.Forms.ComboBox();
            this.CB_Sign = new System.Windows.Forms.ComboBox();
            this.CB_Value = new System.Windows.Forms.ComboBox();
            this.CB_Conj = new System.Windows.Forms.ComboBox();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.DGV_Attributes = new System.Windows.Forms.DataGridView();
            this.DGV_Chosen = new System.Windows.Forms.DataGridView();
            this.lb_Filter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Attributes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Chosen)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_Entities
            // 
            this.CB_Entities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Entities.FormattingEnabled = true;
            this.CB_Entities.Items.AddRange(new object[] {
            "Address",
            "Book",
            "BookGiving",
            "Journal",
            "Librarian",
            "Penalty",
            "Person",
            "Publication",
            "Publisher",
            "Reader"});
            this.CB_Entities.Location = new System.Drawing.Point(68, 33);
            this.CB_Entities.Name = "CB_Entities";
            this.CB_Entities.Size = new System.Drawing.Size(121, 21);
            this.CB_Entities.TabIndex = 0;
            this.CB_Entities.SelectedIndexChanged += new System.EventHandler(this.CB_Entities_SelectedIndexChanged);
            // 
            // lb_Entity
            // 
            this.lb_Entity.AutoSize = true;
            this.lb_Entity.Location = new System.Drawing.Point(68, 17);
            this.lb_Entity.Name = "lb_Entity";
            this.lb_Entity.Size = new System.Drawing.Size(60, 13);
            this.lb_Entity.TabIndex = 1;
            this.lb_Entity.Text = "Сущности:";
            // 
            // btn_AddOne
            // 
            this.btn_AddOne.Location = new System.Drawing.Point(284, 71);
            this.btn_AddOne.Name = "btn_AddOne";
            this.btn_AddOne.Size = new System.Drawing.Size(31, 29);
            this.btn_AddOne.TabIndex = 3;
            this.btn_AddOne.Text = ">";
            this.btn_AddOne.UseVisualStyleBackColor = true;
            this.btn_AddOne.Click += new System.EventHandler(this.btn_AddOne_Click);
            // 
            // btn_AddAll
            // 
            this.btn_AddAll.Location = new System.Drawing.Point(284, 116);
            this.btn_AddAll.Name = "btn_AddAll";
            this.btn_AddAll.Size = new System.Drawing.Size(31, 29);
            this.btn_AddAll.TabIndex = 4;
            this.btn_AddAll.Text = ">>";
            this.btn_AddAll.UseVisualStyleBackColor = true;
            this.btn_AddAll.Click += new System.EventHandler(this.btn_AddAll_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(284, 163);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(31, 29);
            this.btn_Remove.TabIndex = 5;
            this.btn_Remove.Text = "<";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_RemoveAll
            // 
            this.btn_RemoveAll.Location = new System.Drawing.Point(284, 209);
            this.btn_RemoveAll.Name = "btn_RemoveAll";
            this.btn_RemoveAll.Size = new System.Drawing.Size(31, 29);
            this.btn_RemoveAll.TabIndex = 6;
            this.btn_RemoveAll.Text = "<<";
            this.btn_RemoveAll.UseVisualStyleBackColor = true;
            this.btn_RemoveAll.Click += new System.EventHandler(this.btn_RemoveAll_Click);
            // 
            // CB_ChAt
            // 
            this.CB_ChAt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_ChAt.FormattingEnabled = true;
            this.CB_ChAt.Location = new System.Drawing.Point(12, 277);
            this.CB_ChAt.Name = "CB_ChAt";
            this.CB_ChAt.Size = new System.Drawing.Size(177, 21);
            this.CB_ChAt.TabIndex = 8;
            this.CB_ChAt.SelectedIndexChanged += new System.EventHandler(this.CB_ChAt_SelectedIndexChanged);
            // 
            // CB_Sign
            // 
            this.CB_Sign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Sign.FormattingEnabled = true;
            this.CB_Sign.Items.AddRange(new object[] {
            ">",
            "<",
            "=",
            "<>"});
            this.CB_Sign.Location = new System.Drawing.Point(214, 277);
            this.CB_Sign.Name = "CB_Sign";
            this.CB_Sign.Size = new System.Drawing.Size(42, 21);
            this.CB_Sign.TabIndex = 9;
            this.CB_Sign.SelectedIndexChanged += new System.EventHandler(this.CB_Sign_SelectedIndexChanged);
            // 
            // CB_Value
            // 
            this.CB_Value.FormattingEnabled = true;
            this.CB_Value.Location = new System.Drawing.Point(279, 277);
            this.CB_Value.Name = "CB_Value";
            this.CB_Value.Size = new System.Drawing.Size(177, 21);
            this.CB_Value.TabIndex = 10;
            this.CB_Value.TextChanged += new System.EventHandler(this.CB_Value_TextChanged);
            // 
            // CB_Conj
            // 
            this.CB_Conj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Conj.FormattingEnabled = true;
            this.CB_Conj.Items.AddRange(new object[] {
            "And",
            "Or",
            "Пусто"});
            this.CB_Conj.Location = new System.Drawing.Point(478, 277);
            this.CB_Conj.Name = "CB_Conj";
            this.CB_Conj.Size = new System.Drawing.Size(53, 21);
            this.CB_Conj.TabIndex = 11;
            this.CB_Conj.SelectedIndexChanged += new System.EventHandler(this.CB_Conj_SelectedIndexChanged);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(538, 276);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(75, 23);
            this.btn_Next.TabIndex = 12;
            this.btn_Next.Text = "Следующее";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(548, 336);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 13;
            this.btn_OK.Text = "Обработать";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(13, 336);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 14;
            this.btn_Cancel.Text = "Отмена";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // DGV_Attributes
            // 
            this.DGV_Attributes.AllowUserToAddRows = false;
            this.DGV_Attributes.AllowUserToDeleteRows = false;
            this.DGV_Attributes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Attributes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGV_Attributes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV_Attributes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Attributes.Location = new System.Drawing.Point(68, 60);
            this.DGV_Attributes.MultiSelect = false;
            this.DGV_Attributes.Name = "DGV_Attributes";
            this.DGV_Attributes.ReadOnly = true;
            this.DGV_Attributes.RowHeadersVisible = false;
            this.DGV_Attributes.Size = new System.Drawing.Size(175, 187);
            this.DGV_Attributes.TabIndex = 15;
            // 
            // DGV_Chosen
            // 
            this.DGV_Chosen.AllowUserToAddRows = false;
            this.DGV_Chosen.AllowUserToDeleteRows = false;
            this.DGV_Chosen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Chosen.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGV_Chosen.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV_Chosen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Chosen.Location = new System.Drawing.Point(362, 60);
            this.DGV_Chosen.MultiSelect = false;
            this.DGV_Chosen.Name = "DGV_Chosen";
            this.DGV_Chosen.ReadOnly = true;
            this.DGV_Chosen.RowHeadersVisible = false;
            this.DGV_Chosen.Size = new System.Drawing.Size(251, 187);
            this.DGV_Chosen.TabIndex = 16;
            // 
            // lb_Filter
            // 
            this.lb_Filter.AutoSize = true;
            this.lb_Filter.Location = new System.Drawing.Point(15, 259);
            this.lb_Filter.Name = "lb_Filter";
            this.lb_Filter.Size = new System.Drawing.Size(50, 13);
            this.lb_Filter.TabIndex = 17;
            this.lb_Filter.Text = "Фильтр:";
            // 
            // QBE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 371);
            this.Controls.Add(this.lb_Filter);
            this.Controls.Add(this.DGV_Chosen);
            this.Controls.Add(this.DGV_Attributes);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.CB_Conj);
            this.Controls.Add(this.CB_Value);
            this.Controls.Add(this.CB_Sign);
            this.Controls.Add(this.CB_ChAt);
            this.Controls.Add(this.btn_RemoveAll);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_AddAll);
            this.Controls.Add(this.btn_AddOne);
            this.Controls.Add(this.lb_Entity);
            this.Controls.Add(this.CB_Entities);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QBE";
            this.Text = "Конструктор запросов";
            this.Load += new System.EventHandler(this.QBE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Attributes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Chosen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Entities;
        private System.Windows.Forms.Label lb_Entity;
        private System.Windows.Forms.Button btn_AddOne;
        private System.Windows.Forms.Button btn_AddAll;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_RemoveAll;
        private System.Windows.Forms.ComboBox CB_ChAt;
        private System.Windows.Forms.ComboBox CB_Sign;
        private System.Windows.Forms.ComboBox CB_Value;
        private System.Windows.Forms.ComboBox CB_Conj;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.DataGridView DGV_Attributes;
        private System.Windows.Forms.DataGridView DGV_Chosen;
        private System.Windows.Forms.Label lb_Filter;
    }
}