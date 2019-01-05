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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CurrentBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_CurrentBooks
            // 
            this.DGV_CurrentBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CurrentBooks.Location = new System.Drawing.Point(13, 30);
            this.DGV_CurrentBooks.Name = "DGV_CurrentBooks";
            this.DGV_CurrentBooks.Size = new System.Drawing.Size(545, 321);
            this.DGV_CurrentBooks.TabIndex = 0;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(469, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Принять книгу";
            this.button1.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.DGV_CurrentBooks);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CurrentBooks";
            this.Text = "Текущие книги для читателя";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CurrentBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_CurrentBooks;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}