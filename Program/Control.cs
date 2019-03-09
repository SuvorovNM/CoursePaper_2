using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using ClosedXML;
using ClosedXML.Excel;

namespace Program
{
    public class Control
    {
        public static bool CheckCorrect(bool[] correct)
        {
            bool OK = true;
            for (int i = 0; i < correct.Length; i++)
            {
                OK = OK && correct[i];
            }
            return OK;
        }
        //path - путь к файлу
        //data - названия столбцов и данные
        public static void XLOutput(string path, string[,] data,int Rows, int Cols)
        {
            if (data.Length == 0)
                return;
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Library_Report");           
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    worksheet.Cell(i + 1, j + 1).Value ="'"+ data[i, j];
                }
            }
            workbook.SaveAs(path);
        }
        public static int XLInput(string path)
        {
            bool CorrectInput = true;
            int correctexecuted = 0;
            using (var workbook = new XLWorkbook(path))
            {
                var worksheet = workbook.Worksheets.Worksheet(1);//Position 0/1?
                string quantity = worksheet.Cell("A1").Value.ToString();
                int size=0;
                CorrectInput = Int32.TryParse(quantity, out size);
                if (!CorrectInput) return 0;
                object[,] books = new object[size, 11];
                try
                {
                    for (int i = 0; i < size; i++)
                    {
                        for (int j = 0; j < 11; j++)
                        {
                            books[i, j] = worksheet.Cell(i + 2, j+1).Value;
                        }
                    }
                }
                catch
                {
                    return 0;
                }
                DbDataReader reader = null;
                /* string sql = "";
                 SqlCommand command = new SqlCommand(sql,Authorization.conn);*/
                try
                {
                    for (int i = 0; i < size; i++)
                    {
                        string IsBook = books[i, 0].ToString();
                        string Name = books[i, 1].ToString();
                        string Author = books[i, 2].ToString();
                        string TypePub = books[i, 0].ToString();//
                        string BBK = books[i, 3].ToString();
                        string UDK = books[i, 4].ToString();
                        string ISBN = books[i, 5].ToString();
                        string Pages = books[i, 6].ToString();
                        string PubName = books[i, 7].ToString();
                        string PubYear = books[i, 8].ToString();
                        string PubCity = books[i, 9].ToString();
                        string Number = books[i, 10].ToString();
                        CorrectInput = (IsBook == "0" || IsBook == "1") && Name.Length > 2 && Name.Length < 255 && Author.Length > 2 && Author.Length < 80 &&
                            BBK.Length > 0 && BBK.Length < 80 && UDK.Length > 0 && UDK.Length < 80 && ISBN.Length > 8 && ISBN.Length < 19 && Pages.Length > 0 && PubName.Length > 2 && PubName.Length < 80
                            && PubCity.Length > 2 && PubCity.Length < 40 && PubYear.Length == 4;
                        if (CorrectInput)
                        {
                            int PubCode = AddNewPublisher(PubName, PubYear, PubCity);
                            int Pub_ID = 0;
                            if (PubCode > 0)
                            {
                                Pub_ID = AddNewPublication(Name, BBK, UDK, Author, PubCode);
                                if (Pub_ID > 0)
                                {
                                    if (IsBook == "0")
                                    {
                                        AddNewBook(ISBN, Pages, Pub_ID);
                                    }
                                    else if (IsBook == "1"&&Number.Length>0&& ISBN.Length==9)
                                    {
                                        AddNewJournal(Number, ISBN, Pages, Pub_ID);
                                    }
                                    else
                                    {
                                        string sql = "delete from Publication where Publication_ID=" + Pub_ID;
                                        reader = ExecCommand(sql);
                                        reader.Close();
                                        sql = "delete from Publisher where Publisher_ID" + PubCode;
                                        reader = ExecCommand(sql);
                                        reader.Close();
                                        return correctexecuted;
                                    }
                                }
                                else return correctexecuted;
                            }
                        }
                        else return correctexecuted;
                        correctexecuted++;
                    }
                    return correctexecuted;
                }
                catch
                {
                    return correctexecuted;
                }
            }
        }
        public static DbDataReader ExecCommand(string sql)
        {
            SqlCommand command = new SqlCommand(sql, Authorization.conn);
            DbDataReader reader = command.ExecuteReader();
            return reader;
        }
        //Сумма штрафа для заданного читателя
        public static string GetPenalty(string Reader_ID)
        {
            string sql = "select sum(Penalty_Sum) from Penalty, BookGiving where Penalty_Code IS NOT NULL and Penalty.Deleted=0 and BookGiving.Deleted=0 and Penalty_Code=Penalty_ID and Librarian_Card_Code="+Reader_ID;
            DbDataReader reader = null;
            string penalty = "0";
            reader = ExecCommand(sql);
            if (reader.HasRows)
            {
                reader.Read();
                penalty = reader[0].ToString();
                reader.Close();
            }
            if (penalty == "") penalty = "0,00";
            return penalty;
        }
        //Принятие книги с записью штрафа:
        public static bool GetBook(string Publication_ID, string Operation_ID, string LibrarianReciever, string Penalty_Info, string Penalty_Sum)
        {
            string sql = "insert into Penalty (Penalty_Info, Penalty_Sum, Deleted) values ('"+Penalty_Info+"', '"+Penalty_Sum+"', 0)";
            DbDataReader reader = null;
            string Penalty_ID = "";
            try
            {
                reader = ExecCommand(sql);
                reader.Close();
                sql = "select max(Penalty_ID) from Penalty";
                reader = ExecCommand(sql);
                reader.Read();
                Penalty_ID = reader[0].ToString();
                reader.Close();
                string today = DateTime.Today.Year+"-"+DateTime.Today.Month+"-"+DateTime.Today.Day;
                sql = "update BookGiving set Penalty_Code="+Penalty_ID+", Real_Return_Date='"+today+"', LibrarianReciever_Staff_Code="+LibrarianReciever+" where Operation_ID="+Operation_ID;
                reader = ExecCommand(sql);
                reader.Close();
                sql = "update Publication set Available=1 where Publication_ID=" + Publication_ID;
                reader = ExecCommand(sql);
                reader.Close();
                return true;
            }
            catch
            {
                if (reader != null)
                    reader.Close();
                return false;
            }
        }
        public static bool GetBook(string Publication_ID, string Operation_ID, string LibrarianReciever)
        {
            string today = DateTime.Today.Year + "-" + DateTime.Today.Month + "-" + DateTime.Today.Day;
            string sql = "update BookGiving set Real_Return_Date='" + today + "', LibrarianReciever_Staff_Code=" + LibrarianReciever + " where Operation_ID=" + Operation_ID;
            DbDataReader reader = null;
            try
            {
                reader = ExecCommand(sql);
                reader.Close();
                sql = "update Publication set Available=1 where Publication_ID=" + Publication_ID;
                reader = ExecCommand(sql);
                reader.Close();
                return true;
            }
            catch
            {
                if (reader != null)
                    reader.Close();
                return false;
            }
        }
        public static object[] GetInfoAboutGivenBook(string id)
        //Получение информации о выданной книге (если она на самом деле выдана)
        {
            string sql = "select Librarian_Card_Code, Give_Date, Expected_Return_Date, Operation_ID from BookGiving where Publication_Code="+id+" and Real_Return_Date IS NULL";
            DbDataReader reader = null;
            try
            {
                reader = ExecCommand(sql);
                if (reader.HasRows)
                {
                    reader.Read();
                    object[] items = new object[4];
                    items[0] = reader[0].ToString();
                    items[1] = (DateTime)reader[1];
                    items[2] = (DateTime)reader[2];
                    items[3] = reader[3].ToString();
                    reader.Close();
                    return items;
                }
                else
                {
                    reader.Close();
                    return null;
                }                
            }
            catch
            {
                if (reader != null)
                {
                    reader.Close();
                }
                return null;
            }
        }
        //Возвращает код операции выдачи
        public static string GiveBook(string LibrarianGiver_Staff_Code, string Librarian_Card_Code, string Publication_Code, string Give_Date, string Expected_Return_Date)
        {
            string sql = "insert into BookGiving(LibrarianGiver_Staff_Code, Librarian_Card_Code, Publication_Code, Give_Date, Expected_Return_Date, Deleted) " +
                "values ('" + LibrarianGiver_Staff_Code + "', '" + Librarian_Card_Code + "', '" + Publication_Code + "', '" + Give_Date + "', '" + Expected_Return_Date + "', 0)";
            DbDataReader reader = null;
            try
            {
                //Создание экземпляра "Выдача книг"
                reader = ExecCommand(sql);
                reader.Close();
                //Поиск ID операции:
                sql = "select max(Operation_ID) from BookGiving";
                reader = ExecCommand(sql);
                reader.Read();
                string ID = reader[0].ToString();
                reader.Close();
                //Книги теперь нет в наличии:
                sql = "update Publication set Available=0 where Publication_ID="+ Publication_Code;
                reader = ExecCommand(sql);
                reader.Close();
                return ID;
            }
            catch
            {
                if (reader!=null)
                reader.Close();
                return "-1";
            }
        }
        //Проверка на наличие книги в БД и ее наличия на складе
        public static bool BookExists(string id)
        {
            bool exists=false;
            string sql = "select * from Publication where Publication_ID="+id+" and Deleted=0 and Available=1";
            DbDataReader reader = ExecCommand(sql);
            exists = reader.HasRows;
            reader.Close();
            return exists;
        }
        public static int AddNewPublisher(string Name, string Year, string City)
        //Возвращает -1, если не было добавлено
        //Возвращает индекс добавленного элемента, если добавление прошло успешно
        {
            int Publisher_ID = -1;
            string sql = "insert into Publisher(Name, Year, City, Deleted) values ('"+Name+"', '"+Year+"', '"+City+"', 0)";
            try
            {
                DbDataReader reader = ExecCommand(sql);
                reader.Close();
                string ID = "select max(Publisher_ID) from Publisher";
                reader = ExecCommand(ID);
                reader.Read();
                string number = reader[0].ToString();
                reader.Close();
                Int32.TryParse(number, out Publisher_ID);
            }
            catch 
            {
                return -1;
            }
            return Publisher_ID;
        }
        public static bool UpdPublisher(string Name, string Year, string City)
        {
            string PubID = Books.SelectedBook;
            string sqlID = "select Publisher_ID from Publisher, Publication where Publisher_ID=Publisher_Code and Publication_ID="+PubID;
            DbDataReader reader = ExecCommand(sqlID);
            bool exist = reader.HasRows;            
            if (exist)
            {
                reader.Read();
                string PublisherID = reader[0].ToString();
                reader.Close();
                string sqlUpd = "update Publisher set Name='"+Name+"', Year='"+Year+"', City='"+City+"' where Publisher_ID='"+PublisherID+"'";
                try
                {
                    reader = ExecCommand(sqlUpd);
                    reader.Close();
                    return true;
                }
                catch
                {
                    reader.Close();
                    return false;
                }
                
            }
            else
            {
                reader.Close();
                return false;
            }
        }
        public static bool UpdPublication(string Name, string BBK, string UDK, string Author)
        {
            DbDataReader reader = null;
            string PubID = Books.SelectedBook;
            string sqlUpd = "update Publication set Name='"+Name+"', BBK='"+BBK+"', UDK='"+UDK+"', Author='"+Author+"' where Publication_ID="+PubID;
            try
            {
                reader = ExecCommand(sqlUpd);
                reader.Close();
                return true;
            }
            catch
            {
                reader.Close();
                return false;
            }
        }
        public static int AddNewPublication(string Name, string BBK, string UDK, string Author, int Publisher_Code)
        {
            int Publication_ID = -1;
            string sql = "insert into Publication(Name, BBK, UDK, Author, Publisher_Code, Deleted, Available) values ('"+Name+"', '"+BBK+"', '"+UDK+"', '"+Author+"', '"+Publisher_Code+"', 0, 1)";
            try
            {
                DbDataReader reader = ExecCommand(sql);
                reader.Close();
                string ID = "select max(Publication_ID) from Publication";
                reader = ExecCommand(ID);
                reader.Read();
                string number = reader[0].ToString();
                reader.Close();
                Int32.TryParse(number, out Publication_ID);
            }
            catch
            {
                return -1;
            }
            return Publication_ID;
        }
        public static bool AddNewBook(string ISBN, string Page_Quantity, int Publication_Code)
        {
            string sql = "insert into Book(ISBN, Page_Quantity, Publication_Code, Deleted) values ('"+ISBN+"', '"+Page_Quantity+"', '"+Publication_Code+"', 0)";
            try
            {
                DbDataReader reader = ExecCommand(sql);//Вынести наверх
                reader.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static bool UpdBook(string ISBN, string Page_Quantity)
        {
            string PubID = Books.SelectedBook;
            DbDataReader reader = null;
            string sqlUpd = "update Book set ISBN='"+ISBN+"', Page_Quantity='"+Page_Quantity+"' where Publication_Code="+PubID;
            try
            {
                reader = ExecCommand(sqlUpd);
                reader.Close();
                return true;
            }
            catch
            {
                reader.Close();
                return false;
            }
        }
        public static bool UpdJournal(string ISSN, string Page_Quantity, string Release_Number)
        {
            string PubID = Books.SelectedBook;
            DbDataReader reader = null;
            string sqlUpd = "update Journal set ISSN='"+ISSN+"', Page_Quantity='"+Page_Quantity+"', Release_Number='"+Release_Number+"' where Publication_Code="+PubID;
            try
            {
                reader = ExecCommand(sqlUpd);
                reader.Close();
                return true;
            }
            catch
            {
                reader.Close();
                return false;
            }
        }
        public static bool AddNewJournal(string Release_Number, string ISSN, string Page_Quantity, int Publication_Code)
        {
            string sql = "insert into Journal(Release_Number, ISSN, Page_Quantity, Publication_Code, Deleted) values ('"+Release_Number+"', '" + ISSN + "', '" + Page_Quantity + "', '" + Publication_Code + "', 0)";
            try
            {
                DbDataReader reader = ExecCommand(sql);
                reader.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static bool AddNewLibrarian(string FIO, string Phone_Number, string Email, DateTime Birthday, string Region, string City, string Street, string House_Number,string Flat_Number, string Password)
        //Добавление нового библиотекаря
        {
            string sql = "insert into Address(Region, City, Street, House_Number, Flat_Number, Deleted) values ('" + Region + "', '" + City + "', '" + Street + "', '" + House_Number + "', '" + Flat_Number + "', 0)";
            DbDataReader reader = ExecCommand(sql);
            reader.Close();
            sql = "select max(Address_ID) from Address";
            reader = ExecCommand(sql);
            reader.Read();
            string Address_ID = reader[0].ToString();
            reader.Close();
            string Bday = Birthday.Year + "-" + Birthday.Month + "-" + Birthday.Day;
            try
            {
                sql = "insert into Person(FIO, Birthday, Phone_Number, Email, Address_Code, Deleted) values ('" + FIO + "', '" + Bday + "', '" + Phone_Number + "', '" + Email + "', '" + Address_ID + "', 0)";
                reader = ExecCommand(sql);
                reader.Close();
            }
            catch
            {
                if (reader != null)
                {
                    reader.Close();
                }
                sql = "delete from Address where Address_ID=" + Address_ID;
                reader = ExecCommand(sql);
                reader.Close();
                return false;
            }
            sql= "select max(Person_ID) from Person";
            reader = ExecCommand(sql);
            reader.Read();
            string Person_ID = reader[0].ToString();
            reader.Close();
            string Hiring_Date = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
            sql="insert into Librarian(Person_Code, Hiring_Date, Password, Deleted, Privilege) values ('" + Person_ID + "', '" + Hiring_Date + "', '"+Password+"', 0, 0)";
            try
            {
                reader = ExecCommand(sql);
                reader.Close();
                return true;
            }
            catch
            {
                sql = "delete from Person where Person_ID=" + Person_ID;
                reader = ExecCommand(sql);
                reader.Close();
                sql = "delete from Address where Address_ID=" + Address_ID;
                reader = ExecCommand(sql);
                reader.Close();
                return false;
            }
        }

    }
}
