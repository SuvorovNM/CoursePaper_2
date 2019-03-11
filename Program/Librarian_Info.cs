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
    public partial class Librarian_Info : Form
    {
        public Librarian_Info()
        {
            InitializeComponent();
        }

        private void Librarian_Info_Load(object sender, EventArgs e)
        {
            //index - ID выбранного библиотекаря
            string index = Librarians.SelectedUser;
            //Получение информации о выбранном библиотекаре
            string command = "select Staff_Number, FIO, Birthday, Phone_Number, Email, Region, City, Street, House_Number, Flat_Number, Password, Hiring_Date from Librarian, Person, Address where Librarian.Person_Code=Person.Person_ID and Address_Code=Address_ID and Staff_Number=" + index;
            DbDataReader reader = Control.ExecCommand(command);
            if (reader.HasRows)
            //Если в БД присутствует библиотекарь с ID=index:
            {
                reader.Read();
                TB_StaffNumber.Text = reader[0].ToString();
                TB_Name.Text = reader[1].ToString();
                TB_Birth.Text = reader[2].ToString().Substring(0, reader[2].ToString().IndexOf(' '));
                TB_Phone.Text = reader[3].ToString();
                TB_Email.Text = reader[4].ToString();
                RTB_Address.Text = "Регион: " + reader[5].ToString() + "; Город: " + reader[6].ToString() + "; Улица: " + reader[7].ToString() + "; Дом: " + reader[8].ToString() + "; Квартира: " + reader[9].ToString();
                TB_Password.Text = reader[10].ToString();
                TB_Hiring_Date.Text = ((DateTime)reader[11]).ToShortDateString();
                reader.Close();
            }
            else
            //Если библиотекарь не был найден:
            {
                reader.Close();
                MessageBox.Show("Не удалось получить информацию о данном библиотекаре!");
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
