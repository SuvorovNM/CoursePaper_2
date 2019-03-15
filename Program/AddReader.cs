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
    public partial class AddReader : Form
    {
        public AddReader(bool _Add)
        {
            InitializeComponent();
            this.Add = _Add;
        }
        public bool Lib = false;
        //Регулярное выражение для поля Email:
        static string patEmail = @"^(?(')('.+?(?<!\\)'@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
        //Регулярное выражение для поля "Город":
        static string patCity = @"^[a-zA-Zа-яА-Я]+(?:[\s-][a-zA-Zа-яА-Я]+)*$";
        Regex rgEmail = new Regex(patEmail);
        Regex rgCity = new Regex(patCity);
        //Add - флаг, определяющий для чего используется форма:
        //false - для добавления библиотекаря
        //true - для изменения информации о существующем библиотекаре
        bool Add = false;
        string reader = "";
        //correct - массив, с результатами проверки на корректность каждого элемента:
        bool[] correct = new bool[11];
        private void CheckCorrect()
        //Провека на то что все элементы correct равны TRUE
        {
            bool OK = true;
            for (int i = 0; i < correct.Length; i++)
            {
                OK = OK && correct[i];
            }
            if (OK)
            {
                btn_OK.Enabled = true;
            }
            else
            {
                btn_OK.Enabled = false;
            }
        }
        public AddReader()
        {
            InitializeComponent();
            Add = false;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            //Проверка и добавление в БД
            //Проверка
            bool OK = true;
            if (!Lib)
            {
                //Добавление читателя
                if (!Add)
                {
                    OK = AddNewReader(OK);
                }
                //Обновление информации о читателе
                else
                {
                    OK = ChangeReader(OK);
                }
            }
            else
            {

            }
            if (!OK)
            {
                MessageBox.Show("Хотя бы 1 из полей не заполнено/заполнено некорректно");
            }
            else
            {
                Close();
            }
        }

        private bool ChangeReader(bool OK)
        //Изменение информации о читателе
        {
            //Получение Person_ID, Address_ID:
            string IDs = "select Person_ID, Address_ID from Reader, Person, Address where Reader.Deleted=0 and Person_Code=Person_ID and Address_Code=Address_ID and Library_Card=" + MainMenu.SelectedReader;
            SqlCommand cmd = new SqlCommand(IDs, Authorization.conn);
            DbDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string Person_ID = reader[0].ToString();
            string Address_ID = reader[1].ToString();
            reader.Close();
            //Обновление информации об экземпляре сущности "Адрес":
            string command = "update Address set Region='" + CB_Region.Text + "', City='" + TB_City.Text + "', Street='" + TB_Street.Text + "', House_Number='" + TB_House.Text + "', Flat_Number='" + TB_Flat.Text + "' where Address_ID=" + Address_ID;
            cmd = new SqlCommand(command, Authorization.conn);
            try
            {
                reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch
            {
                if (!reader.IsClosed)
                    reader.Close();
                OK = false;
            }
            if (OK)
            //Если информация об Адресе была успешна обновлена
            {
                //Получение ГГГГ-ММ-ДД
                string ind = (CB_Month.SelectedIndex + 1).ToString();
                if (ind.Length == 1)
                {
                    ind = "0" + ind;
                }
                string day = TB_Day.Text;
                if (day.Length == 1)
                {
                    day = "0" + day;
                }
                string date = TB_Year.Text + "-" + ind + "-" + day;
                //Обновление информации об экземпляре "Человек":
                command = "update Person set FIO='" + TB_Name.Text + "', Birthday='" + date + "', Phone_Number='" + TB_Phone.Text + "', Email='" + TB_Email.Text + "' where Person_ID=" + Person_ID;
                try
                {
                    cmd = new SqlCommand(command, Authorization.conn);
                    reader = cmd.ExecuteReader();
                    reader.Close();
                }
                catch
                {
                    if (!reader.IsClosed)
                        reader.Close();
                    OK = false;
                }
            }

            return OK;
        }

        private bool AddNewReader(bool OK)
        {
            //Создание нового экземпляра сущности "Адрес"
            string command = "insert into Address(Region, City, Street, House_Number, Flat_Number, Deleted) values ('" + CB_Region.Text + "', '" + TB_City.Text + "', '" + TB_Street.Text + "', '" + TB_House.Text + "', '" + TB_Flat.Text + "', 0)";
            SqlCommand cmd = new SqlCommand(command, Authorization.conn);
            try
            {
                DbDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch
            {
                OK = false;
            }
            if (OK)
            //Если сущность "Адрес" была добавлена
            {
                //Получение ID созданного адреса:
                string command1 = "select max(Address_ID) from Address";
                cmd = new SqlCommand(command1, Authorization.conn);
                DbDataReader reader = cmd.ExecuteReader();
                reader.Read();
                string Address_ID = reader[0].ToString();
                reader.Close();                
                //Определение даты рождения:
                string ind = (CB_Month.SelectedIndex + 1).ToString();
                if (ind.Length == 1)
                {
                    ind = "0" + ind;
                }
                string day = TB_Day.Text;
                if (day.Length == 1)
                {
                    day = "0" + day;
                }
                //date - Дата Рождения
                string date = TB_Year.Text + "-" + ind + "-" + day;
                //Создание сущности "Человек":
                command1 = "insert into Person(FIO, Birthday, Phone_Number, Email, Address_Code, Deleted) values ('" + TB_Name.Text + "', '" + date + "', '" + TB_Phone.Text + "', '" + TB_Email.Text + "', '" + Address_ID + "', 0)";
                cmd = new SqlCommand(command1, Authorization.conn);
                try
                {
                    reader = cmd.ExecuteReader();
                    reader.Close();
                }
                catch
                //Если не удалось добавить:
                {
                    OK = false;
                    //Удалить созданный экземпляр "Адрес":
                    command1 = "delete from Address where Address_ID=" + Address_ID;
                    cmd = new SqlCommand(command1, Authorization.conn);
                    reader = cmd.ExecuteReader();
                    reader.Close();
                }
                if (OK)
                {
                    //Получение ID созданного экземпляра "Человек":
                    string command2 = "select max(Person_ID) from Person";
                    cmd = new SqlCommand(command2, Authorization.conn);
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    string Person_ID = reader[0].ToString();
                    reader.Close();
                    //RegisterDate - дата регистрации - сегодня
                    string RegisterDate = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
                    //Создание экземпляра "Читатель":
                    command2 = "insert into Reader(Person_Code, Registration_Date, Deleted) values ('" + Person_ID + "', '" + RegisterDate + "', 0)";
                    cmd = new SqlCommand(command2, Authorization.conn);
                    try
                    {
                        reader = cmd.ExecuteReader();
                        reader.Close();
                    }
                    catch
                    //Если не удалось добавить новый экземпляр "Читатель"
                    {
                        OK = false;
                        //Удаление созданного экземпляра "Человека"
                        command2 = "delete from Person where Person_ID=" + Person_ID;
                        cmd = new SqlCommand(command2, Authorization.conn);
                        reader = cmd.ExecuteReader();
                        reader.Close();
                        //Удаление созданного экземпляра "Адрес"
                        command1 = "delete from Address where Address_ID=" + Address_ID;
                        cmd = new SqlCommand(command1, Authorization.conn);
                        reader = cmd.ExecuteReader();
                        reader.Close();

                    }
                }
            }

            return OK;
        }

        private void TB_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || (e.KeyChar == ' ') || (e.KeyChar == (char)8)) return;
            else
                e.Handled = true;
        }

        private void TB_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)8)) return;
            else
                e.Handled = true;
        }

        private void TB_Email_KeyUp(object sender, KeyEventArgs e)
        {
            if (TB_Email.Text != null && TB_Email.Text != "")
                if (rgEmail.IsMatch(TB_Email.Text))
                {
                    TB_Email.BackColor = Color.White;
                    correct[2] = true;
                    CheckCorrect();
                }
                else
                {
                    TB_Email.BackColor = Color.LightPink;
                    correct[2] = false;
                    CheckCorrect();
                }
        }

        private void TB_Day_KeyPress(object sender, KeyPressEventArgs e)
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
                TB_Day.BackColor = Color.LightPink;
                correct[3] = false;
                CheckCorrect();
            }
            else
            {
                TB_Day.BackColor = Color.White;
                correct[3] = true;
                CheckCorrect();
            }
        }

        private void TB_Year_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)8)) return;
            else
                e.Handled = true;
        }

        private void TB_Year_KeyUp(object sender, KeyEventArgs e)
        {
            int year;
            Int32.TryParse(TB_Year.Text, out year);
            if (year > DateTime.Today.Year || year < 1900)
            {
                TB_Year.BackColor = Color.LightPink;
                correct[5] = false;
                CheckCorrect();
            }
            else
            {
                TB_Year.BackColor = Color.White;
                correct[5] = true;
                CheckCorrect();
            }
        }

        private void CB_Region_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || (e.KeyChar == ' ') || (e.KeyChar == '-') || (e.KeyChar == (char)8)) return;
            else
                e.Handled = true;
        }

        private void TB_City_KeyUp(object sender, KeyEventArgs e)
        {
            if (TB_City.Text != null && TB_City.Text != "")
                if (rgCity.IsMatch(TB_City.Text))
                {
                    TB_City.BackColor = Color.White;
                    correct[7] = true;
                    CheckCorrect();
                }
                else
                {
                    TB_City.BackColor = Color.LightPink;
                    correct[7] = false;
                    CheckCorrect();
                }
            else
            {
                TB_City.BackColor = Color.LightPink;
                correct[7] = false;
                CheckCorrect();
            }
        }

        private void TB_City_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || (e.KeyChar == ' ') || (e.KeyChar == '-') || (e.KeyChar == (char)8)) return;
            else
                e.Handled = true;
        }

        private void TB_Flat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)8)) return;
            else
                e.Handled = true;
        }

        private void TB_Name_KeyUp(object sender, KeyEventArgs e)
        {
            string temp = TB_Name.Text;
            temp = temp.Replace(" ", "");
            if (temp.Length < 5)
            {
                TB_Name.BackColor = Color.LightPink;
                correct[0] = false;
                CheckCorrect();
            }
            else
            {
                TB_Name.BackColor = Color.White;
                correct[0] = true;
                CheckCorrect();
            }
        }

        private void TB_Phone_KeyUp(object sender, KeyEventArgs e)
        {
            string temp = TB_Phone.Text;
            int count = 0;
            for (int i = 0; i < TB_Phone.Text.Length; i++)
            {
                if (Char.IsDigit(TB_Phone.Text[i]))
                    count++;
            }

            if (count != 11)
            {
                TB_Phone.BackColor = Color.LightPink;
                correct[1] = false;
                CheckCorrect();
            }
            else
            {
                TB_Phone.BackColor = Color.White;
                correct[1] = true;
                CheckCorrect();
            }
        }

        private void CB_Region_KeyUp(object sender, KeyEventArgs e)
        {
            string temp = CB_Region.Text;
            temp = temp.Replace(" ", "");
            if (temp.Length < 3)
            {
                CB_Region.BackColor = Color.LightPink;
                correct[6] = false;
                CheckCorrect();
            }
            else
            {
                CB_Region.BackColor = Color.White;
                correct[6] = true;
                CheckCorrect();
            }
        }

        private void TB_Street_KeyUp(object sender, KeyEventArgs e)
        {
            string temp = TB_Street.Text;
            temp = temp.Replace(" ", "");
            if (temp.Length < 3)
            {
                TB_Street.BackColor = Color.LightPink;
                correct[8] = false;
                CheckCorrect();
            }
            else
            {
                TB_Street.BackColor = Color.White;
                correct[8] = true;
                CheckCorrect();
            }
        }

        private void TB_House_KeyUp(object sender, KeyEventArgs e)
        {
            string temp = TB_House.Text;
            temp = temp.Replace(" ", "");
            if (temp.Length < 1)
            {
                TB_House.BackColor = Color.LightPink;
                correct[9] = false;
                CheckCorrect();
            }
            else
            {
                TB_House.BackColor = Color.White;
                correct[9] = true;
                CheckCorrect();
            }
        }

        private void TB_Flat_KeyUp(object sender, KeyEventArgs e)
        {
            int number;
            Int32.TryParse(TB_Flat.Text, out number);
            if (number > 0)
            {
                TB_Flat.BackColor = Color.White;
                correct[10] = true;
                CheckCorrect();
            }
            else
            {
                TB_Flat.BackColor = Color.LightPink;
                correct[10] = false;
                CheckCorrect();
            }
        }

        private void CB_Region_DropDownClosed(object sender, EventArgs e)
        {
            if (CB_Region.SelectedIndex >= 0)
            {
                CB_Region.BackColor = Color.White;
                correct[6] = true;
            }
        }

        private void CB_Month_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CB_Month.SelectedIndex != -1)
            {
                correct[4] = true;
                CheckCorrect();
            }
            else
            {
                correct[4] = false;
                CheckCorrect();
            }
        }

        private void AddReader_Load(object sender, EventArgs e)
        {
            if (Add)
            {
                string CheckForExistance = "select FIO, Birthday, Phone_Number, Email, Region, City, Street, House_Number, Flat_Number from Reader, Person, Address where Reader.Deleted=0 and Person_Code=Person_ID and Address_Code=Address_ID and Library_Card=" + MainMenu.SelectedReader;
                SqlCommand command = new SqlCommand(CheckForExistance, Authorization.conn);
                DbDataReader reader = command.ExecuteReader();
                bool exist = reader.HasRows;
                this.Text = "Изменение читателя";
                if (exist)
                {
                    reader.Read();
                    TB_Name.Text = reader[0].ToString();
                    TB_Phone.Text = reader[2].ToString();
                    TB_Email.Text = reader[3].ToString();
                    //Выделение
                    string birth = reader[1].ToString().Substring(0, reader[1].ToString().IndexOf(' '));
                    string year = birth.Substring(6);
                    string month = birth.Substring(3, 2);
                    string day = birth.Substring(0,2);
                    TB_Year.Text = year;
                    TB_Day.Text = day;
                    int MonthId = Int32.Parse(month);
                    CB_Month.SelectedIndex = MonthId - 1;
                    CB_Region.Text = reader[4].ToString();
                    TB_City.Text = reader[5].ToString();
                    TB_Street.Text = reader[6].ToString();
                    TB_House.Text = reader[7].ToString();
                    TB_Flat.Text = reader[8].ToString();
                    reader.Close();
                    btn_OK.Enabled = true;
                    for (int i = 0; i < correct.Length; i++)
                    {
                        correct[i] = true;
                    }
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("Не удалось загрузить информацию для изменения для данного читателя!");
                    Close();
                }
            }
        }
    }
}
