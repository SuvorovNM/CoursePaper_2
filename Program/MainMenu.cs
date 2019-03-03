using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Data.Common;

namespace Program
{
    public partial class MainMenu : Form
    {
        public static Librarian CurrentLibrarian;
        static string patEmail = @"^(?(')('.+?(?<!\\)'@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
        Regex rgEmail = new Regex(patEmail);
        public static Authorization enter;
        public static string SelectedReader = "1";
        bool[] ChosenColumns = new bool[5];
        bool[] ChosenFilters = new bool[5];
        string LastQuery = "";
        //string[] Filters = { };
        //enum Cols { Library_Card, FIO, Birthday, Phone_Number, Email };
        string[] Cols = { "Library_Card", "FIO", "Birthday", "Phone_Number", "Email" };
        string[] ColsForUser = { @"'№'", "'ФИО'", "'Дата рождения'", "'Номер телефона'", "'Email'" };
        public MainMenu()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            enter.Close();
        }

        private void TSM_Books_OpenBase_Click(object sender, EventArgs e)
        {
            Books formBooks = new Books();
            formBooks.ShowDialog();
        }

        private void TSM_Librarian_Change_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //enter = new Authorization();
            enter.Show();
            this.Hide();
        }

        private void TSM_Librarian_Profile_Click(object sender, EventArgs e)
        {
            Librarian_Account formAccount = new Librarian_Account();
            formAccount.ShowDialog();
        }

        private void TSM_Librarian_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TSM_Readers_CurrentPenalty_Click(object sender, EventArgs e)
        {
            Penalty formPenalties = new Penalty();
            formPenalties.ShowDialog();
        }

        private void TSM_Readers_CurrentBooks_Click(object sender, EventArgs e)
        {
            CurrentBooks formBooks = new CurrentBooks();
            formBooks.ShowDialog();
        }

        private void TSM_Books_Give_Click(object sender, EventArgs e)
        {
            GiveBook formGive = new GiveBook();
            formGive.ShowDialog();
        }

        private void TSM_books_get_Click(object sender, EventArgs e)
        {
            GetBook formGet = new GetBook();
            formGet.ShowDialog();
        }

        private void TSM_Books_Journal_Click(object sender, EventArgs e)
        {
            Journal formJournal = new Journal();
            formJournal.ShowDialog();
        }

        private void btn_Info_Click(object sender, EventArgs e)
        {
            ReaderInfo formReader = new ReaderInfo();
            formReader.ShowDialog();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //Открытие пустого окна
            AddReader formChangeReader = new AddReader();
            formChangeReader.ShowDialog();
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            //Открытие окна с внесенными данными            
            string CheckForExistance = "select Person_ID, Address_ID from Reader, Person, Address where Reader.Deleted=0 and Person_Code=Person_ID and Address_Code=Address_ID and Library_Card=" + SelectedReader;
            SqlCommand command = new SqlCommand(CheckForExistance, Authorization.conn);
            DbDataReader reader = command.ExecuteReader();
            bool Exist = reader.HasRows;
            reader.Close();
            if (Exist)
            {
                AddReader formChangeReader = new AddReader(true);
                formChangeReader.ShowDialog();
            }
            else
            {
                MessageBox.Show("Данный читатель уже был удален из базы. Обновите список читателей!");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //MessageBox -Удалить? -(Да/Нет)
            DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить данного читателя?", "Удаление", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string CheckForExistance = "select Person_ID, Address_ID from Reader, Person, Address where Reader.Deleted=0 and Person_Code=Person_ID and Address_Code=Address_ID and Library_Card=" + SelectedReader;
                SqlCommand command = new SqlCommand(CheckForExistance, Authorization.conn);
                DbDataReader reader = command.ExecuteReader();
                bool Exist = reader.HasRows;
                if (Exist)
                {
                    reader.Read();
                    string Person_ID = reader[0].ToString();
                    string Address_ID = reader[1].ToString();
                    reader.Close();
                    string UpdatingDelete = "update Reader set Deleted=1 where Library_Card='" + SelectedReader + "'";
                    command = new SqlCommand(UpdatingDelete, Authorization.conn);
                    reader = command.ExecuteReader();
                    reader.Close();
                    UpdatingDelete = "update Person set Deleted=1 where Person_ID='" + SelectedReader + "'";
                    command = new SqlCommand(UpdatingDelete, Authorization.conn);
                    reader = command.ExecuteReader();
                    reader.Close();
                    UpdatingDelete = "update Address set Deleted=1 where Address_ID='" + SelectedReader + "'";
                    command = new SqlCommand(UpdatingDelete, Authorization.conn);
                    reader = command.ExecuteReader();
                    reader.Close();
                    MessageBox.Show("Удаление произведено успешно!");
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("Данный читатель уже был удален! Обновите список читателей");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void TB_LibraryCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)8)) return;
            else
                e.Handled = true;
        }

        private void TB_FIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || (e.KeyChar == ' ') || (e.KeyChar == (char)8)) return;
            else
                e.Handled = true;

        }

        private void btn_ApplyFilter_Click(object sender, EventArgs e)//Применить фильтр
        {
            string[] values = new string[5];
            values[0] = TB_LibraryCard.Text;
            values[1] = TB_FIO.Text;
            string ind = (CB_Month.SelectedIndex + 1).ToString();
            //ind++;
            if (ind.Length == 1)
            {
                ind = "0" + ind;
            }
            string day = TB_Day.Text;
            if (day.Length == 1)
            {
                day = "0" + day;
            }
            values[2] = TB_Year.Text + "-" + ind + "-" + day;//
            values[3] = TB_PhoneNumber.Text;
            values[4] = TB_Email.Text;
            string FilterCode = "";
            for (int i = 0; i < values.Length; i++)
            {
                if (ChosenFilters[i])
                    if (i == 1)
                    {
                        FilterCode += " and " + Cols[i] + " like '%" + values[i] + "%'";
                    }
                    else
                    {
                        FilterCode += " and " + Cols[i] + "= '" + values[i] + "'";
                    }
            }
            LastQuery = FilterCode;
            OutputReaders(FilterCode);

        }

        private void TB_Email_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TB_Email_KeyUp(object sender, KeyEventArgs e)
        {
            if (TB_Email.Text != null && TB_Email.Text != "")
                if (rgEmail.IsMatch(TB_Email.Text))
                {
                    TB_Email.BackColor = Color.White;
                }
                else
                {
                    TB_Email.BackColor = Color.LightPink;
                }
            else
            {
                TB_Email.BackColor = Color.White;
            }
        }

        private void TB_Day_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)8)) return;
            else
                e.Handled = true;
        }

        private void TB_Year_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)8)) return;
            else
                e.Handled = true;
        }

        private void TB_Day_KeyUp(object sender, KeyEventArgs e)
        {
            int day;
            Int32.TryParse(TB_Day.Text, out day);
            if (day > 31 || day < 1)
            {
                if (TB_Day.Text != "" && TB_Day.Text != null)
                    TB_Day.BackColor = Color.LightPink;
            }
            else
            {
                TB_Day.BackColor = Color.White;
            }
        }

        private void TB_Year_KeyUp(object sender, KeyEventArgs e)
        {
            int year;
            Int32.TryParse(TB_Year.Text, out year);
            if (year > DateTime.Today.Year || year < 1900)
            {
                if (TB_Year.Text != "" && TB_Year.Text != null)
                    TB_Year.BackColor = Color.LightPink;
            }
            else
            {
                TB_Year.BackColor = Color.White;
            }
        }

        private void TB_PhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)8)) return;
            else
                e.Handled = true;
        }

        private void CB_ReaderTicket_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_ReaderTicket.Checked)
            {
                ChosenColumns[0] = true;
            }
            else
            {
                ChosenColumns[0] = false;
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            ChosenColumns[0] = true;
            ChosenColumns[1] = true;
            ChosenColumns[2] = true;
            LastQuery = "";
            OutputReaders("");
        }

        public void OutputReaders(string filter)
        {
            string Columns = "";
            bool AtLeastOne = false;//->false
            for (int i = 0; i < ChosenColumns.Length; i++)
            {
                if (ChosenColumns[i])
                {
                    if (!AtLeastOne)
                    {
                        Columns += Cols[i] + " as " + ColsForUser[i];
                        AtLeastOne = true;
                    }
                    else
                    {
                        Columns += ", " + Cols[i] + " as " + ColsForUser[i];
                    }
                }
            }
            if (Columns != "")
            {
                //"select "
                //Первый и невидимый столец - ID читателя
                string Readers = "select Library_Card, " + Columns + " from Reader, Person, Address where Reader.Person_Code=Person.Person_ID and Person.Address_Code=Address.Address_ID and Reader.Deleted=0" + filter;
                SqlCommand cmd = new SqlCommand(Readers, Authorization.conn);
                DbDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    DGV_Readers.Rows.Clear();
                    DGV_Readers.Columns.Clear();
                    //DGV_Readers.Columns.
                    DGV_Readers.Columns.Add("ID", "ID");
                    DGV_Readers.Columns[0].Visible = false;
                    for (int i = 1; i < reader.FieldCount; i++)
                    {
                        string str = reader.GetName(i);
                        DGV_Readers.Columns.Add(str, str);
                    }
                    reader.Read();
                    object[] temp = new object[reader.FieldCount];
                    reader.GetValues(temp);
                    for (int i = 0; i < reader.FieldCount; i++)//Удаление ЧЧ:ММ из Birthday
                    {
                        if (temp[i] is DateTime)
                        {
                            temp[i] = temp[i].ToString().Substring(0, temp[i].ToString().IndexOf(' '));
                        }
                    }
                    DGV_Readers.Rows.Add(temp);
                    while (reader.Read())
                    {
                        temp = new object[reader.FieldCount];
                        reader.GetValues(temp);
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            if (temp[i] is DateTime)
                            {
                                temp[i] = temp[i].ToString().Substring(0, temp[i].ToString().IndexOf(' '));
                            }
                        }
                        DGV_Readers.Rows.Add(temp);
                    }
                }
                else
                {
                    DGV_Readers.Rows.Clear();
                    DGV_Readers.Columns.Clear();
                    MessageBox.Show("По данным параметрам не было найдено читателя");
                }
                reader.Close();
            }
            if (DGV_Readers.Rows.Count > 0)
            {
                btn_Info.Enabled = true;
                //btn_Add.Enabled = true;
                btn_Change.Enabled = true;
                btn_Delete.Enabled = true;
                TSM_Readers.Enabled = true;
            }
            else
            {
                btn_Info.Enabled = false;
                //btn_Add.Enabled = false;
                btn_Change.Enabled = false;
                btn_Delete.Enabled = false;
                TSM_Readers.Enabled = false;
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

        private void CB_Birthday_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Birthday.Checked)
            {
                ChosenColumns[2] = true;
            }
            else
            {
                ChosenColumns[2] = false;
            }
        }

        private void CB_Phone_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Phone.Checked)
            {
                ChosenColumns[3] = true;
            }
            else
            {
                ChosenColumns[3] = false;
            }
        }

        private void CB_Email_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Email.Checked)
            {
                ChosenColumns[4] = true;
            }
            else
            {
                ChosenColumns[4] = false;
            }
        }

        private void btn_FilterReset_Click(object sender, EventArgs e)
        {
            CB_Email.Checked = false;
            CB_Phone.Checked = false;
            CB_Birthday.Checked = true;
            CB_Name.Checked = true;
            CB_ReaderTicket.Checked = true;
            CB_Filter_Date.Checked = false;
            CB_Filter_Email.Checked = false;
            CB_Filter_FIO.Checked = false;
            CB_Filter_Library_Code.Checked = false;
            CB_Filter_Phone.Checked = false;
            TB_LibraryCard.Text = "";
            TB_FIO.Text = "";
            TB_Day.Text = "";
            CB_Month.SelectedIndex = -1;
            TB_Year.Text = "";
            TB_PhoneNumber.Text = "";
            TB_Email.Text = "";
            TB_Email.BackColor = Color.White;
            OutputReaders("");
            LastQuery = "";
        }

        private void DGV_Readers_SelectionChanged(object sender, EventArgs e)
        {
            if (DGV_Readers.Rows.Count > 0)
                SelectedReader = DGV_Readers.CurrentRow.Cells[0].Value.ToString();
        }

        private void CB_Filter_Library_Code_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Filter_Library_Code.Checked)
            {
                ChosenFilters[0] = true;
            }
            else
            {
                ChosenFilters[0] = false;
            }
        }

        private void CB_Filter_FIO_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Filter_FIO.Checked)
            {
                ChosenFilters[1] = true;
            }
            else
            {
                ChosenFilters[1] = false;
            }
        }

        private void CB_Filter_Date_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Filter_Date.Checked)
            {
                ChosenFilters[2] = true;
            }
            else
            {
                ChosenFilters[2] = false;
            }
        }

        private void CB_Filter_Phone_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Filter_Phone.Checked)
            {
                ChosenFilters[3] = true;
            }
            else
            {
                ChosenFilters[3] = false;
            }
        }

        private void CB_Filter_Email_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Filter_Email.Checked)
            {
                ChosenFilters[4] = true;
            }
            else
            {
                ChosenFilters[4] = false;
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            OutputReaders(LastQuery);
        }
    }
}
