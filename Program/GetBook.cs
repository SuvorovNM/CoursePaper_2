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
    public partial class GetBook : Form
    {
        //Регулярное выражение для формата валюты
        static string CurrFormat = @"^((\d{1,3})(?:[0-9]{3}){0,1}|(\d{1})(?:[0-9]{3}){0,2}|(\d{1,7}))(\,\d{2})?$";
        Regex rgCurr = new Regex(CurrFormat);
        //correct - массив, с результатами проверки на корректность каждого элемента:
        bool[] Correct = new bool[3];
        //Publication_ID - ID издания
        string Publication_ID;
        //Operation_ID - ID операции по выдаче книги
        string Operation_ID;
        public GetBook()
        {
            InitializeComponent();
        }
        public GetBook(string id)
        {            
            InitializeComponent();
            TB_BookID.Text = id;
            TB_BookID.Enabled = false;
            UpdateForm();
            Correct[0] = true;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GetBook_Load(object sender, EventArgs e)
        {
            TB_PaySum.Enabled = false;
            RTB_PenaltyInfo.Enabled = false;
            btn_Search.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

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
            btn_Search.Enabled = TB_BookID.Text.Length > 0;
            if (TB_BookID.Text.Length > 0)
            {
                Int32.TryParse(TB_BookID.Text, out id);
                if (id > 0)
                {
                    Correct[0] = true;
                }
                else
                {
                    Correct[0] = false;
                }
            }
            else
            {
                Correct[0] = false;
            }
            if (CB_Penalty.Checked)
                btn_Apply.Enabled = Control.CheckCorrect(Correct);
            else
                btn_Apply.Enabled = Correct[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Поиск книги в базе выданных книг
            UpdateForm();
        }

        private void UpdateForm()
        {
            //items - массив информации о выданной книге:
            //items[0] - номер читательского билета читателя, которому была выдана книга
            //items[1] - дата выдачи книги
            //items[2] - дата, до которой выдана книга
            //items[3] - код операции по выдаче книги
            object[] items = Control.GetInfoAboutGivenBook(TB_BookID.Text);
            if (items != null)
            //Если книга с TB_BookID есть в списке выданных, но не сданных книг
            {
                TB_LibraryTicket.Text = items[0].ToString();
                TB_LibraryTicket.Visible = true;
                lb_ReaderTicket.Visible = true;
                TB_GiveDay.Text = ((DateTime)items[1]).ToShortDateString();
                TB_GiveDay.Visible = true;
                lb_GiveDate.Visible = true;
                TB_GivenUntil.Text = ((DateTime)items[2]).ToShortDateString();
                TB_GivenUntil.Visible = true;
                lb_GivenUntil.Visible = true;
                TB_StaffID.Text = MainMenu.CurrentLibrarian.ID;
                lb_StaffID.Visible = true;
                TB_StaffID.Visible = true;
                TB_Got.Text = DateTime.Today.ToShortDateString();
                TB_Got.Visible = true;
                lb_Get.Visible = true;
                CB_Penalty.Visible = true;
                lb_PaySum.Visible = true;
                TB_PaySum.Visible = true;
                lb_Currency.Visible = true;
                lb_PenaltyInfo.Visible = true;
                RTB_PenaltyInfo.Visible = true;
                btn_Apply.Visible = true;
                Publication_ID = TB_BookID.Text;
                Operation_ID = items[3].ToString();
            }
            else
            //Если книги с TB_BookID нет в списке выданных, но не сданных книг
            {
                TB_LibraryTicket.Visible = false;
                lb_ReaderTicket.Visible = false;
                TB_GiveDay.Visible = false;
                lb_GiveDate.Visible = false;
                TB_GivenUntil.Visible = false;
                lb_GivenUntil.Visible = false;
                lb_StaffID.Visible = false;
                TB_StaffID.Visible = false;
                TB_Got.Visible = false;
                lb_Get.Visible = false;
                CB_Penalty.Visible = false;
                lb_PaySum.Visible = false;
                TB_PaySum.Visible = false;
                lb_Currency.Visible = false;
                lb_PenaltyInfo.Visible = false;
                RTB_PenaltyInfo.Visible = false;
                btn_Apply.Visible = false;
                MessageBox.Show("Данная книга не числится в списке выданных!");
            }
        }

        private void CB_Penalty_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Penalty.Checked)            
            {
                TB_PaySum.Enabled = true;
                RTB_PenaltyInfo.Enabled = true;
                btn_Apply.Enabled = Control.CheckCorrect(Correct);
            }
            else
            {
                TB_PaySum.Enabled = false;
                RTB_PenaltyInfo.Enabled = false;
                btn_Apply.Enabled = Correct[0];
            }

        }

        private void TB_PaySum_KeyUp(object sender, KeyEventArgs e)
        {
            if (rgCurr.IsMatch(TB_PaySum.Text))
            {
                Correct[1] = true;
                TB_PaySum.BackColor = Color.White;
            }
            else
            {
                Correct[1] = false;
                TB_PaySum.BackColor = Color.LightPink;
            }
            btn_Apply.Enabled = Control.CheckCorrect(Correct);
        }

        private void TB_PaySum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)8) || (e.KeyChar == ',')) return;
            else
                e.Handled = true;
        }

        private void RTB_PenaltyInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (RTB_PenaltyInfo.Text.Length > 0)
            {
                Correct[2] = true;
            }
            else
            {
                Correct[2] = false;
            }
            btn_Apply.Enabled = Control.CheckCorrect(Correct);
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            if (CB_Penalty.Checked)
            {
                string PenaltySum = TB_PaySum.Text.Replace(',', '.');
                if (Control.GetBook(Publication_ID, Operation_ID, MainMenu.CurrentLibrarian.ID, RTB_PenaltyInfo.Text, PenaltySum))
                {
                    MessageBox.Show("Книга была принята!");
                    Close();
                }
                else
                {
                    MessageBox.Show("При принятии книги произошла ошибка!");
                }
            }
            else
            {
                if (Control.GetBook(Publication_ID, Operation_ID, MainMenu.CurrentLibrarian.ID,"","0"))
                {
                    MessageBox.Show("Книга была принята!");
                    Close();
                }
                else
                {
                    MessageBox.Show("При принятии книги произошла ошибка!");
                }
            }
        }
    }
}
