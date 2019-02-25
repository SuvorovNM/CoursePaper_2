using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Librarian
    {
        public string ID;
        public string FIO;
        public string Birth;
        public string Phone;
        public string Email;
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
