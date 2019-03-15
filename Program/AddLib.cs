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
    public partial class AddLib : Form
    {
        //correct - массив, с результатами проверки на корректность каждого элемента:
        bool[] correct = new bool[9];        
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
        public AddLib()
        {
            InitializeComponent();
        }
        public AddLib(bool _Add)
        {
            InitializeComponent();
            Add = _Add;
        }
        private void AddLib_Load(object sender, EventArgs e)
        {
            //Максимально возможная дата принятия на работу - сегодня
            DTP_Hiring_Date.MaxDate = DateTime.Today;
            if (Add)
            //Если форма используется для изменения информации о библиотекаре
            {
                //Заполнение полей формы:
                FillForm();
                this.Text = "Изменение библиотекаря";
            }
        }
        private void FillForm()
        //Заполнение всех полей для выбранного библиотекаря:
        {
            //Получение информации о библиотекаре:
            string CheckForExistance = "select FIO, Phone_Number, Email, Birthday, Region, City, Street, House_Number, Flat_Number, Password, Hiring_Date from Librarian, Person, Address where Librarian.Deleted=0 and Person_Code=Person_ID and Address_Code=Address_ID and Staff_Number=" + Librarians.SelectedUser;
            DbDataReader reader = Control.ExecCommand(CheckForExistance);            
            if (reader.HasRows)
            //Если библиотекарь был найден в БД:
            {
                reader.Read();
                TB_Name.Text = reader[0].ToString();
                TB_Phone.Text = reader[1].ToString();
                TB_Email.Text = reader[2].ToString();
                DTP_Birth.Value = (DateTime)reader[3];
                CB_Region.Text = reader[4].ToString();
                TB_City.Text = reader[5].ToString();
                TB_Street.Text = reader[6].ToString();
                TB_House.Text = reader[7].ToString();
                TB_Flat.Text = reader[8].ToString();
                tb_Password.Text = reader[9].ToString();
                DTP_Hiring_Date.Value = (DateTime)reader[10];
                reader.Close();
                //Предполагается, что все полученные поля заполнены корректно:
                btn_OK.Enabled = true;
                for (int i = 0; i < correct.Length; i++)
                {
                    correct[i] = true;
                }
            }
            else reader.Close();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TB_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || (e.KeyChar == ' ') || (e.KeyChar == (char)8)) return;
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
            }
            else
            {
                TB_Name.BackColor = Color.White;
                correct[0] = true;
            }
            btn_OK.Enabled = Control.CheckCorrect(correct);
        }

        private void TB_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)8)) return;
            else
                e.Handled = true;
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
            }
            else
            {
                TB_Phone.BackColor = Color.White;
                correct[1] = true;
            }
            btn_OK.Enabled = Control.CheckCorrect(correct);
        }

        private void TB_Email_KeyUp(object sender, KeyEventArgs e)
        {
            if (TB_Email.Text != null && TB_Email.Text != "")
                if (rgEmail.IsMatch(TB_Email.Text))
                {
                    TB_Email.BackColor = Color.White;
                    correct[2] = true;
                }
                else
                {
                    TB_Email.BackColor = Color.LightPink;
                    correct[2] = false;
                }
            btn_OK.Enabled = Control.CheckCorrect(correct);
        }

        private void CB_Region_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || (e.KeyChar == ' ') || (e.KeyChar == '-') || (e.KeyChar == (char)8)) return;
            else
                e.Handled = true;
        }

        private void CB_Region_KeyUp(object sender, KeyEventArgs e)
        {
            string temp = CB_Region.Text;
            temp = temp.Replace(" ", "");
            if (temp.Length < 3)
            {
                CB_Region.BackColor = Color.LightPink;
                correct[3] = false;
            }
            else
            {
                CB_Region.BackColor = Color.White;
                correct[3] = true;
            }
            btn_OK.Enabled = Control.CheckCorrect(correct);
        }

        private void CB_Region_DropDownClosed(object sender, EventArgs e)
        {
            if (CB_Region.SelectedIndex >= 0)
            {
                CB_Region.BackColor = Color.White;
                correct[3] = true;
            }
        }

        private void TB_City_KeyPress(object sender, KeyPressEventArgs e)
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
                    correct[4] = true;
                }
                else
                {
                    TB_City.BackColor = Color.LightPink;
                    correct[4] = false;
                }
            else
            {
                TB_City.BackColor = Color.LightPink;
                correct[4] = false;
            }
            btn_OK.Enabled = Control.CheckCorrect(correct);
        }

        private void TB_Street_KeyUp(object sender, KeyEventArgs e)
        {
            string temp = TB_Street.Text;
            temp = temp.Replace(" ", "");
            if (temp.Length < 3)
            {
                TB_Street.BackColor = Color.LightPink;
                correct[5] = false;
            }
            else
            {
                TB_Street.BackColor = Color.White;
                correct[5] = true;
            }
            btn_OK.Enabled = Control.CheckCorrect(correct);
        }

        private void TB_House_KeyUp(object sender, KeyEventArgs e)
        {
            string temp = TB_House.Text;
            temp = temp.Replace(" ", "");
            if (temp.Length < 1)
            {
                TB_House.BackColor = Color.LightPink;
                correct[6] = false;
            }
            else
            {
                TB_House.BackColor = Color.White;
                correct[6] = true;
            }
            btn_OK.Enabled = Control.CheckCorrect(correct);
        }

        private void TB_Flat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)8)) return;
            else
                e.Handled = true;
        }

        private void TB_Flat_KeyUp(object sender, KeyEventArgs e)
        {
            int number;
            Int32.TryParse(TB_Flat.Text, out number);
            if (number > 0)
            {
                TB_Flat.BackColor = Color.White;
                correct[7] = true;
            }
            else
            {
                TB_Flat.BackColor = Color.LightPink;
                correct[7] = false;
            }
            btn_OK.Enabled = Control.CheckCorrect(correct);
        }

        private void tb_Password_KeyUp(object sender, KeyEventArgs e)
        {
            string t = tb_Password.Text;
            if (t.Length > 2)
            {
                tb_Password.BackColor = Color.White;
                correct[8] = true;
            }
            else
            {
                tb_Password.BackColor = Color.LightPink;
                correct[8] = false;
            }
            btn_OK.Enabled=Control.CheckCorrect(correct);
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (!Add)
            //Если форма используется для добавления библиотекаря
            {
                bool OK = Control.AddNewLibrarian(TB_Name.Text, TB_Phone.Text, TB_Email.Text, DTP_Birth.Value, CB_Region.Text, TB_City.Text, TB_Street.Text, TB_House.Text, TB_Flat.Text, tb_Password.Text, DTP_Hiring_Date.Value);
                if (!OK)
                {
                    MessageBox.Show("Не удалось добавить библиотекаря с такими данными!");
                }
                else
                {
                    Close();
                }
            }
            else
            //Если форма используется для изменения библиотекаря
            {
                bool OK = Control.ChangeLibrarian(TB_Name.Text, TB_Phone.Text, TB_Email.Text, DTP_Birth.Value, CB_Region.Text, TB_City.Text, TB_Street.Text, TB_House.Text, TB_Flat.Text, tb_Password.Text, DTP_Hiring_Date.Value);
                if (!OK)
                {
                    MessageBox.Show("При обновлении данных о библиотекаре возникла ошибка!");
                }
                else
                {
                    Close();
                }
            }
        }
    }
}
