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
    public partial class Journal : Form
    {
        //ChosenColumns - список выбранных столбцов (true - столбец выбран, false - не выбран)
        bool[] ChosenColumns = new bool[10];
        //ChosenFilters - список выбранных фильтров (true - фильтр выбран, false - не выбран)
        bool[] ChosenFilters = new bool[8];
        //Cols - список названий атрибутов сущностей для выводимых столбцов
        string[] Cols = { "Operation_ID","Publication_Code", "Librarian_Card_Code", "LibrarianGiver_Staff_Code", "LibrarianReciever_Staff_Code", "Give_Date","Expected_Return_Date","Real_Return_Date","Penalty_Sum","Penalty_Info" };
        //ColsForUser - список алиасов (названий, выводимых пользователю) для выводимых столбцов
        string[] ColsForUser = { @"'Код операции'", "'ID книги'", "'№ Читательского билета'", "'Шт. номер выдавшего'", "'Шт. номер принявшего'", "'Дата выдачи'", "'Ожидаемая дата сдачи'", "'Реальная дата сдачи'", "'Сумма штрафа'", "'Информация о штрафе'" };
        //LastQuery - Последний использованный фильтр
        string LastQuery;
        public Journal()
        {
            InitializeComponent();
        }

        private void Journal_Load(object sender, EventArgs e)
        {
            CheckForColumns();
            OutputJ("");
        }

        private void CheckForColumns()
        {
            ChosenColumns[0] = CB_OperationID.Checked;
            ChosenColumns[1] = CB_BookID.Checked;
            ChosenColumns[2] = CB_ReaderTicket.Checked;
            ChosenColumns[3] = CB_GiverStaffNumber.Checked;
            ChosenColumns[4] = CB_RecieverStaffNumber.Checked;
            ChosenColumns[5] = CB_GiveDate.Checked;
            ChosenColumns[6] = CB_ExpectedReturnDate.Checked;
            ChosenColumns[7] = CB_RealReturnDate.Checked;
            ChosenColumns[8] = CB_PenaltySum.Checked;
            ChosenColumns[9] = CB_PenaltyInfo.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CB_OperationID_CheckedChanged(object sender, EventArgs e)
        {
            ChosenColumns[0] = CB_OperationID.Checked;
        }

        private void CB_BookID_CheckedChanged(object sender, EventArgs e)
        {
            ChosenColumns[1] = CB_BookID.Checked;
        }

        private void CB_ReaderTicket_CheckedChanged(object sender, EventArgs e)
        {
            ChosenColumns[2] = CB_ReaderTicket.Checked;
        }

        private void CB_GiverStaffNumber_CheckedChanged(object sender, EventArgs e)
        {
            ChosenColumns[3] = CB_GiverStaffNumber.Checked;
        }

        private void CB_RecieverStaffNumber_CheckedChanged(object sender, EventArgs e)
        {
            ChosenColumns[4] = CB_RecieverStaffNumber.Checked;
        }

        private void CB_GiveDate_CheckedChanged(object sender, EventArgs e)
        {
            ChosenColumns[5] = CB_GiveDate.Checked;
        }

        private void CB_ExpectedReturnDate_CheckedChanged(object sender, EventArgs e)
        {
            ChosenColumns[6] = CB_ExpectedReturnDate.Checked;
        }

        private void CB_RealReturnDate_CheckedChanged(object sender, EventArgs e)
        {
            ChosenColumns[7] = CB_RealReturnDate.Checked;
        }

        private void CB_PenaltySum_CheckedChanged(object sender, EventArgs e)
        {
            ChosenColumns[8] = CB_PenaltySum.Checked;
        }

        private void CB_PenaltyInfo_CheckedChanged(object sender, EventArgs e)
        {
            ChosenColumns[9] = CB_PenaltyInfo.Checked;
        }

        private void CB_Filter_OperationID_CheckedChanged(object sender, EventArgs e)
        {
            ChosenFilters[0] = CB_Filter_OperationID.Checked;
        }

        private void CB_Filter_PubID_CheckedChanged(object sender, EventArgs e)
        {
            ChosenFilters[1] = CB_Filter_PubID.Checked;
        }

        private void CB_Filter_Reader_Ticket_CheckedChanged(object sender, EventArgs e)
        {
            ChosenFilters[2] = CB_Filter_Reader_Ticket.Checked;
        }

        private void CB_Filter_Giver_CheckedChanged(object sender, EventArgs e)
        {
            ChosenFilters[3] = CB_Filter_Giver.Checked;
        }

        private void CB_Filter_Getter_CheckedChanged(object sender, EventArgs e)
        {
            ChosenFilters[4] = CB_Filter_Getter.Checked;
        }

        private void CB_Filter_Give_Date_CheckedChanged(object sender, EventArgs e)
        {
            ChosenFilters[5] = CB_Filter_Give_Date.Checked;
        }

        private void CB_Filter_Expected_Date_CheckedChanged(object sender, EventArgs e)
        {
            ChosenFilters[6] = CB_Filter_Expected_Date.Checked;
        }

        private void CB_Filter_Real_Date_CheckedChanged(object sender, EventArgs e)
        {
            ChosenFilters[7] = CB_Filter_Real_Date.Checked;
        }

        private void btn_ApplyFilters_Click(object sender, EventArgs e)
        {
            //Создание фильтра (WHERE CLAUSE):
            string[] values = new string[8];
            string d0 = "";
            string d1 = "";
            string d2 = "";
            values[0] = TB_OperationID.Text;
            values[1] = TB_BookID.Text;
            values[2] = TB_ReaderTicket.Text;
            values[3] = TB_GiverStaffNumber.Text;
            values[4] = TB_RecieverStaffNumber.Text;
            if (DTP_GiveDate.Value != null)
            {
                DateTime date = DTP_GiveDate.Value;
                d0 = date.Year + "-" + date.Month + "-" + date.Day;
            }
            values[5] = d0;
            if (DTP_Expected_Date.Value != null)
            {
                DateTime date = DTP_Expected_Date.Value;
                d1 = date.Year + "-" + date.Month + "-" + date.Day;
            }
            values[6] = d1;
            if (DTP_Real_Date.Value != null)
            {
                DateTime date = DTP_Real_Date.Value;
                d2 = date.Year + "-" + date.Month + "-" + date.Day;
            }
            values[7] = d2;
            string FilterCode = "";
            for (int i = 0; i < values.Length; i++)
            {
                if (ChosenFilters[i])
                    FilterCode += " and " + Cols[i] + "= '" + values[i] + "'";
            }
            LastQuery = FilterCode;
            //Вывод таблицы с заданным фильтром и выбранными столбцами для вывода
            OutputJ(LastQuery);
        }
        private void OutputJ(string filter)
        //Вывод в DataGridView полученной таблицы с заданным фильтром и выбранными столбцами для вывода
        {
            //Columns - строка для выводимых пользователю столбцов
            string Columns = "";
            //AtLeastOne - выводится хотя бы 1 столбец
            bool AtLeastOne = false;
            //Составление строки с выводимыми столбцами (с алиасами):
            for (int i = 0; i < ChosenColumns.Length; i++)
            {
                if (ChosenColumns[i])
                {
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
                }
            }
            if (Columns != "")
            //Если список выводимых столбцов не пуст:
            {
                //Составление итогового запроса:
                string sql = "select " + Columns + " from BookGiving, Penalty where BookGiving.Deleted=0 and Penalty_Code=Penalty_ID" + filter;
                DbDataReader reader = Control.ExecCommand(sql);
                if (reader.HasRows)
                //Если по заданному запросу найдена хотя бы 1 строка журнала
                {
                    DGV_Journal.Rows.Clear();
                    DGV_Journal.Columns.Clear();
                    //Определение названий столбцов для DataGridView:
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        string str = reader.GetName(i);
                        DGV_Journal.Columns.Add(str, str);
                    }
                    //Считывание первой строки:
                    reader.Read();
                    object[] temp = new object[reader.FieldCount];
                    reader.GetValues(temp);
                    for (int i = 0; i < reader.FieldCount; i++)//Удаление ЧЧ:ММ из выводимых дат
                    {
                        if (temp[i] is DateTime)
                        {
                            temp[i] = ((DateTime)temp[i]).ToShortDateString();
                        }
                    }
                    //Добавление 1 строки
                    DGV_Journal.Rows.Add(temp);
                    //Считывание и добавление остальных строк
                    while (reader.Read())
                    {
                        temp = new object[reader.FieldCount];
                        reader.GetValues(temp);
                        for (int i = 0; i < reader.FieldCount; i++)//Удаление ЧЧ:ММ из выводимых дат
                        {
                            if (temp[i] is DateTime)
                            {
                                temp[i] = ((DateTime)temp[i]).ToShortDateString();
                            }
                        }
                        DGV_Journal.Rows.Add(temp);
                    }
                    reader.Close();
                }
                else
                //Вывод MessageBox с сообщением о пустом содержимом?
                {
                    MessageBox.Show("Не было найдено ни одной записи журнала!");
                    DGV_Journal.Rows.Clear();
                    DGV_Journal.Columns.Clear();
                    reader.Close();
                }
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_CancelFilters_Click(object sender, EventArgs e)
        {
            CB_OperationID.Checked = true;
            CB_BookID.Checked = true;
            CB_ReaderTicket.Checked = true;
            CB_GiverStaffNumber.Checked = false;
            CB_RecieverStaffNumber.Checked = false;
            CB_GiveDate.Checked = false;
            CB_ExpectedReturnDate.Checked = false;
            CB_RealReturnDate.Checked = true;
            CB_PenaltySum.Checked = true;
            CB_PenaltyInfo.Checked = true;
            CB_Filter_OperationID.Checked = false;
            CB_Filter_PubID.Checked = false;
            CB_Filter_Reader_Ticket.Checked = false;
            CB_Filter_Giver.Checked = false;
            CB_Filter_Getter.Checked = false;
            CB_Filter_Give_Date.Checked = false;
            CB_Filter_Expected_Date.Checked = false;
            CB_Filter_Real_Date.Checked = false;
            TB_OperationID.Text = "";
            TB_BookID.Text = "";
            TB_ReaderTicket.Text = "";
            TB_GiverStaffNumber.Text = "";
            TB_RecieverStaffNumber.Text = "";
            DTP_GiveDate.Value = DateTime.Today;
            DTP_Expected_Date.Value = DateTime.Today;
            DTP_Real_Date.Value = DateTime.Today;
            OutputJ("");
        }
    }
}
