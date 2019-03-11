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
    public partial class QBE_Table : Form
    {
        //sql - переданный SQL-запрос из формы QBE
        string sql = "";
        public QBE_Table(string _sql)
        {
            InitializeComponent();
            sql = _sql;
        }

        private void QBE_Table_Load(object sender, EventArgs e)
        {
            try
            {
                DbDataReader reader = Control.ExecCommand(sql);
                if (reader.HasRows)
                //Если результат SQL-запроса не пуст
                {
                    DGV_Table.Rows.Clear();
                    DGV_Table.Columns.Clear();
                    //Определение названий столбцов для DataGridView:
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        string str = reader.GetName(i);
                        DGV_Table.Columns.Add(str, str);
                    }
                    //Считывание и обработка 1 строки:
                    reader.Read();
                    object[] temp = new object[reader.FieldCount];
                    reader.GetValues(temp);
                    //Удаление ЧЧ:ММ из дат:
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        if (temp[i] is DateTime)
                        {
                            temp[i] = ((DateTime)temp[i]).ToShortDateString();
                        }
                    }
                    DGV_Table.Rows.Add(temp);
                    //Считывание и обработка остальных строк:
                    while (reader.Read())
                    {
                        temp = new object[reader.FieldCount];
                        reader.GetValues(temp);
                        //Удаление ЧЧ:ММ из дат:
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            if (temp[i] is DateTime)
                            {
                                temp[i] = ((DateTime)temp[i]).ToShortDateString();
                            }
                        }
                        DGV_Table.Rows.Add(temp);
                    }
                    reader.Close();
                }
                else
                //Если результат SQL-запроса пуст
                {
                    reader.Close();
                    DGV_Table.Rows.Clear();
                    DGV_Table.Columns.Clear();
                    MessageBox.Show("Не было найдено ни 1 строки, удовлетворяющей запросу!");
                    Close();
                }
            }
            catch(Exception ex)
            //Если при обработке запроса произошла ошибка:
            {
                MessageBox.Show("При обработке запроса возникла ошибка: " + ex.Message);
                Close();
            }
        }

        private void btn_Output_Click(object sender, EventArgs e)
        //Экспорт полученной таблицы в файл с расширением .xlsx
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel files (*.xlsx)|*.xlsx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //data - матрица, представляющая полученную таблицу
                string[,] data = new string[DGV_Table.Rows.Count + 1, DGV_Table.Columns.Count];
                for (int t=0;t< DGV_Table.Columns.Count; t++)
                {
                    data[0, t] = DGV_Table.Columns[t].Name;
                }
                for (int i=1;i< DGV_Table.Rows.Count + 1; i++)
                {
                    for (int j=0;j< DGV_Table.Columns.Count; j++)
                    {
                        data[i, j] = DGV_Table.Rows[i - 1].Cells[j].Value.ToString();
                    }
                }
                try
                {
                    //Сохранение таблицы по пути sfd.FileName
                    Control.XLOutput(sfd.FileName, data, DGV_Table.Rows.Count + 1, DGV_Table.Columns.Count);
                }
                catch
                {
                    MessageBox.Show("При сохранении файла произошла ошибка!");
                }
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
