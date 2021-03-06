﻿using System;
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
    public partial class CurrentBooks : Form
    {
        public CurrentBooks(string FIO)
        {
            InitializeComponent();
            lb_Name.Text = FIO;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CurrentBooks_Load(object sender, EventArgs e)
        {
            if (!OutputBooks())
            {
                MessageBox.Show("У данного читателя нет взятых книг!");
            }
        }
        private bool OutputBooks()
        //Операция по выводу всех несданных книг для заданного читателя
        {            
            string sql = "select Publication_Code as 'ID', Name as 'Название книги', Author as 'Автор', Give_Date as 'Дата выдачи', Expected_Return_Date as 'Выдано до', Publication_ID from BookGiving, Publication where Publication_Code=Publication_ID and Real_Return_Date IS NULL and Librarian_Card_Code="+MainMenu.SelectedReader;
            DbDataReader reader = Control.ExecCommand(sql);
            if (reader.HasRows)
            //Если у читателя есть несданные книги
            {
                DGV_CurrentBooks.Rows.Clear();
                DGV_CurrentBooks.Columns.Clear();
                //Определение названий столбцов:
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    string str = reader.GetName(i);
                    DGV_CurrentBooks.Columns.Add(str, str);
                }
                //Publication_ID не будет виден пользователю:
                DGV_CurrentBooks.Columns[reader.FieldCount - 1].Visible = false;
                //Считывание первой строки:
                reader.Read();
                object[] temp = new object[reader.FieldCount];
                reader.GetValues(temp);
                //Преобразование дат:
                temp[3] = ((DateTime)(temp[3])).ToShortDateString();
                temp[4] = ((DateTime)(temp[4])).ToShortDateString();
                //Добавление первой строки
                DGV_CurrentBooks.Rows.Add(temp);
                //Считывание и добавление остальных строк:
                while (reader.Read())
                {
                    temp = new object[reader.FieldCount];
                    reader.GetValues(temp);
                    temp[3] = ((DateTime)(temp[3])).ToShortDateString();
                    temp[4] = ((DateTime)(temp[4])).ToShortDateString();
                    DGV_CurrentBooks.Rows.Add(temp);
                }
                reader.Close();
                btn_Recieve.Enabled = true;
                return true;
            }
            else
            //Если у читателя нет несданных книг
            {
                reader.Close();
                DGV_CurrentBooks.Rows.Clear();
                DGV_CurrentBooks.Columns.Clear();
                btn_Recieve.Enabled = false;
                return false;
            }
        }

        private void btn_Recieve_Click(object sender, EventArgs e)
        {
            //id - Publication_ID выбранной строки
            string id = DGV_CurrentBooks.CurrentRow.Cells[5].Value.ToString();
            GetBook GiveForm = new GetBook(id);
            GiveForm.ShowDialog();
            OutputBooks();
        }
    }
}
