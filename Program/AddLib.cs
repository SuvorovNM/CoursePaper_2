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

namespace Program
{
    public partial class AddLib : Form
    {
        bool[] correct = new bool[9];
        static string patEmail = @"^(?(')('.+?(?<!\\)'@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
        static string patCity = @"^[a-zA-Zа-яА-Я]+(?:[\s-][a-zA-Zа-яА-Я]+)*$";
        Regex rgEmail = new Regex(patEmail);
        Regex rgCity = new Regex(patCity);
        public AddLib()
        {
            InitializeComponent();
        }

        private void AddLib_Load(object sender, EventArgs e)
        {

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
            bool OK=Control.AddNewLibrarian(TB_Name.Text, TB_Phone.Text, TB_Email.Text, DTP_Birth.Value, CB_Region.Text, TB_City.Text, TB_Street.Text, TB_House.Text, TB_Flat.Text, tb_Password.Text);
            if (!OK)
            {
                MessageBox.Show("Не удалось добавить библиотекаря с такими данными!");
            }
            else
            {
                Close();
            }
        }
    }
}
