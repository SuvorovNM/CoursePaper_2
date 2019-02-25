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
    public partial class ReaderInfo : Form
    {//Добавить инфу о штрафах
        public ReaderInfo()
        {
            InitializeComponent();
        }

        private void btn_CurrentBooks_Click(object sender, EventArgs e)
        {
            CurrentBooks formBooks = new CurrentBooks();
            formBooks.ShowDialog();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ReaderInfo_Load(object sender, EventArgs e)
        {
            string index = MainMenu.SelectedReader;
            string command = "select Library_Card, FIO, Birthday, Phone_Number, Email, Region, City, Street, House_Number, Flat_Number from Reader, Person, Address where Reader.Person_Code=Person.Person_ID and Address_Code=Address_ID and Library_Card="+index;
            SqlCommand cmd = new SqlCommand(command, Authorization.conn);
            DbDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                TB_LibraryTicket.Text = reader[0].ToString();
                TB_Name.Text = reader[1].ToString();
                TB_Birth.Text = reader[2].ToString().Substring(0, reader[2].ToString().IndexOf(' '));
                TB_Phone.Text = reader[3].ToString();
                TB_Email.Text = reader[4].ToString();
                RTB_Address.Text = "Регион: " + reader[5].ToString() + "; Город: " + reader[6].ToString() + "; Улица: " + reader[7].ToString() + "; Дом: " + reader[8].ToString() + "; Квартира: " + reader[9].ToString();
            }
            reader.Close();
        }
    }
}
