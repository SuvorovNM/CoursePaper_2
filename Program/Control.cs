using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;

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
        public static DbDataReader ExecCommand(string sql)
        {
            SqlCommand command = new SqlCommand(sql, Authorization.conn);
            DbDataReader reader = command.ExecuteReader();
            return reader;
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
    }
}
