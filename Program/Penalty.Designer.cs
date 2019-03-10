namespace Program
{
    partial class Penalty
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
            this.lb_CurrentPenalty = new System.Windows.Forms.Label();
            this.TB_CurrentPenaltySum = new System.Windows.Forms.TextBox();
            this.lb_Currency = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Pay = new System.Windows.Forms.Button();
            this.DGV_Penalties = new System.Windows.Forms.DataGridView();
            this.lb_Precedents = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Penalties)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(13, 13);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(82, 13);
            this.lb_Name.TabIndex = 0;
            this.lb_Name.Text = "ФИО читателя";
            // 
            // lb_CurrentPenalty
            // 
            this.lb_CurrentPenalty.AutoSize = true;
            this.lb_CurrentPenalty.Location = new System.Drawing.Point(278, 13);
            this.lb_CurrentPenalty.Name = "lb_CurrentPenalty";
            this.lb_CurrentPenalty.Size = new System.Drawing.Size(88, 13);
            this.lb_CurrentPenalty.TabIndex = 1;
            this.lb_CurrentPenalty.Text = "Текущий штраф";
            // 
            // TB_CurrentPenaltySum
            // 
            this.TB_CurrentPenaltySum.Location = new System.Drawing.Point(373, 11);
            this.TB_CurrentPenaltySum.Name = "TB_CurrentPenaltySum";
            this.TB_CurrentPenaltySum.ReadOnly = true;
            this.TB_CurrentPenaltySum.Size = new System.Drawing.Size(80, 20);
            this.TB_CurrentPenaltySum.TabIndex = 2;
            // 
            // lb_Currency
            // 
            this.lb_Currency.AutoSize = true;
            this.lb_Currency.Location = new System.Drawing.Point(457, 15);
            this.lb_Currency.Name = "lb_Currency";
            this.lb_Currency.Size = new System.Drawing.Size(27, 13);
            this.lb_Currency.TabIndex = 3;
            this.lb_Currency.Text = "руб.";
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(12, 368);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 7;
            this.btn_Back.Text = "Назад";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Pay
            // 
            this.btn_Pay.Location = new System.Drawing.Point(423, 368);
            this.btn_Pay.Name = "btn_Pay";
            this.btn_Pay.Size = new System.Drawing.Size(75, 23);
            this.btn_Pay.TabIndex = 8;
            this.btn_Pay.Text = "Погасить штраф";
            this.btn_Pay.UseVisualStyleBackColor = true;
            this.btn_Pay.Click += new System.EventHandler(this.btn_Pay_Click);
            // 
            // DGV_Penalties
            // 
            this.DGV_Penalties.AllowUserToAddRows = false;
            this.DGV_Penalties.AllowUserToDeleteRows = false;
            this.DGV_Penalties.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.DGV_Penalties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Penalties.Location = new System.Drawing.Point(13, 54);
            this.DGV_Penalties.MultiSelect = false;
            this.DGV_Penalties.Name = "DGV_Penalties";
            this.DGV_Penalties.ReadOnly = true;
            this.DGV_Penalties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Penalties.Size = new System.Drawing.Size(485, 273);
            this.DGV_Penalties.TabIndex = 1;
            this.DGV_Penalties.SelectionChanged += new System.EventHandler(this.DGV_Penalties_SelectionChanged);
            // 
            // lb_Precedents
            // 
            this.lb_Precedents.AutoSize = true;
            this.lb_Precedents.Location = new System.Drawing.Point(13, 38);
            this.lb_Precedents.Name = "lb_Precedents";
            this.lb_Precedents.Size = new System.Drawing.Size(284, 13);
            this.lb_Precedents.TabIndex = 10;
            this.lb_Precedents.Text = "Прецеденты, повлекшие за собой наложение штрафа:";
            // 
            // Penalty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 402);
            this.Controls.Add(this.lb_Precedents);
            this.Controls.Add(this.DGV_Penalties);
            this.Controls.Add(this.btn_Pay);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.lb_Currency);
            this.Controls.Add(this.TB_CurrentPenaltySum);
            this.Controls.Add(this.lb_CurrentPenalty);
            this.Controls.Add(this.lb_Name);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Penalty";
            this.Text = "Список штрафов";
            this.Load += new System.EventHandler(this.Penalty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Penalties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_CurrentPenalty;
        private System.Windows.Forms.TextBox TB_CurrentPenaltySum;
        private System.Windows.Forms.Label lb_Currency;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Pay;
        private System.Windows.Forms.DataGridView DGV_Penalties;
        private System.Windows.Forms.Label lb_Precedents;
    }
}