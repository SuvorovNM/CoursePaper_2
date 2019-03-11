using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program
{
    public partial class GiveBook : Form
    {
        //Correct - флаг, показывающий корректность заполнения поля "Идент. номер книги"
        bool Correct = false;
        //date - дата, до которой выдана книга
        string date;
        public GiveBook()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GiveBook_Load(object sender, EventArgs e)
        {
            TB_LibraryTicket.Text = MainMenu.SelectedReader;
            TB_StaffID.Text = MainMenu.CurrentLibrarian.ID;
            string date = DateTime.Today.ToShortDateString();
            TB_GiveDay.Text = date;
            DTP_GiveDate.MinDate = DateTime.Today.AddDays(1);
        }

        private void TB_BookID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)8)) return;
            else
                e.Handled = true;
        }

        private void TB_BookID_KeyUp(object sender, KeyEventArgs e)
        {
            int id = 0;
            if (TB_BookID.Text.Length > 0)
            {
                Int32.TryParse(TB_BookID.Text, out id);
                if (id > 0)
                {
                    Correct = true;
                }
                else
                {
                    Correct = false;
                }
            }
            else
            {
                Correct = false;
            }
            btn_OK.Enabled = Correct;
        }

        private void TB_Day_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)8)) return;
            else
                e.Handled = true;
        }

        private void DTP_GiveDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = DTP_GiveDate.Value;
            date = "";
            date = dt.Year + "-" + dt.Month + "-" + dt.Day;            
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (Control.BookExists(TB_BookID.Text))
            //Если книга была найдена в списке доступных, то выдача книги текущему читателю:
            {
                string Today = DateTime.Today.Year + "-" + DateTime.Today.Month + "-" + DateTime.Today.Day;
                string id =Control.GiveBook(TB_StaffID.Text, TB_LibraryTicket.Text, TB_BookID.Text, Today, date);
                if (id != "-1")
                {
                    MessageBox.Show("Книга была успешно выдана! Код операции: "+id);
                    Close();
                }
            }
            else
            //Если книги нет в списке доступных для выдачи, вывод сообщения об ошибке:
            {
                MessageBox.Show("Данной книги нет в списке доступных для выдачи книг!");
            }
        }
    }
}
