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
        static string patEmail = @"^(?(')('.+?(?<!\\)'@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
        static string patCity = @"^[a-zA-Zа-яА-Я]+(?:[\s-][a-zA-Zа-яА-Я]+)*$";
        Regex rgEmail = new Regex(patEmail);
        Regex rgCity = new Regex(patCity);
        public AddReader()
        {
            InitializeComponent();
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
            string command = "insert into Address(Region, City, Street, House_Number, Flat_Number, Deleted) values ('"+CB_Region.Text+"', '"+TB_City.Text+"', '"+TB_Street.Text+"', '"+TB_House.Text+"', '"+TB_Flat.Text+"', 0)";
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
            {
                string command1 = "select max(Address_ID) from Address";
                cmd = new SqlCommand(command1, Authorization.conn);
                DbDataReader reader = cmd.ExecuteReader();
                reader.Read();
                string Address_ID = reader[0].ToString();
                reader.Close();//                
                //Определение даты рождения
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
                string date = TB_Year.Text + "-" + ind + "-" + day;
                command1 = "insert into Person(FIO, Birthday, Phone_Number, Email, Address_Code, Deleted) values ('"+TB_Name.Text+"', '"+date+"', '"+TB_Phone.Text+"', '"+TB_Email.Text+"', '"+Address_ID+"', 0)";
                cmd = new SqlCommand(command1, Authorization.conn);
                try
                {
                    reader = cmd.ExecuteReader();
                    reader.Close();
                }
                catch
                {
                    OK = false;
                    command1 = "delete from Address where Address_ID="+Address_ID;
                    cmd = new SqlCommand(command1, Authorization.conn);
                    reader =cmd.ExecuteReader();
                    reader.Close();
                }
                if (OK)
                {
                    string command2 = "select max(Person_ID) from Person";
                    cmd = new SqlCommand(command2, Authorization.conn);
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    string Person_ID = reader[0].ToString();
                    reader.Close();                    
                    string RegisterDate = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
                    command2 = "insert into Reader(Person_Code, Registration_Date, Deleted) values ('" + Person_ID + "', '" + RegisterDate + "', 0)";
                    cmd = new SqlCommand(command2, Authorization.conn);
                    try
                    {
                        reader = cmd.ExecuteReader();
                        reader.Close();
                        //UPDATE
                        
                    }
                    catch
                    {
                        OK = false;
                        command2 = "delete from Person where Person_ID=" + Person_ID;
                        cmd = new SqlCommand(command2, Authorization.conn);
                        reader = cmd.ExecuteReader();
                        reader.Close();
                        command1 = "delete from Address where Address_ID=" + Address_ID;
                        cmd = new SqlCommand(command1, Authorization.conn);
                        reader=cmd.ExecuteReader();
                        reader.Close();
                        
                    }
                }
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
                }
                else
                {
                    TB_Email.BackColor = Color.LightPink;
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
                if (TB_Day.Text != "" && TB_Day.Text != null)
                    TB_Day.BackColor = Color.LightPink;
            }
            else
            {
                TB_Day.BackColor = Color.White;
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
            }
            else
            {
                TB_Year.BackColor = Color.White;
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
            if (TB_City.Text!=null&&TB_City.Text!="")
                if (rgCity.IsMatch(TB_City.Text))
                {
                    TB_City.BackColor = Color.White;
                }
                else
                {
                    TB_City.BackColor = Color.LightPink;
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
            }
            else
            {
                TB_Name.BackColor = Color.White;
            }
        }

        private void TB_Phone_KeyUp(object sender, KeyEventArgs e)
        {
            string temp = TB_Phone.Text;
            int count = 0;
            for (int i=0;i< TB_Phone.Text.Length; i++)
            {
                if (Char.IsDigit(TB_Phone.Text[i]))
                    count++;
            }
            
            if (count != 11)
            {
                TB_Phone.BackColor = Color.LightPink;
            }
            else
            {
                TB_Phone.BackColor = Color.White;
            }
        }

        private void CB_Region_KeyUp(object sender, KeyEventArgs e)
        {
            string temp = CB_Region.Text;
            temp = temp.Replace(" ", "");
            if (temp.Length < 3)
            {
                CB_Region.BackColor = Color.LightPink;                
            }
            else
            {
                CB_Region.BackColor = Color.White;
            }
        }

        private void TB_Street_KeyUp(object sender, KeyEventArgs e)
        {
            string temp = TB_Street.Text;
            temp = temp.Replace(" ", "");
            if (temp.Length < 3)
            {
                TB_Street.BackColor = Color.LightPink;
            }
            else
            {
                TB_Street.BackColor = Color.White;
            }
        }

        private void TB_House_KeyUp(object sender, KeyEventArgs e)
        {
            string temp = TB_House.Text;
            temp = temp.Replace(" ", "");
            if (temp.Length < 1)
            {
                TB_House.BackColor = Color.LightPink;
            }
            else
            {
                TB_House.BackColor = Color.White;
            }
        }

        private void TB_Flat_KeyUp(object sender, KeyEventArgs e)
        {
            int number;
            Int32.TryParse(TB_Flat.Text, out number);
            if (number > 0)
            {
                TB_Flat.BackColor = Color.White;
            }
            else
            {
                TB_Flat.BackColor = Color.LightPink;
            }
        }

        private void CB_Region_DropDownClosed(object sender, EventArgs e)
        {
            if (CB_Region.SelectedIndex >= 0)
            {
                CB_Region.BackColor = Color.White;
            }
        }
    }
}
