using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Program
{
    public partial class QBE : Form
    {
        //Address - атрибуты сущности "Адрес"
        string[] Address = {"Address_ID","Region", "City", "Street", "House_Number","Flat_Number", "Deleted" };
        //Book - атрибуты сущности "Книга"
        string[] Book = {"Book_ID","ISBN", "Page_Quantity","Publication_Code","Deleted"};
        //BookGiving - атрибуты сущности "Выдача/принятие книги"
        string[] BookGiving = {"Operation_ID","LibrarianGiver_Staff_Code","Librarian_Card_Code",
            "Penalty_Code", "Publication_Code", "Give_Date","Expected_Return_Date",
            "Real_Return_Date","LibrarianReciever_Staff_Code","Deleted"};
        //Journal - атрибуты сущности "Серийное издание"
        string[] Journal = {"Journal_ID", "Release_Number", "ISSN", "Page_Quantity",
            "Publication_Code", "Deleted" };
        //Librarian - атрибуты сущности "Библиотекарь"
        string[] Librarian = {"Staff_Number", "Person_Code", "Hiring_Date", "Password", "Deleted", "Privilege" };
        //Penalty - атрибуты сущности "Штраф"
        string[] Penalty = {"Penalty_ID","Penalty_Info","Penalty_Sum", "Deleted" };
        //Person - атрибуты сущности "Человек"
        string[] Person = {"Person_ID", "FIO","Birthday","Phone_Number","Email","Address_Code","Deleted" };
        //Publication - атрибуты сущности "Издание"
        string[] Publication = {"Publication_ID", "Name", "BBK", "UDK", "Author", "Publisher_Code",
            "Deleted","Available" };
        //Publisher - атрибуты сущности "Издатель"
        string[] Publisher = {"Publisher_ID","Name","Year", "City", "Deleted" };
        //Reader - атрибуты сущности "Читатель"
        string[] Reader = {"Library_Card", "Person_Code", "Registration_Date","Deleted" };
        //Items - словарь, где Key="Название сущности", Value="Атрибуты сущности"
        Dictionary<string, string[]> Items;
        //ChosenAttributes - список выбранных пользователем атрибутов
        List<string> ChosenAttributes = new List<string>();
        //Correct - массив, отслеживающий корректность заполнения полей фильтра
        bool[] Correct = new bool[4];
        //sql - составляемый SQL-запрос
        string sql = "";
        //tables - строка, представляющая список выбранных сущностей
        string tables = "";
        //selects - строка, представляющая список выводимых пользователю названий столбцов
        string selects = "";
        //where - строка, представляющая фильтр (WHERE CLAUSE), налагаемый на SQL-запрос
        string where = "where";
        int count = 0;//кол-во полей where
        public QBE()
        {
            InitializeComponent();
        }

        private void CB_Entities_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Был изменен выбор сущности:
            if (CB_Entities.SelectedIndex != -1)
            {
                DGV_Attributes.Rows.Clear();
                DGV_Attributes.Columns.Clear();
                //Заполнение DGV атрибутами выбранной сущности:
                string chosen = CB_Entities.Text;
                DGV_Attributes.Columns.Add("Attribute", "Атрибут");
                for (int i = 0; i < Items[chosen].Count(); i++)
                {
                    DGV_Attributes.Rows.Add(Items[chosen].GetValue(i).ToString());
                }
                //Активация кнопок для добавления атрибута в список выбранных:
                btn_AddAll.Enabled = true;
                btn_AddOne.Enabled = true;
            }
        }

        private void QBE_Load(object sender, EventArgs e)
        {
            if (MainMenu.admin)
            //Если есть права администратора:
            {
                //Сущность библиотекарь содержит атрибут "Password"
                Librarian = new string[]{ "Staff_Number", "Person_Code", "Hiring_Date",
                    "Password", "Deleted", "Privilege" };
            }
            else
            //Если у текущего библиотекаря нет прав администратора
            {
                //Сущность библиотекарь не содержит атрибут "Password"
                Librarian = new string[] { "Staff_Number", "Person_Code", "Hiring_Date",
                    "Deleted", "Privilege" };
            }
            //Составление словаря Items:
            Items = new Dictionary<string, string[]>();
            Items.Add("Address", Address);
            Items.Add("Book", Book);
            Items.Add("BookGiving",BookGiving);
            Items.Add("Journal", Journal);
            Items.Add("Librarian", Librarian);
            Items.Add("Penalty", Penalty);
            Items.Add("Person", Person);
            Items.Add("Publication", Publication);
            Items.Add("Publisher", Publisher);
            Items.Add("Reader", Reader);
            //Кнопки добавления/удаления изначально отключены:
            btn_AddAll.Enabled = false;
            btn_AddOne.Enabled = false;
            btn_Remove.Enabled = false;
            btn_RemoveAll.Enabled = false;
            DGV_Chosen.Columns.Add("Attribute", "Атрибут");
            btn_Next.Enabled = false;
        }

        private void btn_AddOne_Click(object sender, EventArgs e)
        {
            //Добавление 1 атрибута:
            //Кнопки удаления атрибута становятся активными
            btn_Remove.Enabled = true;
            btn_RemoveAll.Enabled = true;
            string chosen = CB_Entities.Text.ToString()+"."+DGV_Attributes.CurrentCell.Value.ToString();
            if (!ChosenAttributes.Contains(chosen))
            //Если атрибут не был уже добавлен до этого:
            {
                //Добавление в список выбранных атрибутов:
                ChosenAttributes.Add(chosen);
                //Добавление в DGV выбранных атрибутов
                DGV_Chosen.Rows.Add(chosen);
                //Добавление в ComboBox для создания фильтров:
                CB_ChAt.Items.Add(chosen);
                CB_Value.Items.Add(chosen);
            }
        }

        private void btn_AddAll_Click(object sender, EventArgs e)
        {
            //Добавление всех атрибутов выбранной сущности
            //Кнопки удаления атрибута становятся активными
            btn_Remove.Enabled = true;
            btn_RemoveAll.Enabled = true;
            for (int i = 0; i < DGV_Attributes.Rows.Count; i++)
            {
                string chosen = CB_Entities.Text.ToString() + "." + DGV_Attributes.Rows[i].Cells[0].Value.ToString();
                if (!ChosenAttributes.Contains(chosen))
                //Если атрибут не был уже добавлен до этого:
                {
                    //Добавление в список выбранных атрибутов:
                    ChosenAttributes.Add(chosen);
                    //Добавление в DGV выбранных атрибутов
                    DGV_Chosen.Rows.Add(chosen);
                    //Добавление в ComboBox для создания фильтров:
                    CB_ChAt.Items.Add(chosen);
                    CB_Value.Items.Add(chosen);
                }
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            //Удаление выбранного атрибута из списка выбранных
            string value = DGV_Chosen.CurrentCell.Value.ToString();
            ChosenAttributes.Remove(value);
            //Удаление из ComboBox для создания фильтров:
            CB_ChAt.Items.Remove(value);
            CB_Value.Items.Remove(value);
            int ind = DGV_Chosen.CurrentCell.RowIndex;
            //Удаление из DGV выбранных атрибутов
            DGV_Chosen.Rows.RemoveAt(ind);
            if (ChosenAttributes.Count == 0)
            //Если не осталось ни одного выбранного атрибута:
            {
                //Кнопки удаления становятся неактивными
                btn_Remove.Enabled = false;
                btn_RemoveAll.Enabled = false;
            }
        }

        private void btn_RemoveAll_Click(object sender, EventArgs e)
        {
            //Удаление всех выбранных атрибутов
            RemoveAllChosen();
        }

        private void RemoveAllChosen()
        //Удаление всех выбранных атрибутов
        {
            for (int i = 0; i < DGV_Chosen.Rows.Count; i++)
            {
                string value = DGV_Chosen.Rows[i].Cells[0].Value.ToString();
                //Удаление текущего атрибута из списка выбранных
                ChosenAttributes.Remove(value);
                //Удаление из ComboBox для создания фильтров:
                CB_ChAt.Items.Remove(value);
                CB_Value.Items.Remove(value);
            }
            int size = DGV_Chosen.Rows.Count;
            //Удаление из DGV выбранных атрибутов
            for (int i = 0; i < size; i++)
            {
                DGV_Chosen.Rows.RemoveAt(0);
            }
            //Отключение кнопок для удаления атрибутов:
            if (ChosenAttributes.Count == 0)
            {
                btn_Remove.Enabled = false;
                btn_RemoveAll.Enabled = false;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CB_Conj_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Conj.SelectedIndex==0|| CB_Conj.SelectedIndex == 1)
            {
                Correct[3] = true;
            }
            else
            {
                Correct[3] = false;
            }
            btn_Next.Enabled= Control.CheckCorrect(Correct);
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            //Создание части WHERE CLAUSE (одно условие)
            where += " " + CB_ChAt.Text + CB_Sign.Text + CB_Value.Text + " " + CB_Conj.Text;
            CB_ChAt.SelectedIndex = -1;
            CB_Sign.SelectedIndex = -1;
            CB_Value.SelectedIndex = -1;
            CB_Conj.SelectedIndex = -1;
            CB_Value.Text = "";
            count++;
        }

        private void CB_ChAt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_ChAt.SelectedIndex != -1)
            {
                Correct[0] = true;
            }
            else
            {
                Correct[0] = false;
            }
            btn_Next.Enabled = Control.CheckCorrect(Correct);
        }

        private void CB_Sign_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Sign.SelectedIndex != -1)
            {
                Correct[1] = true;
            }
            else
            {
                Correct[1] = false;
            }
            btn_Next.Enabled = Control.CheckCorrect(Correct);
        }

        private void CB_Value_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }
        private void RefreshForm()
        //Обновление полей фильтров и очищение sql, where, tables, selects
        {
            CB_ChAt.SelectedIndex = -1;
            CB_Sign.SelectedIndex = -1;
            CB_Value.SelectedIndex = -1;
            CB_Conj.SelectedIndex = -1;
            CB_Value.Text = "";
            sql = "";
            tables = "";
            selects = "";
            where = "where";
        }
        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (DGV_Chosen.Rows.Count > 0)
            {
                //Составление списка выводимых столбцов:
                selects = "select distinct top (10000) ";
                //table - список используемых сущностей
                List<string> table = new List<string>();
                //Составление списка используемых сущностей:
                for (int i = 0; i < DGV_Chosen.Rows.Count; i++)
                {
                    string p = DGV_Chosen.Rows[i].Cells[0].Value.ToString();
                    selects += DGV_Chosen.Rows[i].Cells[0].Value.ToString() + ", ";
                    string t = p.Substring(0, p.IndexOf('.'));
                    if (!table.Contains(t))
                    {
                        table.Add(t);
                    }
                }
                tables = "";
                //Составление строки, содержащей названия сущностей (FROM CLAUSE)
                tables += "from " + table[0];
                for (int i = 1; i < table.Count; i++)
                {
                    tables += ", " + table[i];
                }
                tables += " ";
                selects = selects.Remove(selects.Length - 2,1);//Удаление последней запятой
                //sql - соединение selects и tables
                sql = selects + tables;
                //Если последний фильтр был корректно заполнен:
                if (CB_ChAt.Text.Length > 0 && CB_Sign.Text.Length > 0 && CB_Value.Text.Length > 0 
                    && CB_Conj.SelectedIndex == 2)
                {
                    where +=" "+CB_ChAt.Text + CB_Sign.Text + CB_Value.Text;
                }
                else
                {
                    if (count == 0 && CB_ChAt.Text.Length == 0 && CB_Sign.Text.Length == 0 
                        && CB_Value.Text.Length == 0 && CB_Conj.SelectedIndex == -1)
                    {
                        where = "";
                        sql.Remove(sql.Length - 1);
                    }
                    else
                    {
                        MessageBox.Show("Последний фильтр был заполнен некорректно!");
                        return;
                    }
                }
                //Добавление поля where
                sql += where;             
                //Вывод результатов sql-запроса в окно QBE_Table
                QBE_Table Ftable = new QBE_Table(sql);
                Ftable.ShowDialog();
                selects = "";
                RefreshForm();
                MessageBox.Show("Все фильтры были обнулены!");
            }
            else
            {
                MessageBox.Show("Не было выбрано ни 1 столбца для вывода!");
            }
        }

        private void CB_Value_TextChanged(object sender, EventArgs e)
        {
            if (CB_Value.SelectedIndex != -1)
            {
                Correct[2] = true;
            }
            else
            {
                if (CB_Value.Text.Length > 0)
                {
                    Correct[2] = true;
                }
                else
                {
                    Correct[2] = false;
                }
            }
            btn_Next.Enabled = Control.CheckCorrect(Correct);
        }
    }
}
