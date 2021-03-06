﻿namespace Program
{
    partial class QBE_Table
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
            this.DGV_Table = new System.Windows.Forms.DataGridView();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Output = new System.Windows.Forms.Button();
            this.lb_MaxCountRows = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Table
            // 
            this.DGV_Table.AllowUserToAddRows = false;
            this.DGV_Table.AllowUserToDeleteRows = false;
            this.DGV_Table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Table.Location = new System.Drawing.Point(13, 27);
            this.DGV_Table.Name = "DGV_Table";
            this.DGV_Table.ReadOnly = true;
            this.DGV_Table.Size = new System.Drawing.Size(564, 332);
            this.DGV_Table.TabIndex = 0;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Close.Location = new System.Drawing.Point(13, 365);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "Закрыть";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Output
            // 
            this.btn_Output.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Output.Location = new System.Drawing.Point(502, 365);
            this.btn_Output.Name = "btn_Output";
            this.btn_Output.Size = new System.Drawing.Size(75, 23);
            this.btn_Output.TabIndex = 2;
            this.btn_Output.Text = "Экспорт...";
            this.btn_Output.UseVisualStyleBackColor = true;
            this.btn_Output.Click += new System.EventHandler(this.btn_Output_Click);
            // 
            // lb_MaxCountRows
            // 
            this.lb_MaxCountRows.AutoSize = true;
            this.lb_MaxCountRows.Location = new System.Drawing.Point(11, 8);
            this.lb_MaxCountRows.Name = "lb_MaxCountRows";
            this.lb_MaxCountRows.Size = new System.Drawing.Size(282, 13);
            this.lb_MaxCountRows.TabIndex = 3;
            this.lb_MaxCountRows.Text = "Первые 10000 строк результата созданного запроса:";
            // 
            // QBE_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 400);
            this.Controls.Add(this.lb_MaxCountRows);
            this.Controls.Add(this.btn_Output);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.DGV_Table);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(613, 439);
            this.Name = "QBE_Table";
            this.Text = "Результат запроса";
            this.Load += new System.EventHandler(this.QBE_Table_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Table;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Output;
        private System.Windows.Forms.Label lb_MaxCountRows;
    }
}