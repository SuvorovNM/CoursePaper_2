using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace Program
{
    public partial class Penalty : Form
    {
        string PenaltyID = "0";
        public Penalty()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)8)) return;
            else
                e.Handled = true;
        }

        private void Penalty_Load(object sender, EventArgs e)
        {
            string sql = "select FIO from Person, Reader where Person_Code=Person_ID and Library_Card=" + MainMenu.SelectedReader;
            DbDataReader reader = Control.ExecCommand(sql);
            reader.Read();
            lb_Name.Text = reader[0].ToString();
            reader.Close();
            TB_CurrentPenaltySum.Text = Control.GetPenalty(MainMenu.SelectedReader);
            ShowPenalties();
        }

        private void ShowPenalties()
        {
            string sql = "select Publication.Name as 'Название книги', Publication_ID as 'Код книги', Real_Return_Date as 'Дата возврата', Penalty_Info as 'Информация', Penalty_Sum as 'Сумма штрафа', Penalty_ID from Penalty, BookGiving, Publication where Penalty_Code IS NOT NULL and Publication_Code=Publication_ID and Penalty.Deleted=0 and Penalty_Sum<>'0.00' and BookGiving.Deleted=0 and Penalty_Code=Penalty_ID and Librarian_Card_Code=" + MainMenu.SelectedReader;
            DbDataReader reader = Control.ExecCommand(sql);
            if (reader.HasRows)
            {
                //reader.Read();
                DGV_Penalties.Rows.Clear();
                DGV_Penalties.Columns.Clear();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    string str = reader.GetName(i);
                    DGV_Penalties.Columns.Add(str, str);
                }
                DGV_Penalties.Columns[reader.FieldCount - 1].Visible = false;
                reader.Read();
                object[] temp = new object[reader.FieldCount];
                reader.GetValues(temp);
                temp[2] = ((DateTime)(temp[2])).ToShortDateString();
                DGV_Penalties.Rows.Add(temp);
                while (reader.Read())
                {
                    temp = new object[reader.FieldCount];
                    reader.GetValues(temp);
                    temp[2] = ((DateTime)(temp[2])).ToShortDateString();
                    DGV_Penalties.Rows.Add(temp);
                }
                reader.Close();
                btn_Pay.Enabled = true;
            }
            else
            {
                reader.Close();//
                DGV_Penalties.Rows.Clear();
                DGV_Penalties.Columns.Clear();
                btn_Pay.Enabled = false;
                MessageBox.Show("У данного читателя нет непогашенных штрафов!");
            }
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            //string PenaltyID = DGV_Penalties.SelectedRows.
            PenaltyID= DGV_Penalties.CurrentRow.Cells[5].Value.ToString();
            string sql = "update Penalty set Deleted=1 where Penalty_ID="+PenaltyID;
            DbDataReader reader = Control.ExecCommand(sql);
            reader.Close();
            MessageBox.Show("Штраф был успешно погашен!");
            ShowPenalties();
            TB_CurrentPenaltySum.Text = Control.GetPenalty(MainMenu.SelectedReader);
        }

        private void DGV_Penalties_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
