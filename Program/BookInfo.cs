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
    public partial class BookInfo : Form
    {
        public BookInfo()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BookInfo_Load(object sender, EventArgs e)
        {
            //Определение типа издания
            string cmdType = "select * from Publication, Book where Book.Publication_Code=Publication_ID and Publication_ID="+Books.SelectedBook;
            SqlCommand cmd = new SqlCommand(cmdType, Authorization.conn);
            DbDataReader reader = cmd.ExecuteReader();
            bool IsBook = reader.HasRows;
            reader.Close();
            if (IsBook)
            //Выбрана книга
            {
                //Получение информации о книге и вывод пользователю:
                string command = "select Publication_ID, Publication.Name, Publication.Author, BBK, UDK, ISBN, Page_Quantity, Publisher.Name, Publisher.City, Year, Available from Publication, Publisher, Book where Book.Publication_Code=Publication_ID and Publisher_Code=Publisher_ID and Publication_ID="+Books.SelectedBook;
                cmd = new SqlCommand(command, Authorization.conn);
                reader = cmd.ExecuteReader();
                reader.Read();
                TB_BookID.Text = reader[0].ToString();
                TB_Name.Text = reader[1].ToString();
                TB_Author.Text = reader[2].ToString();
                TB_BBK.Text = reader[3].ToString();
                TB_UDK.Text = reader[4].ToString();
                TB_ISBN.Text = reader[5].ToString();
                TB_Pages.Text = reader[6].ToString();
                RTB_Publisher.Text = "Название: "+reader[7].ToString()+ "; Город: "+ reader[8].ToString()+"; Год: "+ reader[9].ToString();
                string temp = reader[10].ToString();
                if (temp == "True")
                {
                    TB_Availability.Text = "Есть в наличии";
                }
                else
                {
                    TB_Availability.Text = "Нет в наличии";
                }
                reader.Close();
            }
            else
            //Выбрано серийное издание
            {
                //Получение информации о серийном издании и вывод пользователю:
                string command = "select Publication_ID, Publication.Name, Publication.Author, BBK, UDK, ISSN, Page_Quantity, Publisher.Name, Publisher.City, Year, Available, Release_Number from Publication, Publisher, Journal where Journal.Publication_Code=Publication_ID and Publisher_Code=Publisher_ID and Publication_ID=" + Books.SelectedBook;
                cmd = new SqlCommand(command, Authorization.conn);
                reader = cmd.ExecuteReader();
                reader.Read();
                TB_BookID.Text = reader[0].ToString();
                TB_Name.Text = reader[1].ToString()+"; Номер: "+reader[11].ToString();
                TB_Author.Text = reader[2].ToString();
                TB_BBK.Text = reader[3].ToString();
                TB_UDK.Text = reader[4].ToString();
                TB_ISBN.Text = reader[5].ToString();
                TB_Pages.Text = reader[6].ToString();
                RTB_Publisher.Text = "Название: " + reader[7].ToString() + "; Город: " + reader[8].ToString() + "; Год: " + reader[9].ToString();
                if (reader[10].ToString() == "True")
                {
                    TB_Availability.Text = "Есть в наличии";
                }
                else
                {
                    TB_Availability.Text = "Нет в наличии";
                }
                reader.Close();
            }
            
        }
    }
}
