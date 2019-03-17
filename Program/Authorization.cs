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
    public partial class Authorization : Form
    {
        //menu - ссылка на Главное меню приложения
        public static MainMenu menu;
        //conn - созданное подключение к БД
        public static SqlConnection conn;
        //SQLlogpass - sql запрос по заданным логину и паролю
        private string SQLlogpass = "";
        public Authorization()
        {
            InitializeComponent();
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            DbDataReader reader;
            try
            {
                //Проверка на наличие библиотекаря с штатным номером = login и паролем = password
                SQLlogpass = @"select Staff_Number, FIO, Birthday, Phone_Number, Email, Region, City, Street, House_Number, Flat_Number, Privilege from Librarian, Person, Address where Staff_Number='" + tb_Login.Text + "' and Password='" + tb_Password.Text + "' and Librarian.Deleted=0 and Librarian.Person_Code=Person.Person_ID and Person.Address_Code=Address_ID";
                SqlCommand cmd = new SqlCommand(SQLlogpass, conn);
                reader = cmd.ExecuteReader();
                bool correct = reader.HasRows;
                if (correct)
                //Если есть такой библиотекарь, т.е. авторизация прошла успешно
                {
                    reader.Read();
                    //Получение информации о библиотекаре:
                    string Birth = reader[2].ToString();
                    Birth = Birth.Substring(0, Birth.IndexOf(' '));
                    string Address = "Регион: " + reader[5].ToString() + "; Город: " + reader[6].ToString() + "; Улица: " + reader[7].ToString() + "; Дом: " + reader[8].ToString() + "; Квартира: " + reader[9].ToString();
                    //Определение текущего библиотекаря для Главного Меню:
                    MainMenu.CurrentLibrarian = new Librarian(reader[0].ToString(), reader[1].ToString(), Birth, reader[3].ToString(), reader[4].ToString(), Address);
                    //Определение прав администратора:
                    MainMenu.admin = (bool)reader[10];
                    reader.Close();
                    //Показ формы
                    menu.Show();
                    MainMenu.enter = this;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Введен неверный логин и/или пароль!");
                }
                reader.Close();
            }
            catch
            {

            }
        }

        private void Authorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
            //menu.Close();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            MainMenu mainform = new MainMenu();
            menu = mainform;
            conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
