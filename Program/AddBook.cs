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
    public partial class AddBook : Form
    {
        //Регулярное выражение для поля "Город":
        static string patCity = @"^[a-zA-Zа-яА-Я]+(?:[\s-][a-zA-Zа-яА-Я]+)*$";
        Regex rgCity = new Regex(patCity);
        //Регулярное выражение для ISSN периодического издания:
        static string patISSN = @"^\d{4}-\d{3}[\dxX]$";
        Regex rgISSN = new Regex(patISSN);
        //correct - массив, с результатами проверки на корректность каждого элемента:
        bool[] correct = new bool[11];
        //IsUpdate - флаг, определяющий для чего используется форма:
        //false - для добавления книги
        //true - для изменения информации о существующей книге
        bool IsUpdate = false;
        public AddBook()
        {
            IsUpdate = false;
            InitializeComponent();
        }
        public AddBook(bool Upd)
        {
            IsUpdate = Upd;
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
                    correct[10] = true;
                }
                else
                {
                    TB_City.BackColor = Color.LightPink;
                    correct[10] = false;
                }
            else
            {
                TB_City.BackColor = Color.LightPink;
                correct[10] = false;
            }
            btn_OK.Enabled = Control.CheckCorrect(correct);
        }

        private void TB_Year_KeyUp(object sender, KeyEventArgs e)
        {
            int year;
            Int32.TryParse(TB_Year.Text, out year);
            if (year > DateTime.Today.Year || year < 1300)
            {
                TB_Year.BackColor = Color.LightPink;
                correct[9] = false;
            }
            else
            {
                TB_Year.BackColor = Color.White;
                correct[9] = true;
            }
            btn_OK.Enabled = Control.CheckCorrect(correct);
        }

        private void TB_Pages_KeyUp(object sender, KeyEventArgs e)
        {
            int pages;
            Int32.TryParse(TB_Pages.Text, out pages);
            if (pages < 1)
            {
                TB_Pages.BackColor = Color.LightPink;
                correct[6] = false;
            }
            else
            {
                TB_Pages.BackColor = Color.White;
                correct[6] = true;
            }
            btn_OK.Enabled = Control.CheckCorrect(correct);
        }

        private void TB_BBK_KeyUp(object sender, KeyEventArgs e)
        {
            string temp = TB_BBK.Text;
            temp = temp.Replace(" ", "");
            if (temp.Length<2)
            {
                TB_BBK.BackColor = Color.LightPink;
                correct[3] = false;
            }
            else
            {
                TB_BBK.BackColor = Color.White;
                correct[3] = true;
            }
            btn_OK.Enabled = Control.CheckCorrect(correct);
        }

        private void TB_ISBN_KeyUp(object sender, KeyEventArgs e)
        {
            if (TB_ISBN.Text.Length == 9 && TB_ISBN.Text.IndexOf('-')==4)
            {
                if (rgISSN.IsMatch(TB_ISBN.Text))
                {
                    TB_ISBN.BackColor = Color.White;
                    correct[5] = true;
                }
                else
                {
                    TB_ISBN.BackColor = Color.LightPink;
                    correct[5] = false;
                }
            }
            else if (TB_ISBN.Text.Length == 1 && TB_ISBN.Text[0] == '-')
            {
                TB_ISBN.BackColor = Color.White;
                correct[5] = true;
            }
            else if (TB_ISBN.Text.Length > 9)
            {
                if (TB_ISBN.Text.Split('-').Length < 3|| TB_ISBN.Text.Split('-').Length > 5)
                {
                    TB_ISBN.BackColor = Color.LightPink;
                    correct[5] = false;
                }
                else
                {
                    TB_ISBN.BackColor = Color.White;
                    correct[5] = true;
                }
            }
            else
            {
                TB_ISBN.BackColor = Color.LightPink;
                correct[5] = false;
            }
            btn_OK.Enabled = Control.CheckCorrect(correct);
        }

        private void TB_UDK_KeyUp(object sender, KeyEventArgs e)
        {
            string temp = TB_UDK.Text;
            temp = temp.Replace(" ", "");
            if (temp.Length < 2)
            {
                TB_UDK.BackColor = Color.LightPink;
                correct[4] = false;
            }
            else
            {
                TB_UDK.BackColor = Color.White;
                correct[4] = true;
            }
            btn_OK.Enabled = Control.CheckCorrect(correct);
        }

        private void TB_Name_KeyUp(object sender, KeyEventArgs e)
        {
            string temp = TB_Name.Text;
            temp = temp.Replace(" ", "");
            if (temp.Length < 2)
            {
                TB_Name.BackColor = Color.LightPink;
                correct[1] = false;
            }
            else
            {
                TB_Name.BackColor = Color.White;
                correct[1] = true;
            }
            btn_OK.Enabled = Control.CheckCorrect(correct);
        }

        private void TB_Author_KeyUp(object sender, KeyEventArgs e)
        {
            string temp = TB_Author.Text;
            temp = temp.Replace(" ", "");
            if (temp.Length < 5)
            {
                TB_Author.BackColor = Color.LightPink;
                correct[2] = false;
            }
            else
            {
                TB_Author.BackColor = Color.White;
                correct[2] = true;
            }
            btn_OK.Enabled = Control.CheckCorrect(correct);
        }

        private void TB_PubName_KeyUp(object sender, KeyEventArgs e)
        {
            string temp = TB_PubName.Text;
            temp = temp.Replace(" ", "");
            if (temp.Length < 2)
            {
                TB_PubName.BackColor = Color.LightPink;
                correct[8] = false;
            }
            else
            {
                TB_PubName.BackColor = Color.White;
                correct[8] = true;
            }
            btn_OK.Enabled = Control.CheckCorrect(correct);
        }

        private void CB_PubType_Click(object sender, EventArgs e)
        {
            
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            lb_ReleaseNumber.Visible = false;
            TB_ReleaseNumber.Visible = false;
            //Если форма используется для добавления книги
            if (!IsUpdate)
            {
                btn_OK.Enabled = false;
            }
            else
            //Если форма используется для изменения информации о книге
            {
                this.Text = "Изменение издания";
                //Все поля ожидаются корректно заполненными
                for (int i = 0; i < correct.Length; i++)
                {
                    correct[i] = true;
                }
                btn_OK.Enabled = true;
                //Проверка на то, что изменяется: книга или серийное издание:
                string SQLCheck = "select * from Book, Publication where Publication_ID=Publication_Code and Publication.Deleted=0 and Publication_ID="+Books.SelectedBook;
                DbDataReader reader = Control.ExecCommand(SQLCheck);
                bool IsBook = reader.HasRows;
                reader.Close();
                if (IsBook)//Выбрана книга
                {
                    //Получение необходимой информации о книге для заполнения всех элементов:
                    CB_PubType.SelectedIndex = 0;
                    CB_PubType.Enabled = false;
                    string SQLInfo = "select Publication.Name, Author, BBK, UDK, ISBN, Page_Quantity, Publisher.Name, Year, City from Publication, Publisher, Book where Publication_Code=Publication_ID and Publisher_Code=Publisher_ID and Publication_ID="+Books.SelectedBook;
                    reader = Control.ExecCommand(SQLInfo);
                    reader.Read();
                    TB_Name.Text = reader[0].ToString();
                    TB_Author.Text = reader[1].ToString();
                    TB_BBK.Text = reader[2].ToString();
                    TB_UDK.Text = reader[3].ToString();
                    TB_ISBN.Text = reader[4].ToString();
                    TB_Pages.Text = reader[5].ToString();
                    TB_PubName.Text = reader[6].ToString();
                    TB_Year.Text = reader[7].ToString();
                    TB_City.Text = reader[8].ToString();
                    reader.Close();
                }
                else//Выбрано периодическое издание
                {
                    //Получение необходимой информации о серийном издании для заполнения всех элементов:
                    string SQLInfo = "select Publication.Name, Author, BBK, UDK, ISSN, Page_Quantity, Publisher.Name, Year, City, Release_Number from Publication, Publisher, Journal where Publication_Code=Publication_ID and Publisher_Code=Publisher_ID and Publication_ID=" + Books.SelectedBook;
                    reader = Control.ExecCommand(SQLInfo);
                    reader.Read();
                    TB_Name.Text = reader[0].ToString();
                    TB_Author.Text = reader[1].ToString();
                    TB_BBK.Text = reader[2].ToString();
                    TB_UDK.Text = reader[3].ToString();
                    TB_ISBN.Text = reader[4].ToString();
                    TB_Pages.Text = reader[5].ToString();
                    TB_PubName.Text = reader[6].ToString();
                    TB_Year.Text = reader[7].ToString();
                    TB_City.Text = reader[8].ToString();
                    TB_ReleaseNumber.Text = reader[9].ToString();
                    CB_PubType.SelectedIndex = 1;
                    CB_PubType.Enabled = false;
                    lb_ReleaseNumber.Visible = true;
                    TB_ReleaseNumber.Visible = true;
                    reader.Close();
                }
            }
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

        private void CB_PubType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_PubType.SelectedIndex==0)
            {
                correct[7] = true;
            }
            else
            {
                if (TB_ReleaseNumber.Text != null && TB_ReleaseNumber.Text != "")
                {
                    correct[7] = true;
                }
                else correct[7] = false;
            }
            correct[0] = true;
            btn_OK.Enabled = Control.CheckCorrect(correct);
        }

        private void TB_ReleaseNumber_KeyUp(object sender, KeyEventArgs e)
        {
            if (TB_ReleaseNumber.Text.Length > 0)
            {
                correct[7] = true;
                TB_ReleaseNumber.BackColor = Color.White;
            }
            else
            {
                correct[7] = false;
                TB_ReleaseNumber.BackColor = Color.LightPink;
            }
            btn_OK.Enabled = Control.CheckCorrect(correct);
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            DbDataReader reader;            
            if (!IsUpdate)
            //Если новое издание добавляется:
            {
                //PubID - ID издателя
                //AddNewPublisher - операция по добавлению нового издательства
                int PubID =Control.AddNewPublisher(TB_PubName.Text, TB_Year.Text, TB_City.Text);                
                if (PubID == -1)
                //Если не удалось добавить Издательство:
                {
                    MessageBox.Show("Поля издателя заполнены некорректно/неполностью!");
                }
                else
                //Если издательство было добавлено
                {
                    //BookID - ID издания
                    //AddNewPublication - добавить новое издание
                    int BookID = Control.AddNewPublication(TB_Name.Text, TB_BBK.Text, TB_UDK.Text, TB_Author.Text, PubID);
                    if (BookID == -1)
                    //Если издание не было добавлено:
                    {
                        MessageBox.Show("Поля издания заполнены некорректно/неполностью!");
                        //Удаление созданного экземпляра "Издатель":
                        reader=Control.ExecCommand("delete from Publisher where Publisher_ID=" + PubID);
                        reader.Close();
                    }
                    else
                    //Если издание было добавлено
                    {
                        //Added - был ли добавлен экземпляр "Книга"/"Серийное издание"
                        bool Added = false;
                        if (CB_PubType.SelectedIndex == 0)
                        //Если выбрана книга
                        {
                            //AddNewBook - операция по добавлению новой книги
                            Added = Control.AddNewBook(TB_ISBN.Text, TB_Pages.Text, BookID);
                        }
                        else
                        //Если выбран журнал
                        {
                            //AddNewJournal - операция по добавлению нового серийного издания
                            Added = Control.AddNewJournal(TB_ReleaseNumber.Text, TB_ISBN.Text.Substring(0,9), TB_Pages.Text, BookID);
                        }
                        if (!Added)
                        //Если не был добавлен
                        {
                            MessageBox.Show("Поля издания заполнены некорректно/неполностью!");
                            try
                            {
                                //Удаление созданных Издательства и Издания:
                                reader = Control.ExecCommand("delete from Publication where Publication_ID=" + BookID);
                                reader.Close();
                                reader = Control.ExecCommand("delete from Publisher where Publisher_ID=" + PubID);
                                reader.Close();
                            }
                            catch { }
                        }
                        else
                        {
                            Close();
                        }
                    }
                }
            }
            else
            //Если обновляется информация о существующем издании
            {
                //Обновление информации об Издательстве:
                bool OK = Control.UpdPublisher(TB_PubName.Text, TB_Year.Text, TB_City.Text);
                if (OK)
                //Если удалось обновить информацию:
                {
                    //Обновление информации о Издании:
                    OK = Control.UpdPublication(TB_Name.Text, TB_BBK.Text, TB_UDK.Text, TB_Author.Text);
                    if (OK)
                    //Если удалось обновить информацию:
                    {
                        if (CB_PubType.SelectedIndex == 0)
                        //Выбрана книга
                        {
                            //Обновление информации о Книге:
                            OK = Control.UpdBook(TB_ISBN.Text, TB_Pages.Text);
                        }
                        else
                        //Выбран журнал
                        {
                            //Обновление информации о Серийном издании:
                            OK = Control.UpdJournal(TB_ISBN.Text, TB_Pages.Text, TB_ReleaseNumber.Text);
                        }
                    }
                }
                if (!OK)
                //Если не удалось обновить информацию о существующем издании
                {
                    MessageBox.Show("Хотя бы 1 из полей заполнено некорректно!");
                }
                else
                {
                    Close();
                }
            }
            
        }
    }
}
