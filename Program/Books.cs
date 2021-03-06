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
    public partial class Books : Form
    {
        //ChosenColumns - список выбранных столбцов (true - столбец выбран, false - не выбран)
        bool[] ChosenColumns = new bool[7];
        //ChosenFilters - список выбранных фильтров (true - фильтр выбран, false - не выбран)
        bool[] ChosenFilters = new bool[7];
        //LastQuery - Последний использованный фильтр
        string LastQuery = "";
        //Cols - список названий атрибутов сущностей для выводимых столбцов
        string[] Cols = { "Publication_ID", "Publication.Name", "Author", "Year", "BBK", "Available", "Publisher.Name" };
        //ColsForUser - список алиасов (названий, выводимых пользователю) для выводимых столбцов
        string[] ColsForUser = { @"'№'", "'Название'", "'Автор'", "'Год'", "'ББК'", "'Наличие'", "'Издательство'" };
        //SelectedBook - Publication_ID выбранного издания
        public static string SelectedBook = "1";
        public Books()
        {
            InitializeComponent();
        }

        private void btn_Info_Click(object sender, EventArgs e)
        {
            BookInfo formBookInfo = new BookInfo();
            formBookInfo.ShowDialog();
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            AddBook formBookChange = new AddBook(true);
            formBookChange.ShowDialog();
            OutputBooks(LastQuery);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddBook formBookAdd = new AddBook();
            formBookAdd.ShowDialog();
            OutputBooks(LastQuery);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        //Удаление издания
        {
            DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить данную книгу?", "Удаление", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //Получение ID Издательства:
                string CheckingExistSQL = "select Publisher_Code from Publisher, Publication where Publication.Deleted=0 and Publisher_Code=Publisher_ID and Publication_ID=" + SelectedBook;
                DbDataReader reader = Control.ExecCommand(CheckingExistSQL);
                if (reader.HasRows)
                {
                    reader.Read();
                    string Publisher_Code = reader[0].ToString();
                    reader.Close();
                    string SQLUpd1 = "update Publisher set Deleted=1 where Publisher_ID="+Publisher_Code;
                    string SQLUpd2 = "update Publication set Deleted=1 where Publication_ID="+SelectedBook;
                    string SQLCheck = "select * from Book where Publication_Code="+SelectedBook;
                    //Удаление издателя
                    reader = Control.ExecCommand(SQLUpd1);
                    reader.Close();
                    //Удаление издания
                    reader = Control.ExecCommand(SQLUpd2);
                    reader.Close();
                    //Проверка, что в Book есть книга с Publication_Code
                    reader = Control.ExecCommand(SQLCheck);
                    bool IsBook = reader.HasRows;
                    reader.Close();
                    if (IsBook)//Если удаляется книга
                    {
                        //Удаление книги
                        string SQLUpd3 = "update Book set Deleted=1 where Publication_Code="+SelectedBook;
                        reader = Control.ExecCommand(SQLUpd3);
                        reader.Close();
                    }
                    else//Если удаляется периодическое издание
                    {
                        //Удаление периодического издания
                        string SQLUpd3 = "update Journal set Deleted=1 where Publication_Code=" + SelectedBook;
                        reader = Control.ExecCommand(SQLUpd3);
                        reader.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Данная книга уже была удалена. Обновите список книг!");
                }
                reader.Close();
                OutputBooks(LastQuery);
            }
        }

        private void btn_ApplyFilter_Click(object sender, EventArgs e)
        {
            //Создание WHERE CLAUSE:
            string[] values = new string[7];
            values[0] = TB_Id.Text;
            values[1] = TB_Name.Text;
            values[2] = TB_Author.Text;
            values[3] = TB_Year.Text;
            values[4] = TB_BBK.Text;
            values[5] = CB_Availability.SelectedIndex.ToString();
            values[6] = TB_Producer.Text;
            string FilterCode = "";
            for (int i = 0; i < values.Length; i++)
            {
                if (ChosenFilters[i])
                {
                    //Если использован фильтр Название, Автор, Издательство, 
                    //то проверяется не точное, а частичное совпадение
                    if (i == 1 || i == 2 || i == 6)
                    {
                        FilterCode += " and " + Cols[i] + " like '%" + values[i] + "%'";
                    }
                    else
                    //Проверка на точное совпадение заданному значению
                    {
                        FilterCode += " and " + Cols[i] + "= '" + values[i] + "'";
                    }
                }
            }
            LastQuery = FilterCode;
            OutputBooks(FilterCode);
        }

        private void CB_Filter_ID_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Filter_ID.Checked)
            {
                ChosenFilters[0] = true;
            }
            else
            {
                ChosenFilters[0] = false;
            }
        }

        private void CB_Filter_Name_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Filter_Name.Checked)
            {
                ChosenFilters[1] = true;
            }
            else
            {
                ChosenFilters[1] = false;
            }
        }

        private void CB_Filter_Author_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Filter_Author.Checked)
            {
                ChosenFilters[2] = true;
            }
            else
            {
                ChosenFilters[2] = false;
            }
        }

        private void CB_Filter_Year_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Filter_Year.Checked)
            {
                ChosenFilters[3] = true;
            }
            else
            {
                ChosenFilters[3] = false;
            }
        }

        private void CB_Filter_BBK_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Filter_BBK.Checked)
            {
                ChosenFilters[4] = true;
            }
            else
            {
                ChosenFilters[4] = false;
            }
        }

        private void CB_Filter_Avail_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Filter_Avail.Checked)
            {
                ChosenFilters[5] = true;
            }
            else
            {
                ChosenFilters[5] = false;
            }
        }

        private void CB_Filter_Producer_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Filter_Producer.Checked)
            {
                ChosenFilters[6] = true;
            }
            else
            {
                ChosenFilters[6] = false;
            }
        }

        private void Books_Load(object sender, EventArgs e)
        {
            ChosenColumns[0] = true;
            ChosenColumns[1] = true;
            ChosenColumns[2] = true;
            ChosenColumns[4] = true;
            ChosenColumns[5] = true;
            LastQuery = "";
            //Изначальный вывод книг при загрузке формы:
            OutputBooks(LastQuery);
        }
        public void OutputBooks(string filter)
        //Вывод книг по заданному фильтру filter (WHERE CLAUSE) и выбранным столбцам
        {
            //existance - присутствие атрибута "Наличие" у издания
            bool existance = false;
            int index = 0;
            //indexofex - Номер столбца с наличием книги
            int indexofex = -1;
            //Columns - строка для выводимых пользователю столбцов
            string Columns = "";
            //AtLeastOne - выводится хотя бы 1 столбец
            bool AtLeastOne = false;
            //Составление строки с выводимыми столбцами (с алиасами):
            for (int i = 0; i < ChosenColumns.Length; i++)
            {
                if (ChosenColumns[i])
                {
                    if (i == 5)
                    {
                        existance = true;
                        indexofex = index;
                    }                    
                    if (!AtLeastOne)
                    //Первый выводимый столбец:
                    {
                        Columns += Cols[i] + " as " + ColsForUser[i];
                        AtLeastOne = true;
                    }
                    else
                    //Начиная со второго столбца:
                    {
                        Columns += ", " + Cols[i] + " as " + ColsForUser[i];
                    }
                    index++;
                }
            }
            if (Columns != "")
            //Если список выводимых столбцов не пуст:
            {
                //Составление итогового запроса:
                //Publication_ID используется для однозначного определения выбранного пользователем издания
                string Books = "select Publication_ID, "+Columns+" " +
                    "from Publication, Publisher " +
                    "where Publisher_Code=Publisher_ID and Publication.Deleted=0 "+filter;
                SqlCommand cmd = new SqlCommand(Books, Authorization.conn);
                DbDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                //Если по заданному запросу найдено хотя бы 1 издание
                {
                    DGV_Books.Rows.Clear();
                    DGV_Books.Columns.Clear();
                    //Столбец ID - будет невидимым для пользователя
                    DGV_Books.Columns.Add("ID", "ID");
                    DGV_Books.Columns[0].Visible = false;
                    //Определение названий столбцов для DataGridView:
                    for (int i = 1; i < reader.FieldCount; i++)
                    {
                        string str = reader.GetName(i);
                        DGV_Books.Columns.Add(str, str);
                    }
                    //Считывание первой строки:
                    reader.Read();
                    object[] temp = new object[reader.FieldCount];
                    reader.GetValues(temp);                    
                    if (existance)
                    //Преобразование значения столбца "Наличия" в приемлимый для пользователя вид
                    {
                        string t = temp[indexofex + 1].ToString();
                        if (t == "false"||t=="False")
                        {
                            temp[indexofex + 1] = "Нет";
                        }
                        else
                        {
                            temp[indexofex + 1] = "Есть";
                        }
                    }
                    //Добавление строки
                    DGV_Books.Rows.Add(temp);
                    //Считывание остальных строк:
                    while (reader.Read())
                    {
                        reader.GetValues(temp);
                        if (existance)
                        {
                            string t = temp[indexofex + 1].ToString();
                            if (t == "false" || t == "False")
                            {
                                temp[indexofex+1] = "Нет";
                            }
                            else
                            {
                                temp[indexofex+1] = "Есть";
                            }
                        }
                        DGV_Books.Rows.Add(temp);
                    }
                }
                else
                //Если по заданному запросу не было найдено ни 1 книги:
                {
                    MessageBox.Show("По заданным фильтрам ничего не найдено!");
                    DGV_Books.Rows.Clear();
                    DGV_Books.Columns.Clear();
                }
                reader.Close();
            }
            else
            //Если список выводимых столбцов пуст
            {
                DGV_Books.Rows.Clear();
                DGV_Books.Columns.Clear();
                MessageBox.Show("По данным параметрам не было найдено книги");
            }
            if (DGV_Books.Rows.Count > 0)
            {
                btn_Change.Enabled = true;
                btn_Delete.Enabled = true;
                btn_Info.Enabled = true;
            }
            else
            {
                btn_Change.Enabled = false;
                btn_Delete.Enabled = false;
                btn_Info.Enabled = false;
            }
        }

        private void CB_Id_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Id.Checked)
            {
                ChosenColumns[0] = true;
            }
            else
            {
                ChosenColumns[0] = false;
            }
        }

        private void CB_Name_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Name.Checked)
            {
                ChosenColumns[1] = true;
            }
            else
            {
                ChosenColumns[1] = false;
            }
        }

        private void CB_Author_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Author.Checked)
            {
                ChosenColumns[2] = true;
            }
            else
            {
                ChosenColumns[2] = false;
            }
        }

        private void CB_Year_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Year.Checked)
            {
                ChosenColumns[3] = true;
            }
            else
            {
                ChosenColumns[3] = false;
            }
        }

        private void CB_BBK_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_BBK.Checked)
            {
                ChosenColumns[4] = true;
            }
            else
            {
                ChosenColumns[4] = false;
            }
        }

        private void CB_Avail_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Avail.Checked)
            {
                ChosenColumns[5] = true;
            }
            else
            {
                ChosenColumns[5] = false;
            }
        }

        private void CB_Producer_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Producer.Checked)
            {
                ChosenColumns[6] = true;
            }
            else
            {
                ChosenColumns[6] = false;
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            OutputBooks(LastQuery);
        }

        private void btn_FilterReset_Click(object sender, EventArgs e)
        {
            //Сброс всех фильтров на изначальные значения:
            LastQuery = "";            
            CB_Id.Checked = true;
            CB_Name.Checked = true;
            CB_Author.Checked = true;
            CB_Year.Checked = false;
            CB_BBK.Checked = true;
            CB_Avail.Checked = true;
            CB_Producer.Checked = false;
            CB_Filter_ID.Checked = false;
            CB_Filter_Name.Checked = false;
            CB_Filter_Author.Checked = false;
            CB_Filter_Year.Checked = false;
            CB_Filter_BBK.Checked = false;
            CB_Filter_Avail.Checked = false;
            CB_Filter_Producer.Checked = false;
            CB_Availability.SelectedIndex = -1;
            TB_Id.Text = "";
            TB_Name.Text = "";
            TB_Author.Text = "";
            TB_Year.Text = "";
            TB_BBK.Text = "";
            TB_Producer.Text = "";
            OutputBooks(LastQuery);
        }

        private void DGV_Books_SelectionChanged(object sender, EventArgs e)
        {
            if (DGV_Books.Rows.Count > 0)
                SelectedBook = DGV_Books.CurrentRow.Cells[0].Value.ToString();
        }

        private void btn_Import_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "XLSX files (*.xlsx)| *.xlsx";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                string way = opf.FileName;
                try
                {
                    //Control.XLInput - операция по импорту книг из файла с расширением .xlsx
                    //t - количество добавленных книг
                    int t = Control.XLInput(way);
                    if (t > 0)
                    //Если была добавлена хоть 1 книга:
                    {
                        MessageBox.Show("Было успешно добавлено " + t + " книг!");
                        OutputBooks(LastQuery);
                    }
                    else MessageBox.Show("Из данного файла не удалось считать ни одной книги!");
                }
                catch
                {
                    MessageBox.Show("Файл не удалось обработать!");
                }
            }
        }

        private void TB_Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)8)) return;
            else
                e.Handled = true;
        }
    }
}
