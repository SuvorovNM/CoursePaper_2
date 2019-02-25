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
    public partial class AddBook : Form
    {
        static string patCity = @"^[a-zA-Zа-яА-Я]+(?:[\s-][a-zA-Zа-яА-Я]+)*$";
        Regex rgCity = new Regex(patCity);
        static string patISSN = @"^\d{4}-\d{3}[\dxX]$";
        Regex rgISSN = new Regex(patISSN);
        public AddBook()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TB_Author_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || (e.KeyChar == ' ') || (e.KeyChar == (char)8)) return;
            else
                e.Handled = true;
        }

        private void TB_ISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == '-') || (e.KeyChar == (char)8)) return;
            else
                e.Handled = true;
        }

        private void TB_Pages_KeyPress(object sender, KeyPressEventArgs e)
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
                }
                else
                {
                    TB_City.BackColor = Color.LightPink;
                }
        }

        private void TB_Year_KeyUp(object sender, KeyEventArgs e)
        {
            int year;
            Int32.TryParse(TB_Year.Text, out year);
            if (year > DateTime.Today.Year || year < 1300)
            {
                TB_Year.BackColor = Color.LightPink;
            }
            else
            {
                TB_Year.BackColor = Color.White;
            }
        }

        private void TB_Pages_KeyUp(object sender, KeyEventArgs e)
        {
            int pages;
            Int32.TryParse(TB_Pages.Text, out pages);
            if (pages < 1)
            {
                TB_Pages.BackColor = Color.LightPink;
            }
            else
            {
                TB_Pages.BackColor = Color.White;
            }
        }

        private void TB_BBK_KeyUp(object sender, KeyEventArgs e)
        {
            string temp = TB_BBK.Text;
            temp = temp.Replace(" ", "");
            if (temp.Length<2)
            {
                TB_BBK.BackColor = Color.LightPink;
            }
            else
            {
                TB_BBK.BackColor = Color.White;
            }
        }

        private void TB_ISBN_KeyUp(object sender, KeyEventArgs e)
        {
            if (TB_ISBN.Text.Length == 9 && TB_ISBN.Text.IndexOf('-')==4)
            {
                if (rgISSN.IsMatch(TB_ISBN.Text))
                {
                    TB_ISBN.BackColor = Color.White;
                }
                else
                {
                    TB_ISBN.BackColor = Color.LightPink;
                }
            }
            else if (TB_ISBN.Text.Length == 1 && TB_ISBN.Text[0] == '-')
            {
                TB_ISBN.BackColor = Color.White;
            }
            else if (TB_ISBN.Text.Length > 9)
            {
                if (TB_ISBN.Text.Split('-').Length < 3|| TB_ISBN.Text.Split('-').Length > 5)
                {
                    TB_ISBN.BackColor = Color.LightPink;
                }
                else
                {
                    TB_ISBN.BackColor = Color.White;
                }
            }
            else
            {
                TB_ISBN.BackColor = Color.LightPink;
            }
        }

        private void TB_UDK_KeyUp(object sender, KeyEventArgs e)
        {
            string temp = TB_UDK.Text;
            temp = temp.Replace(" ", "");
            if (temp.Length < 2)
            {
                TB_UDK.BackColor = Color.LightPink;
            }
            else
            {
                TB_UDK.BackColor = Color.White;
            }
        }

        private void TB_Name_KeyUp(object sender, KeyEventArgs e)
        {
            string temp = TB_Name.Text;
            temp = temp.Replace(" ", "");
            if (temp.Length < 2)
            {
                TB_Name.BackColor = Color.LightPink;
            }
            else
            {
                TB_Name.BackColor = Color.White;
            }
        }

        private void TB_Author_KeyUp(object sender, KeyEventArgs e)
        {
            string temp = TB_Author.Text;
            temp = temp.Replace(" ", "");
            if (temp.Length < 5)
            {
                TB_Author.BackColor = Color.LightPink;
            }
            else
            {
                TB_Author.BackColor = Color.White;
            }
        }

        private void TB_PubName_KeyUp(object sender, KeyEventArgs e)
        {
            string temp = TB_PubName.Text;
            temp = temp.Replace(" ", "");
            if (temp.Length < 2)
            {
                TB_PubName.BackColor = Color.LightPink;
            }
            else
            {
                TB_PubName.BackColor = Color.White;
            }
        }

        private void CB_PubType_Click(object sender, EventArgs e)
        {
            
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            lb_ReleaseNumber.Visible = false;
            TB_ReleaseNumber.Visible = false;
        }

        private void CB_PubType_DropDownClosed(object sender, EventArgs e)
        {
            //Если выбран журнал, то включить отображение полей под № выпуска
            if (CB_PubType.SelectedIndex == 1)
            {
                lb_ReleaseNumber.Visible = true;
                TB_ReleaseNumber.Visible = true;
            }
            else
            {
                lb_ReleaseNumber.Visible = false;
                TB_ReleaseNumber.Visible = false;
            }
        }
        //Проверить остальные поля на press_up
    }
}
