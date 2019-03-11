using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Librarian
    //Класс для сущности Библиотекарь
    {
        //ID - ID текущей сущности "Библиотекарь" в БД
        public string ID;
        //FIO - ФИО библиотекаря
        public string FIO;
        //Birth - дата рождения
        public string Birth;
        //Phone - номер телефона
        public string Phone;
        //Email - электронная почта библиотекаря
        public string Email;
        //Address - адрес проживания библиотекаря
        public string Address;
        public Librarian(string _ID,string _FIO, string _Birth, string _Phone, string _Email, string _Address)
        {
            ID = _ID;
            FIO = _FIO;
            Birth = _Birth;
            Phone = _Phone;
            Email = _Email;
            Address = _Address;
        }
    }
}
