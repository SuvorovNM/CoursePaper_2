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
        //Проверка на то что в массиве correct все элементы равны true
        {
            bool OK = true;
            for (int i = 0; i < correct.Length; i++)
            {
                OK = OK && correct[i];
            }
            return OK;
        }        
        public static void XLOutput(string path, string[,] data,int Rows, int Cols)
        //Вывод таблицы data в файл с путем path
        //path - путь к файлу
        //data - названия столбцов и данные
        //Rows - количество строк
        //Cols - количество столбцов
        {
            //Проверка, что data - не пустой массив
            if (data.Length == 0)
                return;
            //Создание страницы Excel с названием Library_Report
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Library_Report");
            //Перенос значений из массива data в страницу Excel
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    worksheet.Cell(i + 1, j + 1).Value ="'"+ data[i, j];
                }
            }
            //Сохранение созданного документа Excel по пути path
            workbook.SaveAs(path);
        }
        public static int XLInput(string path)
        //Ввод книг, серийных изданий из файла path с расширением .xlsx
        //Возвращается количество добавленных изданий
        {
            //CorrectInput - Переменная, отслеживающая корректность данных
            bool CorrectInput = true;
            //correctexecuted - Количество добавленных изданий
            int correctexecuted = 0;
            //Открытие файла по пути path
            using (var workbook = new XLWorkbook(path))
            {
                //worksheet - первая страница файла .xlsx
                var worksheet = workbook.Worksheets.Worksheet(1);
                //quantity, size - количество добавляемых элементов: значение в ячейке A1
                string quantity = worksheet.Cell("A1").Value.ToString();
                int size=0;
                CorrectInput = Int32.TryParse(quantity, out size);
                //При большом количестве size обработка может занять очень много времени                
                if (!CorrectInput||size>10000) return 0;
                //books - массив значений из таблицы excel
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
                try
                {
                    for (int i = 0; i < size; i++)
                    {
                        //IsBook - тип издания (0-книга, 1-журнал)
                        string IsBook = books[i, 0].ToString();
                        //Name - название книги
                        string Name = books[i, 1].ToString();
                        //Author - автор книги
                        string Author = books[i, 2].ToString();

                        //string TypePub = books[i, 0].ToString();//
                        //BBK - ББК книги
                        string BBK = books[i, 3].ToString();
                        //UDK - УДК книги
                        string UDK = books[i, 4].ToString();
                        //ISBN - ISBN книги / ISSN журнала
                        string ISBN = books[i, 5].ToString();
                        //Pages - количество страниц
                        string Pages = books[i, 6].ToString();
                        //PubName - название издательства
                        string PubName = books[i, 7].ToString();
                        //PubYear - год издательства
                        string PubYear = books[i, 8].ToString();
                        //PubCity - город издательства
                        string PubCity = books[i, 9].ToString();
                        //Number - номер выпуска журнала (для книг не учитывается)
                        string Number = books[i, 10].ToString();
                        //Проверка корректности длин каждого из значений
                        CorrectInput = (IsBook == "0" || IsBook == "1") && Name.Length > 2 && Name.Length < 255 && Author.Length > 2 && Author.Length < 80 &&
                            BBK.Length > 0 && BBK.Length < 80 && UDK.Length > 0 && UDK.Length < 80 && ISBN.Length > 8 && ISBN.Length < 19 && Pages.Length > 0 && PubName.Length > 2 && PubName.Length < 80
                            && PubCity.Length > 2 && PubCity.Length < 40 && PubYear.Length == 4;
                        if (CorrectInput)
                        {
                            //PubCode - ID издательства (Publisher)
                            //AddNewPublisher - метод для добавления нового издателя
                            int PubCode = AddNewPublisher(PubName, PubYear, PubCity);
                            //Pub_ID - ID издания (Publication)
                            int Pub_ID = 0;
                            //Если издательство добавилось:
                            if (PubCode > 0)
                            {
                                //AddNewPublication - метод для добавления нового издания
                                Pub_ID = AddNewPublication(Name, BBK, UDK, Author, PubCode);
                                //Если издание добавилось:
                                if (Pub_ID > 0)
                                {
                                    //Если книга:
                                    if (IsBook == "0")
                                    {
                                        //Добавление новой книги
                                        AddNewBook(ISBN, Pages, Pub_ID);
                                    }
                                    //Если серийное издание:
                                    else if (IsBook == "1"&&Number.Length>0&& ISBN.Length==9)
                                    {
                                        //Добавление нового журнала
                                        AddNewJournal(Number, ISBN, Pages, Pub_ID);
                                    }
                                    //Если IsBook принимает любое значение, отличное от "0" и "1", или в длине номера выпуска или ISSN была допущена ошибка
                                    else
                                    {
                                        //Удаление издания (Publication)
                                        string sql = "delete from Publication where Publication_ID=" + Pub_ID;
                                        reader = ExecCommand(sql);
                                        reader.Close();
                                        //Удаление издателя (Publisher)
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
                        //Издание было добавлено, количество добавленных изданий инкрементируется
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
        //Обработчик команды sql; возвращает DBDataReader, полученный после обработки запроса
        {
            SqlCommand command = new SqlCommand(sql, Authorization.conn);
            DbDataReader reader = command.ExecuteReader();
            return reader;
        }        
        public static string GetPenalty(string Reader_ID)
        //Получение суммы штрафа для заданного читателя (Reader_ID - ID читателя)
        {
            string sql = "select sum(Penalty_Sum) from Penalty, BookGiving where Penalty_Code IS NOT NULL and Penalty.Deleted=0 and BookGiving.Deleted=0 and Penalty_Code=Penalty_ID and Librarian_Card_Code="+Reader_ID;
            DbDataReader reader = null;
            string penalty = "0";
            //Обработка команды для суммирования всех непогашенных задолженностей
            reader = ExecCommand(sql);
            //Если сумма нашлась:
            if (reader.HasRows)
            {
                reader.Read();
                penalty = reader[0].ToString();
                reader.Close();
            }
            //Если пользователь вообще ни разу не брал книгу (по умолчанию штраф налагается на любой акт сдачи книги, но стандартно штраф=0):
            if (penalty == "") penalty = "0,00";
            return penalty;
        }
        //Принятие книги с записью штрафа:
        public static bool GetBook(string Publication_ID, string Operation_ID, string LibrarianReciever, string Penalty_Info, string Penalty_Sum)
        //Обработчик получения книги библиотекарем от читателя
        //Publication_ID - ID издания
        //Operation_ID - ID операции по выдаче/принятии книги
        //LibrarianReciever - ID библиотекаря, получающего книгу
        //Penalty_Info - информация о штрафе (по умолчанию = "")
        //Penalty_Sum - сумма налагаемого штрафа (по умолчанию = 0)
        {
            //Создание сущности "Штраф"
            string sql = "insert into Penalty (Penalty_Info, Penalty_Sum, Deleted) values ('"+Penalty_Info+"', '"+Penalty_Sum+"', 0)";
            DbDataReader reader = null;
            string Penalty_ID = "";
            try
            {                
                reader = ExecCommand(sql);
                reader.Close();
                //Получение ID созданного экземпляра "Штраф"
                sql = "select max(Penalty_ID) from Penalty";
                reader = ExecCommand(sql);
                reader.Read();
                Penalty_ID = reader[0].ToString();
                reader.Close();
                //today - ГГГГ-ММ-ДД (дата - сегодня)
                string today = DateTime.Today.Year+"-"+DateTime.Today.Month+"-"+DateTime.Today.Day;
                //Обновление операции по выдаче принятии/книги добавлением экземпляра штрафа, 
                //даты реального возврата и штатным номером принявшего книгу библиотекаря
                sql = "update BookGiving set Penalty_Code="+Penalty_ID+", Real_Return_Date='"+today+"', LibrarianReciever_Staff_Code="+LibrarianReciever+" where Operation_ID="+Operation_ID;
                reader = ExecCommand(sql);
                reader.Close();
                //Обновление поля "Наличие" на 1 (т.е. книга появится в списке доступных для выдачи)
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
        //id - ID издания
        {
            string sql = "select Librarian_Card_Code, Give_Date, Expected_Return_Date, Operation_ID from BookGiving where Publication_Code="+id+" and Real_Return_Date IS NULL";
            //Получение данных:
            //Librarian_Card_Code - ID читателя (номер читательского билета)
            //Give_Date - дата выдачи книги
            //Expected_Return_Date - ожидаемая дата возврата (т.е. книга выдана до этой даты)
            //Operation_ID - ID операции по выдаче/принятии книги
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
        
        public static string GiveBook(string LibrarianGiver_Staff_Code, string Librarian_Card_Code, string Publication_Code, string Give_Date, string Expected_Return_Date)
        //Обработчик выдачи книги читателю
        //Возвращает код операции выдачи
        //LibrarianGiver_Staff_Code - код библиотекаря, выдающего книгу
        //Librarian_Card_Code - ID читателя (номер читательского билета)
        //Publication_Code - ID издания
        //Give_Date - дата выдачи книги
        //Expected_Return_Date - ожидаемая дата возврата (т.е. книга выдана до этой даты)
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
        public static bool BookExists(string id)
        //Проверка на наличие книги в БД и ее наличия на складе (id - ID издания)
        {
            bool exists=false;
            string sql = "select * from Publication where Publication_ID="+id+" and Deleted=0 and Available=1";
            DbDataReader reader = ExecCommand(sql);
            exists = reader.HasRows;
            reader.Close();
            return exists;
        }
        public static int AddNewPublisher(string Name, string Year, string City)
        //Операция по добавлению нового издателя
        //Name - название издательства
        //Year - год издания
        //City - город, в котором была издана книга
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
        //Операция по изменению существующего издателя
        //Name - название издательства
        //Year - год издания
        //City - город, в котором была издана книга
        //Возвращает true - если удалось изменить, false - если не удалось
        {
            //PubID - ID выбранного издания
            string PubID = Books.SelectedBook;
            //Поиск ID издательства текущей книги:
            string sqlID = "select Publisher_ID from Publisher, Publication where Publisher_ID=Publisher_Code and Publication_ID="+PubID;
            DbDataReader reader = ExecCommand(sqlID);
            bool exist = reader.HasRows;            
            if (exist)
            {
                reader.Read();
                //PublisherID - ID издательства текущей книги
                string PublisherID = reader[0].ToString();
                reader.Close();
                //Изменение данных о Издательстве с Publisher_ID=PublisherID
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
        //Операция по изменению текущего издания
        //Name - новое название издания
        //BBK - новое ББК книги
        //UDK - новое УДК книги
        //Author - новый автор книги
        //Возвращает true - если удалось изменить, false - если не удалось
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
        //Операция по добавлению нового издания
        //Name - новое название издания
        //BBK - новое ББК книги
        //UDK - новое УДК книги
        //Author - новый автор книги
        //Publisher_Code - ID издательства
        //Возвращает ID добавленного издания или -1, если издание не было добавлено
        {
            //Publication_ID
            int Publication_ID = -1;
            //Добавление нового издания:
            string sql = "insert into Publication(Name, BBK, UDK, Author, Publisher_Code, Deleted, Available) values ('"+Name+"', '"+BBK+"', '"+UDK+"', '"+Author+"', '"+Publisher_Code+"', 0, 1)";
            try
            {
                DbDataReader reader = ExecCommand(sql);
                reader.Close();
                //Получение ID добавленного издания:
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
        //Операция по добавлению новой книги
        //ISBN - ISBN добавляемой книги
        //Page_Quantity - количество страниц в книге
        //Publication_Code - ID издания, на которое будет ссылаться книга
        //Возвращает true, если книга была добавлена; false - если не была добавлена
        {
            string sql = "insert into Book(ISBN, Page_Quantity, Publication_Code, Deleted) values ('"+ISBN+"', '"+Page_Quantity+"', '"+Publication_Code+"', 0)";
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
        public static bool UpdBook(string ISBN, string Page_Quantity)
        //Операция по изменению информации о книге
        //ISBN - ISBN добавляемой книги
        //Page_Quantity - количество страниц в книге
        //Возвращает true, если информация о книге была успешно изменена, иначе - false
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
        //Операция по изменению информации о периодическом издании
        //ISSN - ISSN добавляемого периодического издания
        //Page_Quantity - количество страниц в издании
        //Release_Number - номер выпуска журнала
        //Возвращает true, если информация о книге была успешно изменена, иначе - false
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
        //Операция по добавлению нового периодического издания
        //ISSN - ISSN добавляемого периодического издания
        //Page_Quantity - количество страниц в издании
        //Release_Number - номер выпуска журнала
        //Publication_Code - ID издания, на которое будет ссылаться книга
        //Возвращает true, если журнал был добавлен, иначе - false
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
        public static bool AddNewLibrarian(string FIO, string Phone_Number, string Email, DateTime Birthday, string Region, string City, string Street, string House_Number,string Flat_Number, string Password, DateTime Hiring)
        //Операция по добавлению нового библиотекаря
        //FIO - ФИО библиотекаря
        //Phone_Number - номер телефона библиотекаря
        //Email - email библиотекаря
        //Birthday - дата рождения
        //Region - регион проживания
        //City - город проживания
        //Street - улица проживания
        //House_Number - номер дома проживания
        //Flat_Number - номер квартиры проживания
        //Password - пароль для входа в приложение
        //Hiring - дата найма библиотекаря
        {
            //Добавление нового экземпляра Адрес:
            string sql = "insert into Address(Region, City, Street, House_Number, Flat_Number, Deleted) values ('" + Region + "', '" + City + "', '" + Street + "', '" + House_Number + "', '" + Flat_Number + "', 0)";
            DbDataReader reader = ExecCommand(sql);
            reader.Close();
            //Получение ID добавленного адреса:
            sql = "select max(Address_ID) from Address";
            reader = ExecCommand(sql);
            reader.Read();
            string Address_ID = reader[0].ToString();
            reader.Close();
            //Добавление нового экземпляра "Человек":
            string Bday = Birthday.Year + "-" + Birthday.Month + "-" + Birthday.Day;
            try
            {
                sql = "insert into Person(FIO, Birthday, Phone_Number, Email, Address_Code, Deleted) values ('" + FIO + "', '" + Bday + "', '" + Phone_Number + "', '" + Email + "', '" + Address_ID + "', 0)";
                reader = ExecCommand(sql);
                reader.Close();
            }
            catch
            {
                //Если не удалось добавить экземпляр "Человек":
                if (reader != null)
                {
                    reader.Close();
                }
                //Удаление созданного экземпляра Адрес:
                sql = "delete from Address where Address_ID=" + Address_ID;
                reader = ExecCommand(sql);
                reader.Close();
                return false;
            }
            //Получение ID созданного экземпляра Человек:
            sql= "select max(Person_ID) from Person";
            reader = ExecCommand(sql);
            reader.Read();
            string Person_ID = reader[0].ToString();
            reader.Close();
            //Добавление нового экземпляра Библиотекарь:
            string Hiring_Date = Hiring.Year + "-" + Hiring.Month + "-" + Hiring.Day;
            sql="insert into Librarian(Person_Code, Hiring_Date, Password, Deleted, Privilege) values ('" + Person_ID + "', '" + Hiring_Date + "', '"+Password+"', 0, 0)";
            try
            {
                reader = ExecCommand(sql);
                reader.Close();
                return true;
            }
            catch
            {
                //Если не удалось добавить экземпляр "Библиотекарь":
                if (reader != null)
                    reader.Close();
                //Удаление созданного экземпляра Человек:
                sql = "delete from Person where Person_ID=" + Person_ID;
                reader = ExecCommand(sql);
                reader.Close();
                //Удаление созданного экземпляра Адрес:
                sql = "delete from Address where Address_ID=" + Address_ID;
                reader = ExecCommand(sql);
                reader.Close();
                return false;
            }
        }

        public static bool ChangeLibrarian(string FIO, string Phone_Number, string Email, DateTime Birthday, string Region, string City, string Street, string House_Number, string Flat_Number, string Password, DateTime Hiring)
        //Операция по изменению информации о существующем библиотекаре
        //FIO - ФИО библиотекаря
        //Phone_Number - номер телефона библиотекаря
        //Email - email библиотекаря
        //Birthday - дата рождения
        //Region - регион проживания
        //City - город проживания
        //Street - улица проживания
        //House_Number - номер дома проживания
        //Flat_Number - номер квартиры проживания
        //Password - пароль для входа в приложение
        //Hiring - дата найма библиотекаря
        {
            //Получение Person_ID (ID сущности Человек), Address_ID (ID сущности Адрес)
            //Librarians.SelectedUser - текущий выбранный библиотекарь
            string IDs = "select Person_ID, Address_ID from Librarian, Person, Address where Librarian.Deleted=0 and Person_Code=Person_ID and Address_Code=Address_ID and Staff_Number=" + Librarians.SelectedUser;
            DbDataReader reader = ExecCommand(IDs);
            //Если такие ID были найдены:
            if (reader.HasRows)
            {
                reader.Read();
                string Person_ID = reader[0].ToString();
                string Address_ID = reader[1].ToString();
                reader.Close();
                //Изменение информации о Адресе:
                string sql = "update Address set Region='" + Region + "', City='" + City + "', Street='" + Street + "', House_Number='" + House_Number + "', Flat_Number='" + Flat_Number + "' where Address_ID=" + Address_ID;
                try
                {
                    reader = ExecCommand(sql);
                    reader.Close();
                }
                catch
                {
                    reader.Close();
                    return false;
                }
                //Изменение информации об атрибутах сущности Человек:
                string birth = Birthday.Year + "-" + Birthday.Month + "-" + Birthday.Day;
                string Hiring_Date = Hiring.Year + "-" + Hiring.Month + "-" + Hiring.Day;
                sql = "update Person set FIO='" + FIO + "', Birthday='" + birth + "', Phone_Number='" + Phone_Number + "', Email='" + Email + "' where Person_ID=" + Person_ID;
                try
                {
                    reader = ExecCommand(sql);
                    reader.Close();
                }
                catch
                {
                    reader.Close();
                    return false;
                }
                //Изменение информации об атрибутах сущности Библиотекарь:
                sql = "update Librarian set Hiring_Date='"+Hiring_Date+"', Password='"+Password+"' where Person_Code="+Person_ID;
                try
                {
                    reader = ExecCommand(sql);
                    reader.Close();
                    return true;
                }
                catch
                {
                    reader.Close();
                    return false;
                }
            }
            //Если не было найдено Person_ID, Address_ID
            else
            {
                reader.Close();
                return false;
            }
        }

        public static bool DeleteLib(string Staff_Number)
        //Операция по удалению библиотекаря
        //Staff_Number - ID текущего выбранного библиотекаря (его штатный номер)
        {
            //Получение Person_ID (ID сущности Человек), Address_ID (ID сущности Адрес)
            string CheckForExistance = "select Person_ID, Address_ID from Librarian, Person, Address where Librarian.Deleted=0 and Person_Code=Person_ID and Address_Code=Address_ID and Staff_Number=" + Staff_Number;
            DbDataReader reader = ExecCommand(CheckForExistance);
            //Если такие ID были найдены:
            if (reader.HasRows)
            {
                reader.Read();
                string Person_ID = reader[0].ToString();
                string Address_ID = reader[1].ToString();
                reader.Close();
                //Удаление сущности "Библиотекарь" (не полное удаление - атрибут Deleted -> TRUE)
                string UpdatingDelete = "update Librarian set Deleted=1 where Staff_Number=" + Staff_Number;
                reader = ExecCommand(UpdatingDelete);
                reader.Close();
                //Удаление сущности "Человек" (не полное удаление - атрибут Deleted -> TRUE)
                UpdatingDelete = "update Person set Deleted=1 where Person_ID=" + Person_ID;
                reader = ExecCommand(UpdatingDelete);
                reader.Close();
                //Удаление сущности "Адрес" (не полное удаление - атрибут Deleted -> TRUE)
                UpdatingDelete = "update Address set Deleted=1 where Address_ID=" + Address_ID;
                reader = ExecCommand(UpdatingDelete);
                reader.Close();
                return true;
            }
            else
            {
                reader.Close();
                return false;
            }
        }

    }
}
