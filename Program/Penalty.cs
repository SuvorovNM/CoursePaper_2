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
        //PenaltyID - ID выбранного штрафа
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
            //Получение ФИО текущего читателя:
            string sql = "select FIO from Person, Reader where Person_Code=Person_ID and Library_Card=" + MainMenu.SelectedReader;
            DbDataReader reader = Control.ExecCommand(sql);
            reader.Read();
            lb_Name.Text = reader[0].ToString();
            reader.Close();
            //Получение итоговой суммы штрафов для выбранного читателя
            TB_CurrentPenaltySum.Text = Control.GetPenalty(MainMenu.SelectedReader);
            //Вывод всех прецедентов, повлекших наложение штрафов
            ShowPenalties();
        }

        private void ShowPenalties()
        //Вывод всех прецедентов, повлекших наложение штрафов
        {
            //Получение информации о всех штрафах для данного читателя, где сумма штрафа не равна 0
            string sql = "select Publication.Name as 'Название книги', Publication_ID as 'Код книги', Real_Return_Date as 'Дата возврата', Penalty_Info as 'Информация', Penalty_Sum as 'Сумма штрафа', Penalty_ID from Penalty, BookGiving, Publication where Penalty_Code IS NOT NULL and Publication_Code=Publication_ID and Penalty.Deleted=0 and Penalty_Sum<>'0.00' and BookGiving.Deleted=0 and Penalty_Code=Penalty_ID and Librarian_Card_Code=" + MainMenu.SelectedReader;
            DbDataReader reader = Control.ExecCommand(sql);
            if (reader.HasRows)
            //Если был найден хотя бы 1 штраф, сумма которого не равна 0
            {
                DGV_Penalties.Rows.Clear();
                DGV_Penalties.Columns.Clear();
                //Определение названий столбцов для DataGridView:
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    string str = reader.GetName(i);
                    DGV_Penalties.Columns.Add(str, str);
                }
                //Последний столбец (Penalty_ID) не виден пользователю
                DGV_Penalties.Columns[reader.FieldCount - 1].Visible = false;
                //Считывание и вывод первой строки:
                reader.Read();
                object[] temp = new object[reader.FieldCount];
                reader.GetValues(temp);
                temp[2] = ((DateTime)(temp[2])).ToShortDateString();
                DGV_Penalties.Rows.Add(temp);
                //Считывание и вывод остальных строк:
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
            //Если не было найдено ни 1 штрафа
            {
                reader.Close();
                DGV_Penalties.Rows.Clear();
                DGV_Penalties.Columns.Clear();
                btn_Pay.Enabled = false;
                MessageBox.Show("У данного читателя нет непогашенных штрафов!");
            }
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            //Погашение выбранного штрафа:
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
