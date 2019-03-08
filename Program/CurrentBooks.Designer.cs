namespace Program
{
    partial class CurrentBooks
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
            this.DGV_CurrentBooks = new System.Windows.Forms.DataGridView();
            this.lb_Name = new System.Windows.Forms.Label();
            this.btn_Recieve = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CurrentBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_CurrentBooks
            // 
            this.DGV_CurrentBooks.AllowUserToAddRows = false;
            this.DGV_CurrentBooks.AllowUserToDeleteRows = false;
            this.DGV_CurrentBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CurrentBooks.Location = new System.Drawing.Point(13, 30);
            this.DGV_CurrentBooks.MultiSelect = false;
            this.DGV_CurrentBooks.Name = "DGV_CurrentBooks";
            this.DGV_CurrentBooks.ReadOnly = true;
            this.DGV_CurrentBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_CurrentBooks.Size = new System.Drawing.Size(545, 321);
            this.DGV_CurrentBooks.TabIndex = 1;
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(12, 9);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(82, 13);
            this.lb_Name.TabIndex = 1;
            this.lb_Name.Text = "ФИО читателя";
            // 
            // btn_Recieve
            // 
            this.btn_Recieve.Location = new System.Drawing.Point(469, 365);
            this.btn_Recieve.Name = "btn_Recieve";
            this.btn_Recieve.Size = new System.Drawing.Size(89, 23);
            this.btn_Recieve.TabIndex = 2;
            this.btn_Recieve.Text = "Принять книгу";
            this.btn_Recieve.UseVisualStyleBackColor = true;
            this.btn_Recieve.Click += new System.EventHandler(this.btn_Recieve_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CurrentBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 400);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Recieve);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.DGV_CurrentBooks);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CurrentBooks";
            this.Text = "Текущие книги для читателя";
            this.Load += new System.EventHandler(this.CurrentBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CurrentBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_CurrentBooks;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Button btn_Recieve;
        private System.Windows.Forms.Button button2;
    }
}